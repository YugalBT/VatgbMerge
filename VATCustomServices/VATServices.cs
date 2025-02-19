using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATCustomServices.Helper;
using static Standing_Order_Vat_App.Common.Helper.Enumeration;



namespace VATCustomServices
{
    public class VATServices
    {
        string proofSequence = "", source = "", checkNumber = "",
            transactionAmount = "", transCode = "", CIF = "", acct = "", custName = "",  branch = "";

        DateTime rptDate, lastAcessTime = DateTime.MinValue;
        string[] reportFields = { };
        SqlConnection conn;
        SqlCommand cmd;
        int numValidDataFields = 0, j = 0;
        double charged = 0, vat = 0, natFees = 0, transAmt = 0;
        //SendMail mail;
        System.IO.TextReader readFile;
        System.Timers.Timer timer;
        int printlog = 0;
        StringBuilder sb = new StringBuilder();
        string extension;
        string logfilepath = "";
        double VatValue = 0;

        //Fields data that should not be read and add in DB
        string[] arr = { "SERVICE", "CHG", "SEQUENCE", "CODE", "C-I-F", "LST", "REPORT", "CY", "NUMBER", "TOTALS", "DDA", "ACCOUNT", "***", "=", "GENERATED", "SYSTEM" };


        public async Task<IGeneralResult<string>> ProcessNewFiles(int mnth, string vatConnectionString, string connectionstring, string filePath, int printLog, string logpath, FolderEnum foldername)
        {

            logfilepath = logpath;
            printlog = printLog;
            if (printlog > 0)
            {
                sb.Clear();
                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                sb.Append("log start\n");
                File.AppendAllText(logfilepath, sb.ToString());
            }

            IGeneralResult<string> res = new GeneralResult<string>();
            if (mnth < 10)
            {
                extension = "0" + mnth;
            }
            else
            {
                extension = mnth.ToString();
            }

            string path = Path.Combine(filePath, foldername.ToString(), extension);
            string fileMovePath = Path.Combine(filePath.TrimEnd('\\') + "_complete", foldername.ToString(), extension);
            if (Directory.Exists(path))
            {
                string dirMth, msg;
                string result = "";
                conn = new SqlConnection(connectionstring);
                String[] allFiles = null;
                try
                {
                    allFiles = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    res.Successful = false;
                    res.Message = ex.Message;
                }
                // get the report date
                try
                {
                    foreach (string file in allFiles)
                    {
                        if (!file.Contains("_08"))
                        {
                            //get report date

                            FileInfo fi = new FileInfo(file);
                            string extensionName = fi.Extension.Remove(0, 1);

                            string year = extensionName.Substring(0, 4);

                            string extensionaftergetYear = extensionName.Remove(0, 4);

                            string month = extensionaftergetYear.Substring(0, 2);

                            string extensionaftergetmonth = extensionName.Remove(0, 6);

                            string day = extensionaftergetmonth.Substring(0, 2);

                            if (Convert.ToInt32(year) >= 2019)
                            {
                                rptDate = Convert.ToDateTime(((File.GetLastWriteTime(file)).ToShortDateString()));

                                rptDate = Convert.ToDateTime(month + "/" + day + "/" + year);

                                branch = GetBranch(file);

                                VatValue = Common.GetVatApplyValue(vatConnectionString, rptDate);

                                switch (foldername)
                                {
                                    case FolderEnum.dda:
                                        if (file.ToLower().Contains("dda132"))
                                        {
                                            result = WriteDDA132RecsToDb(file, rptDate, branch, conn);
                                        }
                                        else if (file.ToLower().Contains("ddascj"))

                                        {
                                            result = WriteDDASCJRecsToDb(file, rptDate, branch, conn);
                                        }
                                        else if (file.ToLower().Contains("ddacur_00"))
                                        {
                                            result = WriteDDACURRecsToDb(file, rptDate, branch, conn);
                                        }
                                        break;
                                    case FolderEnum.lon:
                                        if (file.ToLower().Contains("lon132"))
                                        {
                                            result = WriteLON132RecsToDb(file, rptDate, branch, conn);
                                        }
                                        break;
                                    case FolderEnum.misc:
                                        if (file.ToLower().Contains("sus702"))
                                        {
                                            result = WriteSUS702RecsToDb(file, rptDate, branch, conn);
                                        }
                                        break;
                                    case FolderEnum.sav:
                                        if (file.ToLower().Contains("sav132"))
                                        {
                                            result = WriteSAV132RecsToDb(file, rptDate, branch, conn);
                                        }
                                        break;
                                }

                                if (result == "success")
                                {
                                    if (!Directory.Exists(fileMovePath))
                                    {
                                        Directory.CreateDirectory(fileMovePath);
                                    }
                                    string destinationFileName = Path.Combine(fileMovePath, fi.Name);
                                    File.Copy(file, destinationFileName, true);
                                    File.Delete(file);
                                    res.Message = "Success";
                                    res.Successful = true;
                                }
                                else
                                {
                                    res.Message = "Something went wrong.";
                                    res.Successful = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    res.Message = ex.Message;
                    res.Successful = false;
                }
            }
            else
            {
                res.Message = "Folder not found.";
                res.Successful = false;
            }
            return res;
        }

        private string GetBranch(string f)
        {
            string branch = "";
            //get the branch name
            if (f.Contains("_00"))
                branch = "0";
            else if (f.Contains("_01"))
                branch = "1";
            else if (f.Contains("_02"))
                branch = "2";
            else if (f.Contains("_03"))
                branch = "3";
            else if (f.Contains("_04"))
                branch = "4";
            else if (f.Contains("_08"))
                branch = "8";
            else if (f.Contains("_09"))
                branch = "9";

            return branch;
        }

        private string GetExtension(out string fileMth)
        {
            DateTime date = DateTime.Now;
            string ext;

            int mth = date.Month;

            if (mth < 10)
                fileMth = "0" + mth.ToString();
            else
                fileMth = mth.ToString();

            ext = fileMth.ToString();

            return ext;
        }


        #region Folder data Calculation

        //DDA Folder Complete Calculation by New Approch
        private string WriteDDASCJRecsToDb(string fileName, DateTime rptDate, string branch, SqlConnection conn)
        {

            string result = "";
            try
            {
                Thread.Sleep(1000);
                //readFile = new StreamReader(fileName);
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            transactionAmount = line.Substring(77, 6).Trim();
                            if (transactionAmount != ".00")
                            {
                                acct = line.Substring(0, 16).Trim();
                                custName = line.Substring(17, 18).Trim();
                                double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                                charged = Math.Round(parseAmount, 2);
                                natFees = Math.Round((charged / VatValue), 2);
                                vat = Math.Round((charged - natFees), 2);
                                if (!string.IsNullOrWhiteSpace(acct) && !string.IsNullOrWhiteSpace(custName) && charged > 0
                                                 && natFees > 0 && vat > 0)
                                {

                                    cmd = new SqlCommand("addDDASCJ_bt", conn);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                    cmd.Parameters.AddWithValue("@ACCT", acct);
                                    cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    cmd.Parameters.AddWithValue("@RptDate", rptDate);
                                    cmd.Parameters.AddWithValue("@Charged", charged);
                                    cmd.Parameters.AddWithValue("@VAT", vat);
                                    cmd.Parameters.AddWithValue("@National_Fees", natFees);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();

                                    cmd.Parameters.Clear();
                                    #region old code logic
                                    //charged = Math.Round((Convert.ToDouble((validDataFields[(validDataFields.Length - 12)]))), 2);
                                    //natFees = Math.Round((charged / VatValue), 2);
                                    //vat = Math.Round((charged - natFees), 2);
                                    //acct = validDataFields[0];

                                    //cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                    //cmd.Parameters.AddWithValue("@ACCT", validDataFields[0]);
                                    //cmd.Parameters.AddWithValue("@Customer_Name", (validDataFields[1] + validDataFields[2] + validDataFields[3]));
                                    //cmd.Parameters.AddWithValue("@RptDate", rptDate);
                                    //cmd.Parameters.AddWithValue("@Charged", charged);
                                    //cmd.Parameters.AddWithValue("@VAT", vat);
                                    //cmd.Parameters.AddWithValue("@National_Fees", natFees);

                                    #endregion
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                //readFile.Close();
                result = "success";
            }
            catch (Exception ex)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append(fileName.ToString() + "\n");
                    sb.Append(ex.Message + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error WriteDDASCJRecsToDb " + ex.Message;
            }
            finally
            {
                //cmd.Dispose();
                conn.Close();
            }

            return result;
        }
        private string WriteDDA132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            string result;

            //count the records for that date to ensure no double posting


            try
            {
                Thread.Sleep(1000);
                //readFile = new StreamReader(file);
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                    {
                        try
                        {

                            transCode = line.Substring(27, 4).Trim();
                            acct = line.Substring(10, 16).Trim();
                            CIF = line.Substring(0, 9).Trim();
                            proofSequence = line.Substring(46, 7).Trim();
                            checkNumber = line.Substring(55, 7).Trim();
                            source = line.Substring(32, 14).Trim();
                            transactionAmount = line.Substring(63, 15).Trim('*', ' ');
                            double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                            transAmt = Math.Round(parseAmount, 2);
                            natFees = Math.Round((transAmt / VatValue), 2);
                            vat = Math.Round((transAmt - natFees), 2);

                            if (!string.IsNullOrWhiteSpace(transCode)
                                 && !string.IsNullOrWhiteSpace(acct)
                                  && !string.IsNullOrWhiteSpace(CIF)
                                   && !string.IsNullOrWhiteSpace(proofSequence)
                                    && transAmt > 0
                                      && natFees > 0 && vat > 0)
                            {
                                switch (transCode)
                                {
                                    case "*145":

                                        cmd = new SqlCommand("addStopCharge_bt", conn);
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        break;
                                    case "*127":

                                        cmd = new SqlCommand("addSafeKeeping_bt", conn);
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        break;
                                    case "*164":

                                        cmd = new SqlCommand("addTransCharge_bt", conn);
                                        cmd.CommandType = CommandType.StoredProcedure;



                                        break;
                                    default:
                                        cmd = null;
                                        break;
                                }
                                if (cmd != null)
                                {


                                    cmd.Parameters.AddWithValue("@CIF", CIF);
                                    cmd.Parameters.AddWithValue("@Acct", acct);
                                    cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                    cmd.Parameters.AddWithValue("@Branch", branch);
                                    cmd.Parameters.AddWithValue("@transcode", transCode);
                                    cmd.Parameters.AddWithValue("@ProofSequence", source);
                                    cmd.Parameters.AddWithValue("@CheckNumber", checkNumber);
                                    cmd.Parameters.AddWithValue("@transAmt", transactionAmount);
                                    cmd.Parameters.AddWithValue("@NationalFees", natFees);
                                    cmd.Parameters.AddWithValue("@VAT", vat);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    cmd.Parameters.Clear();

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }

                //readFile.Close();
                result = "success";
            }
            catch (Exception ex)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append(file.ToString() + "\n");
                    sb.Append(ex.Message + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error WriteDDA132RecsToDb" + ex.Message;
            }
            finally
            {
                //cmd.Dispose();
                conn.Close();
            }
            return result;
        }
        private string WriteDDACURRecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            string currencyCode, result = "";
            double balance;
            if (branch == "0")
            {
                try
                {
                    Thread.Sleep(1000);

                    //readFile = new StreamReader(file);

                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                        {
                            try
                            {
                                acct = line.Substring(0, 9).Trim();
                                CIF = line.Substring(10, 9).Trim();
                                custName = line.Substring(20, 36).Trim();
                                transactionAmount = line.Substring(68, 15).Trim('-', ' '); //curremcy balance
                                double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                                balance = parseAmount;
                                currencyCode = line.Length >119 ?line.Substring(120, 3).Trim() : "";

                                if (!string.IsNullOrWhiteSpace(acct)
                                    && !string.IsNullOrWhiteSpace(CIF)
                                    && !string.IsNullOrWhiteSpace(custName)
                                    && balance > 0)
                                {

                                    cmd = new SqlCommand("addDDACUR_bt", conn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@Acct_Number", acct);
                                    cmd.Parameters.AddWithValue("@CIF", CIF);
                                    cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();

                                    conn.Close();
                                    cmd.Parameters.Clear();

                                    #region Old Code calculation
                                    //switch (acct)
                                    //{
                                    //    case "101":
                                    //        {
                                    //            custName = reportFields[2] + " " + reportFields[3] + " " + reportFields[4];
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();
                                    //            break;
                                    //        }
                                    //    case "103":
                                    //        {
                                    //            //custName = reportFields[2];
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "105":
                                    //        {
                                    //            custName = "WACHOVIA BANK, N.A. (CHEQUES)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "109":
                                    //        {
                                    //            custName = "WINDWARD ISLANDS BANK";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "113":
                                    //        {
                                    //            custName = "LLOYDS TSB BANK PLC (GBP)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "114":
                                    //        {
                                    //            custName = "BARBADOS NATIONAL BANK";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "118":
                                    //        {
                                    //            custName = "REPUBLIC BANK (GUYANA) LTD";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "124":
                                    //        {
                                    //            custName = "ANTIGUA COMMERCIAL BANK";
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]));
                                    //            currencyCode = "XCD";

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();
                                    //            break;
                                    //        }
                                    //    case "125":
                                    //        {
                                    //            custName = "NATIONAL BANK OF DOMINICA";
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]));
                                    //            currencyCode = "XCD";

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "129":
                                    //        {
                                    //            custName = "WACHOVIA BANK, N.A. (WIRES)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();

                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "164":
                                    //        {
                                    //            custName = "BANK OF AMERICA";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "170":
                                    //        {
                                    //            custName = "LLOYDS TSB BANK PLC (EUR)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "182":
                                    //        {
                                    //            custName = "BARCLAYS BANK PLC (USD)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "183":
                                    //        {
                                    //            custName = "BARCLAYS BANK PLC (GBP)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "184":
                                    //        {
                                    //            custName = "BARCLAYS BANK PLC (EUR)";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "202":
                                    //        {
                                    //            custName = "NATIONAL BANK OF CANADA";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "206":
                                    //        {
                                    //            custName = "FIFTH THIRD BANK";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "215":
                                    //        {
                                    //            custName = "NATIONAL BANK OF CANADA";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "216":
                                    //        {
                                    //            custName = "ROYAL BANK OF CANADA";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "217":
                                    //        {
                                    //            custName = "ROYAL BANK OF CANADA";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "223":
                                    //        {
                                    //            custName = "UNITED INTERNATIONAL BANK";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //    case "225":
                                    //        {
                                    //            custName = "COMMERZ BANK USD";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();
                                    //            break;
                                    //        }
                                    //    case "226":
                                    //        {
                                    //            custName = "COMMERZ BANK EURO";
                                    //            currencyCode = reportFields[(reportFields.Length - 1)];
                                    //            balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                    //            cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                    //            cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    //            cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                    //            cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                    //            cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                    //            cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                    //            conn.Open();
                                    //            cmd.ExecuteNonQuery();
                                    //            conn.Close();
                                    //            cmd.Parameters.Clear();

                                    //            break;
                                    //        }
                                    //}

                                    #endregion
                                }
                            }
                            catch (Exception ex) { }
                        }
                    }
                    //readFile.Close();
                    result = "success";
                }
                catch (Exception ex)
                {
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append(file.ToString() + "\n");
                        sb.Append(ex.Message + "\n");
                        File.AppendAllText(logfilepath, sb.ToString());
                    }
                    result = "Error WriteDDACURRecsToDb: " + ex.Message;
                    //mail.Sendmail(result, "Error in VatFilseService");
                }
                finally
                {
                    //cmd.Dispose();
                    conn.Close();
                }
            }


            return result;
        }

        //SAV folder Complete Calculation by New Approch
        private string WriteSAV132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            string result = "";
            try
            {
                Thread.Sleep(1000);
                //readFile = new StreamReader(file);

                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                    {
                        try
                        {

                            transCode = line.Substring(27, 4).Trim();
                            acct = line.Substring(0, 16).Trim();
                            CIF = line.Substring(17, 9).Trim();
                            proofSequence = line.Substring(65, 7).Trim();
                            source = line.Substring(32, 14).Trim();
                            transactionAmount = line.Substring(52, 13).Trim('*', ' ');
                            double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                            transAmt = Math.Round(parseAmount, 2);
                            natFees = Math.Round((transAmt / VatValue), 2);
                            vat = Math.Round((transAmt - natFees), 2);

                            if (!string.IsNullOrWhiteSpace(transCode)
                                && !string.IsNullOrWhiteSpace(acct)
                                && !string.IsNullOrWhiteSpace(CIF)
                                && !string.IsNullOrWhiteSpace(proofSequence)
                                && !string.IsNullOrWhiteSpace(source)
                                && transCode == "*226"
                                && transAmt > 0
                                && natFees > 0 && vat > 0)
                            {

                                cmd = new SqlCommand("addSafeKeeping_bt", conn);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@Acct", acct);
                                cmd.Parameters.AddWithValue("@CIF", CIF);
                                cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                cmd.Parameters.AddWithValue("@Branch", branch);
                                cmd.Parameters.AddWithValue("@transcode", transCode);
                                cmd.Parameters.AddWithValue("@ProofSequence", proofSequence);
                                cmd.Parameters.AddWithValue("@CheckNumber", "N/A");
                                cmd.Parameters.AddWithValue("@transAmt", transAmt);
                                cmd.Parameters.AddWithValue("@NationalFees", natFees);
                                cmd.Parameters.AddWithValue("@VAT", vat);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                cmd.Parameters.Clear();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                //readFile.Close();
                result = "success";
            }
            catch (Exception exc)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append(file.ToString() + "\n");
                    sb.Append(exc.Message + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error WriteSAV132RecsToDb " + exc.Message;
            }
            finally
            {
                // cmd.Dispose();
                conn.Close();
            }
            return result;
        }

        //LON folder Complete Calculation by New Approch
        private string WriteLON132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {

            string result = "";


            try
            {
                Thread.Sleep(1000);
                //readFile = new StreamReader(file);

                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            transCode = line.Substring(64, 4).Trim();
                            acct = line.Substring(0, 16).Trim();
                            custName = line.Substring(17, 23).Trim();
                            transactionAmount = line.Substring(98, 8).Trim('*', ' ');
                            double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                            transAmt = Math.Round(parseAmount, 2);
                            natFees = Math.Round((transAmt / VatValue), 2);
                            vat = Math.Round((transAmt - natFees), 2);

                            if (!string.IsNullOrWhiteSpace(transCode)
                               && !string.IsNullOrWhiteSpace(acct)
                               && !string.IsNullOrWhiteSpace(CIF)
                               && !string.IsNullOrWhiteSpace(proofSequence)
                               && !string.IsNullOrWhiteSpace(source)
                               && transCode == "416"
                               && transAmt > 0
                               && natFees > 0 && vat > 0)
                            {
                                cmd = new SqlCommand("addLoanCharges_bt", conn);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@acct", acct);
                                cmd.Parameters.AddWithValue("@Name", custName);
                                cmd.Parameters.AddWithValue("@Branch", branch);
                                cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                cmd.Parameters.AddWithValue("@Vat", vat);
                                cmd.Parameters.AddWithValue("@nationalfees", natFees);
                                cmd.Parameters.AddWithValue("@totalfees", transAmt);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                cmd.Parameters.Clear();
                            }
                        }
                        catch (Exception ex) { }
                    }

                }
                //readFile.Close();
                result = "";
            }
            catch (Exception exp)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append(file.ToString() + "\n");
                    sb.Append(exp.Message + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error WriteLON132RecsToDb " + exp.Message;
            }
            finally
            {
                // cmd.Dispose();
                conn.Close();
            }

            return result;
        }

        #region Old LON Code
        //protected string WriteLON132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        //{


        //    string result = "";
        //    cmd = new SqlCommand("addLoanCharges_bt", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    try
        //    {
        //        Thread.Sleep(1000);
        //        readFile = new StreamReader(file);

        //        while ((line = readFile.ReadLine()) != null)
        //        {
        //            if (!arr.Any(line.Contains))
        //            {

        //                    reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //                // get rid of the * by converting to List<>, removing then sending back to array
        //                List<String> fields = new List<String>(reportFields);
        //                fields.Remove("*");
        //                reportFields = fields.ToArray();

        //                if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("PROOF")) & !(reportFields.Contains("ACCOUNT")) & !(reportFields.Contains(">>TOTAL")))
        //                {
        //                    if (reportFields.Length >= 7)
        //                    {
        //                        foreach (string s in reportFields)
        //                        {
        //                            if (s == "416")
        //                            {
        //                                acct = reportFields[0];
        //                                if ((reportFields[3] == "S") | (reportFields[3] == "EH") | (reportFields[3] == "LR") | (reportFields[3] == "CP") | (reportFields[3] == "JEF") | (reportFields[3] == "D") | (reportFields[3].Contains("/")))
        //                                    custName = reportFields[1] + " " + reportFields[2];
        //                                else
        //                                    custName = reportFields[1] + " " + reportFields[2] + " " + reportFields[3];
        //                            }
        //                            if (s == "423") // get the index and check after for 416 / 421; if present don't use this record
        //                            {
        //                                int indx = Array.FindIndex(reportFields, item => item == s);
        //                                if ((reportFields[indx + 1] != "416") && (reportFields[indx + 1] != "421"))
        //                                {
        //                                    // for the current record if customer name is blank keep the custName obtained above if the account numbers are equal

        //                                    cmd.Parameters.Clear();
        //                                    if ((reportFields[1] == "S") | (reportFields[1] == "EH") | (reportFields[1] == "LR") | (reportFields[1] == "CP") | (reportFields[1] == "JEF") | (reportFields[1] == "D") | (reportFields[1].Contains("/")))
        //                                    {
        //                                        if (reportFields[0] == acct)
        //                                        {
        //                                            // the current customer name is blank
        //                                            cmd.Parameters.AddWithValue("@acct", reportFields[0]);
        //                                            cmd.Parameters.AddWithValue("@Name", custName);
        //                                        }
        //                                    }
        //                                    else  // current record customer name not blank get the current name, it could be 2 or 3 fields
        //                                    {
        //                                        if ((reportFields[3] == "S") | (reportFields[3] == "EH") | (reportFields[3] == "LR") | (reportFields[3] == "CP") | (reportFields[3] == "JEF") | (reportFields[3] == "D") | (reportFields[3].Contains("/")))
        //                                            custName = reportFields[1] + " " + reportFields[2];
        //                                        else
        //                                            custName = reportFields[1] + " " + reportFields[2] + " " + reportFields[3];

        //                                        cmd.Parameters.AddWithValue("@acct", reportFields[0]);
        //                                        cmd.Parameters.AddWithValue("@Name", custName);
        //                                    }

        //                                    acct = line.Substring(0, 16).Trim();
        //                                    custName = line.Substring(17, 23).Trim();
        //                                    transactionAmount = line.Substring(52, 13).Trim('*', ' ');
        //                                    double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
        //                                    transAmt = Math.Round(parseAmount, 2);
        //                                    natFees = Math.Round((transAmt / VatValue), 2);
        //                                    vat = Math.Round((transAmt - natFees), 2);

        //                                    transAmt = Math.Round((Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]))), 2);
        //                                    natFees = Math.Round((transAmt / VatValue), 2);
        //                                    vat = Math.Round((transAmt - natFees), 2);
        //                                    if (!string.IsNullOrWhiteSpace(transCode)
        //                                       && !string.IsNullOrWhiteSpace(acct)
        //                                       && !string.IsNullOrWhiteSpace(CIF)
        //                                       && !string.IsNullOrWhiteSpace(proofSequence)
        //                                       && !string.IsNullOrWhiteSpace(source)
        //                                       && transCode == "*226"
        //                                       && transAmt > 0
        //                                       && natFees > 0 && vat > 0)
        //                                    {
        //                                        cmd.Parameters.AddWithValue("@Branch", branch);
        //                                        cmd.Parameters.AddWithValue("@dateactive", rptDate);
        //                                        cmd.Parameters.AddWithValue("@Vat", vat);
        //                                        cmd.Parameters.AddWithValue("@nationalfees", natFees);
        //                                        cmd.Parameters.AddWithValue("@totalfees", transAmt);

        //                                        conn.Open();
        //                                        cmd.ExecuteNonQuery();
        //                                        conn.Close();
        //                                        cmd.Parameters.Clear();
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }

        //        }
        //        readFile.Close();
        //        result = "";
        //    }
        //    catch (Exception exp)
        //    {
        //        if (printlog > 0)
        //        {
        //            sb.Clear();
        //            sb.Append(file.ToString() + "\n");
        //            sb.Append(exp.Message + "\n");
        //            File.AppendAllText(logfilepath, sb.ToString());
        //        }
        //        result = "Error WriteLON132RecsToDb " + exp.Message;
        //    }
        //    finally
        //    {
        //        // cmd.Dispose();
        //        conn.Close();
        //    }

        //    return result;
        //}

        //MISC folder
        #endregion

        //SUS folder
        private string WriteSUS702RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            string dateActive = "", result = "";
            DateTime dateactive = DateTime.MinValue;

            cmd = new SqlCommand("addStadingOrders_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Thread.Sleep(1000);

                //readFile = new StreamReader(file);

                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    if (!arr.Any(line.Contains) && !string.IsNullOrEmpty(line))
                    {
                        try
                        {
                            double SUSTC = 0, Offset_Act_Number = 0, Total_Transaction_Amt =0;
                            string TRCD = "N/A",  Suspence_Descr = "N/A";
                            double.TryParse(line.Substring(70, 10).Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out Total_Transaction_Amt);

                            if(Total_Transaction_Amt > 0)
                            {
                                proofSequence = line.Substring(0, 8).Trim();
                                acct = line.Substring(16, 10).Trim();
                                TRCD = line.Substring(28, 4).Trim();
                                custName = line.Substring(36, 31).Trim();
                                transactionAmount = line.Substring(143, 10).Trim('*', ' ');
                                double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
                                transAmt = Math.Round(parseAmount, 2);
                                dateActive = line.Substring(83, 8).Trim();
                                Suspence_Descr = line.Substring(93, 25).Trim();
                                double.TryParse(line.Substring(120, 3).Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out SUSTC);
                                double.TryParse(line.Substring(128, 12).Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out Offset_Act_Number);
                                natFees = Math.Round((transAmt / VatValue), 2);
                                vat = Math.Round((transAmt - natFees), 2);

                            }
                            
                            if (SUSTC >0 && Offset_Act_Number > 0 && transAmt > 0)
                            {

                                cmd.Parameters.AddWithValue("@Sequence_Number", proofSequence);
                                cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                cmd.Parameters.AddWithValue("@Acct", acct);
                                cmd.Parameters.AddWithValue("@TR_CD", TRCD);
                                cmd.Parameters.AddWithValue("@Name", custName);
                                cmd.Parameters.AddWithValue("@Total_Transaction_Amt", Total_Transaction_Amt);
                                cmd.Parameters.AddWithValue("@Date_Active", dateActive);
                                cmd.Parameters.AddWithValue("@Suspence_Descr", Suspence_Descr);
                                cmd.Parameters.AddWithValue("@SUS_TC", SUSTC);
                                cmd.Parameters.AddWithValue("@Offset_Act_Number", Offset_Act_Number);
                                cmd.Parameters.AddWithValue("@Transaction_Amt", transAmt);
                                cmd.Parameters.AddWithValue("@National_Fees", natFees);
                                cmd.Parameters.AddWithValue("@Total_Fees", natFees);
                                cmd.Parameters.AddWithValue("@VAT", vat);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                cmd.Parameters.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                //readFile.Close();
                result = "success";
            }
            catch (Exception ex)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append(file.ToString() + "\n");
                    sb.Append(ex.Message + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error WriteSUS702: " + ex.Message;
                //mail.Sendmail(result, "Error in VatFilesService");
            }
            finally
            {
                //cmd.Dispose();
                conn.Close();
            }
            return result;
        }

        #region Old SUS code

        //private string WriteSUS702RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        //{
        //    int indexOfDateActive = 0, indexesForNames = 0;
        //    string seqNum = "", custName = "", result = "";
        //    DateTime dateactive = DateTime.MinValue;

        //    cmd = new SqlCommand("addStadingOrders_bt", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        Thread.Sleep(1000);

        //        readFile = new StreamReader(file);

        //        while ((line = readFile.ReadLine()) != null)
        //        {
        //            reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //            if ((reportFields.Contains("**")) && (reportFields.Contains("TOTALS")))
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                if (reportFields.Length > 1)  //eliminate the "===" in the report
        //                {
        //                    if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("SEQUENCE")) & !(reportFields.Contains("NUMBER")))
        //                    {
        //                        if (reportFields[(reportFields.Length - 1)] != ".00")
        //                        {
        //                            if (reportFields.Length > 3)
        //                            {
        //                                seqNum = reportFields[0];
        //                                acct = reportFields[1];

        //                                for (int i = 0; i < reportFields.Length; i++)
        //                                {
        //                                    if (reportFields[i].Contains("/") & reportFields[i].Length >= 7)
        //                                    {
        //                                        if (((reportFields[i].Substring(1, 1).Equals("/")) & (reportFields[i].Substring(4, 1).Equals("/"))) |
        //                                            ((reportFields[i].Substring(2, 1).Equals("/")) & (reportFields[i].Substring(5, 1).Equals("/"))))
        //                                        {
        //                                            indexOfDateActive = i;
        //                                            break;
        //                                        }
        //                                    }
        //                                }

        //                                indexesForNames = (indexOfDateActive - 1) - 3;
        //                                dateactive = Convert.ToDateTime(reportFields[indexOfDateActive]);

        //                                switch (indexesForNames)
        //                                {
        //                                    case 1:
        //                                        {
        //                                            custName = reportFields[3];
        //                                            break;
        //                                        }
        //                                    case 2:
        //                                        {
        //                                            custName = reportFields[3] + reportFields[4];
        //                                            break;
        //                                        }
        //                                    case 3:
        //                                        {
        //                                            custName = reportFields[3] + reportFields[4] + reportFields[5];
        //                                            break;
        //                                        }
        //                                    case 4:
        //                                        {
        //                                            custName = reportFields[3] + reportFields[4] + reportFields[5] + reportFields[6];
        //                                            break;
        //                                        }
        //                                    case 5:
        //                                        {
        //                                            custName = reportFields[3] + reportFields[4] + reportFields[5] + reportFields[6] + reportFields[7];
        //                                            break;
        //                                        }
        //                                }
        //                                try
        //                                {
        //                                    string TRCD = "", SUSTC = "", dateActive = "", Suspence_Descr = "", Offset_Act_Number = "";
        //                                    seqNum = line.Substring(0, 8).Trim();
        //                                    acct = line.Substring(16, 10).Trim();
        //                                    TRCD = line.Substring(28, 4).Trim();
        //                                    custName = line.Substring(36, 31).Trim();
        //                                    transactionAmount = line.Substring(143, 10).Trim('*', ' ');
        //                                    double.TryParse(transactionAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out double parseAmount);
        //                                    transAmt = Math.Round(parseAmount, 2);
        //                                    dateActive = line.Substring(83, 8).Trim();
        //                                    Suspence_Descr = line.Substring(93, 25).Trim();
        //                                    SUSTC = line.Substring(120, 3).Trim();
        //                                    Offset_Act_Number = line.Substring(128, 12).Trim();
        //                                    natFees = Math.Round((transAmt / VatValue), 2);
        //                                    vat = Math.Round((transAmt - natFees), 2);

        //                                    if (!string.IsNullOrWhiteSpace(seqNum) && !string.IsNullOrWhiteSpace(acct) && !string.IsNullOrWhiteSpace(TRCD)
        //                                         && !string.IsNullOrWhiteSpace(custName) && !string.IsNullOrWhiteSpace(transactionAmount) && !string.IsNullOrWhiteSpace(dateActive))
        //                                    {
        //                                        transAmt = Convert.ToDouble(reportFields[(indexOfDateActive - 1)]);
        //                                        vat = natFees = 0;

        //                                        cmd.Parameters.AddWithValue("@Sequence_Number", seqNum);
        //                                        cmd.Parameters.AddWithValue("@Branch_Number", branch);
        //                                        cmd.Parameters.AddWithValue("@Acct", acct);
        //                                        cmd.Parameters.AddWithValue("@TR_CD", TRCD);
        //                                        cmd.Parameters.AddWithValue("@Name", custName);
        //                                        cmd.Parameters.AddWithValue("@Total_Transaction_Amt", transAmt);
        //                                        cmd.Parameters.AddWithValue("@Date_Active", dateActive);
        //                                        cmd.Parameters.AddWithValue("@Suspence_Descr", Suspence_Descr);
        //                                        cmd.Parameters.AddWithValue("@SUS_TC", SUSTC);
        //                                        cmd.Parameters.AddWithValue("@Offset_Act_Number", Offset_Act_Number);
        //                                        cmd.Parameters.AddWithValue("@Transaction_Amt", transAmt);
        //                                        cmd.Parameters.AddWithValue("@National_Fees", natFees);
        //                                        cmd.Parameters.AddWithValue("@Total_Fees", natFees);
        //                                        cmd.Parameters.AddWithValue("@VAT", vat);

        //                                        conn.Open();
        //                                        cmd.ExecuteNonQuery();
        //                                        conn.Close();
        //                                        cmd.Parameters.Clear();
        //                                    }
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                }
        //                            }
        //                            else
        //                            {
        //                                transAmt = Math.Round((Convert.ToDouble(ConvertNegativeBalance(reportFields[2]))), 2);
        //                                natFees = Math.Round((transAmt / VatValue), 2);
        //                                vat = Math.Round((transAmt - natFees), 2);

        //                                cmd.Parameters.AddWithValue("@Sequence_Number", seqNum);
        //                                cmd.Parameters.AddWithValue("@Branch_Number", branch);
        //                                cmd.Parameters.AddWithValue("@Acct", acct);
        //                                cmd.Parameters.AddWithValue("@TR_CD", "N/A");
        //                                cmd.Parameters.AddWithValue("@Name", custName);
        //                                cmd.Parameters.AddWithValue("@Total_Transaction_Amt", 0.0);
        //                                cmd.Parameters.AddWithValue("@Date_Active", dateactive);
        //                                cmd.Parameters.AddWithValue("@Suspence_Descr", "N/A");
        //                                cmd.Parameters.AddWithValue("@SUS_TC", reportFields[0]);
        //                                cmd.Parameters.AddWithValue("@Offset_Act_Number", reportFields[1]);
        //                                cmd.Parameters.AddWithValue("@Transaction_Amt", 0.0);
        //                                cmd.Parameters.AddWithValue("@National_Fees", natFees);
        //                                cmd.Parameters.AddWithValue("@Total_Fees", transAmt);
        //                                cmd.Parameters.AddWithValue("@VAT", vat);

        //                                conn.Open();
        //                                try
        //                                {
        //                                    cmd.ExecuteNonQuery();
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                    sb.Clear();
        //                                    sb.Append("Error in file " + file + "\n");
        //                                    sb.Append("======================================================== " + file + "\n");
        //                                    sb.Append("Sequence Number is" + seqNum + "\n");
        //                                    sb.Append("acct is" + acct + "\n");
        //                                    sb.Append("Name is" + custName + "\n");
        //                                    sb.Append("Date Active is" + dateactive + "\n");
        //                                    sb.Append("SUS T/C is" + reportFields[0] + "\n");
        //                                    sb.Append("Offset Act Number is" + reportFields[1] + "\n");
        //                                    sb.Append("National Fees is" + natFees + "\n");
        //                                    sb.Append("Total Fees" + transAmt + "\n");
        //                                    sb.Append("VAT" + vat + "\n");
        //                                    sb.Append(ex.Message + "\n");
        //                                    sb.Append("======================================================== " + file + "\n");
        //                                    sb.Append("\n");
        //                                    File.AppendAllText(logfilepath, sb.ToString());
        //                                }
        //                                conn.Close();
        //                                cmd.Parameters.Clear();
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        readFile.Close();
        //        result = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        if (printlog > 0)
        //        {
        //            sb.Clear();
        //            sb.Append(file.ToString() + "\n");
        //            sb.Append(ex.Message + "\n");
        //            File.AppendAllText(logfilepath, sb.ToString());
        //        }
        //        result = "Error WriteSUS702: " + ex.Message;
        //        //mail.Sendmail(result, "Error in VatFilesService");
        //    }
        //    finally
        //    {
        //        //cmd.Dispose();
        //        conn.Close();
        //    }
        //    return result;
        //}

        #endregion


        #endregion


        protected string ConvertNegativeBalance(string bal)
        {
            string convBal;
            int indx;
            if (bal.Contains("-"))
            {
                indx = bal.IndexOf("-");
                convBal = bal.Remove(indx, 1);
                bal = "-" + convBal;
            }
            return bal;
        }
    }
}
