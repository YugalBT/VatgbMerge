using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VATCustomServices.Helper;



namespace VATCustomServices
{
    public class VATServices
    {
        string line, acct, branch, custName;
        DateTime rptDate, lastAcessTime = DateTime.MinValue;
        string[] reportFields;
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


        public async Task<IGeneralResult<string>> ProcessNewFiles(int mnth,string vatConnectionString, string connectionstring, string filePath, int printLog, string logpath, int foldername)
        {
            VatValue = Common.GetVatApplyValue(vatConnectionString);
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

            string path = filePath + extension + @"\";
            if (Directory.Exists(path))
            {
                string dirMth, msg;
                string result = "";
                conn = new SqlConnection(connectionstring);
                String[] allFiles = null;
                try
                {
                    allFiles = Directory.GetFiles(filePath + extension + @"\");
                }
                catch (Exception ex)
                {
                    res.Successful = false;
                    res.Message = ex.Message;
                }
                // get the report date
                try
                {
                    foreach (string f in allFiles)
                    {
                        if (!f.Contains("_08"))
                        {
                            //get report date

                            FileInfo fi = new FileInfo(f);
                            string extensionName = fi.Extension.Remove(0, 1);

                            string year = extensionName.Substring(0, 4);

                            string extensionaftergetYear = extensionName.Remove(0, 4);

                            string month = extensionaftergetYear.Substring(0, 2);

                            string extensionaftergetmonth = extensionName.Remove(0, 6);

                            string day = extensionaftergetmonth.Substring(0, 2);

                            if (Convert.ToInt32(year) >= 2019)
                            {
                                rptDate = Convert.ToDateTime(((File.GetLastWriteTime(f)).ToShortDateString()));

                                rptDate = Convert.ToDateTime(month + "/" + day + "/" + year);


                                branch = GetBranch(f);


                                if (foldername == 1)
                                {
                                    if (f.ToLower().Contains("dda132"))
                                    {
                                        result = WriteDDA132RecsToDb(f, rptDate, branch, conn);
                                    }
                                    else if (f.ToLower().Contains("ddascj"))

                                    {
                                        result = WriteDDASCJRecsToDb(f, rptDate, branch, conn);
                                    }
                                    else if (f.ToLower().Contains("ddacur_00"))
                                    {
                                        result = WriteDDACURRecsToDb(f, rptDate, branch, conn);
                                    }
                                }

                                if (foldername == 2)
                                {
                                    if (f.ToLower().Contains("lon132"))
                                    {
                                        result = WriteLON132RecsToDb(f, rptDate, branch, conn);
                                    }
                                }

                                if (foldername == 3)
                                {
                                    if (f.ToLower().Contains("sav132"))
                                    {
                                        result = WriteSAV132RecsToDb(f, rptDate, branch, conn);
                                    }
                                }
                                if (foldername == 4)
                                {

                                    if (f.ToLower().Contains("sus702"))
                                    {
                                        result = WriteSUS702RecsToDb(f, rptDate, branch, conn);
                                    }
                                }

                                if (result == "success")
                                {
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

        private string WriteSUS702RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            int indexOfDateActive = 0, indexesForNames = 0;
            string seqNum = "", custName = "", result = "";
            DateTime dateactive = DateTime.MinValue;

            cmd = new SqlCommand("addStadingOrders_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Thread.Sleep(1000);

                readFile = new StreamReader(file);

                while ((line = readFile.ReadLine()) != null)
                {
                    reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if ((reportFields.Contains("**")) && (reportFields.Contains("TOTALS")))
                    {
                        break;
                    }
                    else
                    {
                        if (reportFields.Length > 1)  //eliminate the "===" in the report
                        {
                            if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("SEQUENCE")) & !(reportFields.Contains("NUMBER")))
                            {
                                if (reportFields[(reportFields.Length - 1)] != ".00")
                                {
                                    if (reportFields.Length > 3)
                                    {
                                        seqNum = reportFields[0];
                                        acct = reportFields[1];

                                        for (int i = 0; i < reportFields.Length; i++)
                                        {
                                            if (reportFields[i].Contains("/") & reportFields[i].Length >= 7)
                                            {
                                                if (((reportFields[i].Substring(1, 1).Equals("/")) & (reportFields[i].Substring(4, 1).Equals("/"))) |
                                                    ((reportFields[i].Substring(2, 1).Equals("/")) & (reportFields[i].Substring(5, 1).Equals("/"))))
                                                {
                                                    indexOfDateActive = i;
                                                    break;
                                                }
                                            }
                                        }

                                        indexesForNames = (indexOfDateActive - 1) - 3;
                                        dateactive = Convert.ToDateTime(reportFields[indexOfDateActive]);

                                        switch (indexesForNames)
                                        {
                                            case 1:
                                                {
                                                    custName = reportFields[3];
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    custName = reportFields[3] + reportFields[4];
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    custName = reportFields[3] + reportFields[4] + reportFields[5];
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    custName = reportFields[3] + reportFields[4] + reportFields[5] + reportFields[6];
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    custName = reportFields[3] + reportFields[4] + reportFields[5] + reportFields[6] + reportFields[7];
                                                    break;
                                                }
                                        }
                                        try
                                        {
                                            transAmt = Convert.ToDouble(reportFields[(indexOfDateActive - 1)]);
                                            vat = natFees = 0;

                                            cmd.Parameters.AddWithValue("@Sequence_Number", seqNum);
                                            cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                            cmd.Parameters.AddWithValue("@Acct", acct);
                                            cmd.Parameters.AddWithValue("@TR_CD", reportFields[2]);
                                            cmd.Parameters.AddWithValue("@Name", custName);
                                            cmd.Parameters.AddWithValue("@Total_Transaction_Amt", transAmt);
                                            cmd.Parameters.AddWithValue("@Date_Active", reportFields[indexOfDateActive]);
                                            cmd.Parameters.AddWithValue("@Suspence_Descr", "N/A");
                                            cmd.Parameters.AddWithValue("@SUS_TC", reportFields[(reportFields.Length - 3)]);
                                            cmd.Parameters.AddWithValue("@Offset_Act_Number", reportFields[(reportFields.Length - 2)]);
                                            cmd.Parameters.AddWithValue("@Transaction_Amt", Convert.ToDouble(reportFields[(reportFields.Length - 1)]));
                                            cmd.Parameters.AddWithValue("@National_Fees", natFees);
                                            cmd.Parameters.AddWithValue("@Total_Fees", natFees);
                                            cmd.Parameters.AddWithValue("@VAT", vat);

                                            conn.Open();

                                            cmd.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            if (printlog > 0)
                                            {
                                                sb.Clear();
                                                sb.Append("Error in file " +file+ "\n");
                                                sb.Append("======================================================== " +file+ "\n");
                                                sb.Append("Sequence Number is" +seqNum+ "\n");
                                                sb.Append("acct is" + acct + "\n");
                                                sb.Append("Tr/CD is" + reportFields[2] + "\n");
                                                sb.Append("Name is" + custName + "\n");
                                                sb.Append("Transaction Amount is" + transAmt + "\n");
                                                sb.Append("Date Active is" + reportFields[indexOfDateActive] + "\n");
                                                sb.Append("SUS T/C is" + reportFields[(reportFields.Length - 3)] + "\n");
                                                sb.Append("Offset Act Number is" + reportFields[(reportFields.Length - 2)] + "\n");
                                                sb.Append("Transaction Amount is" + Convert.ToDouble(reportFields[(reportFields.Length - 1)]) + "\n");
                                                sb.Append(ex.Message + "\n");
                                                sb.Append("======================================================== " + file + "\n");
                                                sb.Append("\n");
                                                File.AppendAllText(logfilepath, sb.ToString());
                                            }
                                        }
                                        conn.Close();
                                        cmd.Parameters.Clear();
                                    }
                                    else
                                    {
                                        transAmt = Math.Round((Convert.ToDouble(ConvertNegativeBalance(reportFields[2]))), 2);
                                        natFees = Math.Round((transAmt / VatValue), 2);
                                        vat = Math.Round((transAmt - natFees), 2);

                                        cmd.Parameters.AddWithValue("@Sequence_Number", seqNum);
                                        cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                        cmd.Parameters.AddWithValue("@Acct", acct);
                                        cmd.Parameters.AddWithValue("@TR_CD", "N/A");
                                        cmd.Parameters.AddWithValue("@Name", custName);
                                        cmd.Parameters.AddWithValue("@Total_Transaction_Amt", 0.0);
                                        cmd.Parameters.AddWithValue("@Date_Active", dateactive);
                                        cmd.Parameters.AddWithValue("@Suspence_Descr", "N/A");
                                        cmd.Parameters.AddWithValue("@SUS_TC", reportFields[0]);
                                        cmd.Parameters.AddWithValue("@Offset_Act_Number", reportFields[1]);
                                        cmd.Parameters.AddWithValue("@Transaction_Amt", 0.0);
                                        cmd.Parameters.AddWithValue("@National_Fees", natFees);
                                        cmd.Parameters.AddWithValue("@Total_Fees", transAmt);
                                        cmd.Parameters.AddWithValue("@VAT", vat);

                                        conn.Open();
                                        try
                                        {
                                            cmd.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            sb.Clear();
                                            sb.Append("Error in file " + file + "\n");
                                            sb.Append("======================================================== " + file + "\n");
                                            sb.Append("Sequence Number is" + seqNum + "\n");
                                            sb.Append("acct is" + acct + "\n");
                                            sb.Append("Name is" + custName + "\n");
                                            sb.Append("Date Active is" + dateactive + "\n");
                                            sb.Append("SUS T/C is" + reportFields[0] + "\n");
                                            sb.Append("Offset Act Number is" + reportFields[1] + "\n");
                                            sb.Append("National Fees is" + natFees + "\n");
                                            sb.Append("Total Fees" + transAmt + "\n");
                                            sb.Append("VAT" + vat + "\n");
                                            sb.Append(ex.Message + "\n");
                                            sb.Append("======================================================== " + file + "\n");
                                            sb.Append("\n");
                                            File.AppendAllText(logfilepath, sb.ToString());
                                        }
                                        conn.Close();
                                        cmd.Parameters.Clear();
                                    }
                                }
                            }
                        }
                    }
                }
                readFile.Close();
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

        protected string WriteDDACURRecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {

            custName = "";
            string currencyCode, result = "";
            double balance;

            cmd = new SqlCommand("addDDACUR_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (branch == "0")
            {
                try
                {
                    Thread.Sleep(1000);

                    readFile = new StreamReader(file);

                    while ((line = readFile.ReadLine()) != null)
                    {
                        reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if ((reportFields.Contains("DDA")) && (reportFields.Contains("TOTALS")))
                        {
                            break;
                        }
                        else
                        {
                            if (reportFields.Length > 1)  //eliminate the "===" in the report
                            {
                                //eliminate the column headers in the report
                                if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("ACCOUNT")) & !(reportFields.Contains("NUMBER")))
                                {
                                    switch (reportFields[0])
                                    {
                                        case "101":
                                            {
                                                custName = reportFields[2] + " " + reportFields[3] + " " + reportFields[4];
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();
                                                break;
                                            }
                                        case "103":
                                            {
                                                custName = reportFields[2];
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "105":
                                            {
                                                custName = "WACHOVIA BANK, N.A. (CHEQUES)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "109":
                                            {
                                                custName = "WINDWARD ISLANDS BANK";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "113":
                                            {
                                                custName = "LLOYDS TSB BANK PLC (GBP)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "114":
                                            {
                                                custName = "BARBADOS NATIONAL BANK";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "118":
                                            {
                                                custName = "REPUBLIC BANK (GUYANA) LTD";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "124":
                                            {
                                                custName = "ANTIGUA COMMERCIAL BANK";
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]));
                                                currencyCode = "XCD";

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();
                                                break;
                                            }
                                        case "125":
                                            {
                                                custName = "NATIONAL BANK OF DOMINICA";
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]));
                                                currencyCode = "XCD";

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "129":
                                            {
                                                custName = "WACHOVIA BANK, N.A. (WIRES)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();

                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "164":
                                            {
                                                custName = "BANK OF AMERICA";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "170":
                                            {
                                                custName = "LLOYDS TSB BANK PLC (EUR)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "182":
                                            {
                                                custName = "BARCLAYS BANK PLC (USD)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "183":
                                            {
                                                custName = "BARCLAYS BANK PLC (GBP)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "184":
                                            {
                                                custName = "BARCLAYS BANK PLC (EUR)";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "202":
                                            {
                                                custName = "NATIONAL BANK OF CANADA";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "206":
                                            {
                                                custName = "FIFTH THIRD BANK";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "215":
                                            {
                                                custName = "NATIONAL BANK OF CANADA";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "216":
                                            {
                                                custName = "ROYAL BANK OF CANADA";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "217":
                                            {
                                                custName = "ROYAL BANK OF CANADA";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "223":
                                            {
                                                custName = "UNITED INTERNATIONAL BANK";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                        case "225":
                                            {
                                                custName = "COMMERZ BANK USD";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();
                                                break;
                                            }
                                        case "226":
                                            {
                                                custName = "COMMERZ BANK EURO";
                                                currencyCode = reportFields[(reportFields.Length - 1)];
                                                balance = Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 5)]));

                                                cmd.Parameters.AddWithValue("@Acct_Number", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                                cmd.Parameters.AddWithValue("@Customer_Name", custName);
                                                cmd.Parameters.AddWithValue("@Currency_Balance", balance);
                                                cmd.Parameters.AddWithValue("@Currency_Code", currencyCode);
                                                cmd.Parameters.AddWithValue("@Rpt_Date", rptDate);

                                                conn.Open();
                                                cmd.ExecuteNonQuery();
                                                conn.Close();
                                                cmd.Parameters.Clear();

                                                break;
                                            }
                                    }
                                }
                            }
                        }
                    }
                    readFile.Close();
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

        protected string WriteLON132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {


            string result = "";
            cmd = new SqlCommand("addLoanCharges_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                Thread.Sleep(1000);
                readFile = new StreamReader(file);

                while ((line = readFile.ReadLine()) != null)
                {
                    if (line.Contains("=") && line.Contains("SYSTEM") && line.Contains("GENERATED"))
                    {
                        break;
                    }
                    else
                    {
                        reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // get rid of the * by converting to List<>, removing then sending back to array
                        List<String> fields = new List<String>(reportFields);
                        fields.Remove("*");
                        reportFields = fields.ToArray();

                        if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("PROOF")) & !(reportFields.Contains("ACCOUNT")) & !(reportFields.Contains(">>TOTAL")))
                        {
                            if (reportFields.Length >= 7)
                            {
                                foreach (string s in reportFields)
                                {
                                    if (s == "416")
                                    {
                                        acct = reportFields[0];
                                        if ((reportFields[3] == "S") | (reportFields[3] == "EH") | (reportFields[3] == "LR") | (reportFields[3] == "CP") | (reportFields[3] == "JEF") | (reportFields[3] == "D") | (reportFields[3].Contains("/")))
                                            custName = reportFields[1] + " " + reportFields[2];
                                        else
                                            custName = reportFields[1] + " " + reportFields[2] + " " + reportFields[3];
                                    }
                                    if (s == "423") // get the index and check after for 416 / 421; if present don't use this record
                                    {
                                        int indx = Array.FindIndex(reportFields, item => item == s);
                                        if ((reportFields[indx + 1] != "416") && (reportFields[indx + 1] != "421"))
                                        {
                                            // for the current record if customer name is blank keep the custName obtained above if the account numbers are equal
                                            cmd = new SqlCommand("addLoanCharges_bt", conn);
                                            cmd.CommandType = CommandType.StoredProcedure;

                                            cmd.Parameters.Clear();
                                            if ((reportFields[1] == "S") | (reportFields[1] == "EH") | (reportFields[1] == "LR") | (reportFields[1] == "CP") | (reportFields[1] == "JEF") | (reportFields[1] == "D") | (reportFields[1].Contains("/")))
                                            {
                                                if (reportFields[0] == acct)
                                                {
                                                    // the current customer name is blank
                                                    cmd.Parameters.AddWithValue("@acct", reportFields[0]);
                                                    cmd.Parameters.AddWithValue("@Name", custName);
                                                }
                                            }
                                            else  // current record customer name not blank get the current name, it could be 2 or 3 fields
                                            {
                                                if ((reportFields[3] == "S") | (reportFields[3] == "EH") | (reportFields[3] == "LR") | (reportFields[3] == "CP") | (reportFields[3] == "JEF") | (reportFields[3] == "D") | (reportFields[3].Contains("/")))
                                                    custName = reportFields[1] + " " + reportFields[2];
                                                else
                                                    custName = reportFields[1] + " " + reportFields[2] + " " + reportFields[3];

                                                cmd.Parameters.AddWithValue("@acct", reportFields[0]);
                                                cmd.Parameters.AddWithValue("@Name", custName);
                                            }

                                            transAmt = Math.Round((Convert.ToDouble(ConvertNegativeBalance(reportFields[(reportFields.Length - 4)]))), 2);
                                            natFees = Math.Round((transAmt / VatValue), 2);
                                            vat = Math.Round((transAmt - natFees), 2);

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
                                }
                            }
                        }
                    }

                }
                readFile.Close();
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

        protected string WriteSAV132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {



            string result = "";
            cmd = new SqlCommand("addSafeKeeping_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                Thread.Sleep(1000);
                readFile = new StreamReader(file);

                while ((line = readFile.ReadLine()) != null)
                {
                    if (line.Contains("=") && line.Contains("SYSTEM") && line.Contains("GENERATED"))
                    {
                        break;
                    }
                    else
                    {
                        reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("C-I-F")) & !(reportFields.Contains("ACCOUNT")))
                        {
                            if (reportFields.Length > 1)
                            {
                                if (reportFields[2] == "*226")
                                {
                                    transAmt = Math.Round((Convert.ToDouble(ConvertNegativeBalance(reportFields[3]))), 2);
                                    natFees = Math.Round((transAmt / VatValue), 2);
                                    vat = Math.Round((transAmt - natFees), 2);
                                    acct = reportFields[0];

                                    cmd.Parameters.AddWithValue("@Acct", acct);
                                    cmd.Parameters.AddWithValue("@CIF", reportFields[1]);
                                    cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                    cmd.Parameters.AddWithValue("@Branch", branch);
                                    cmd.Parameters.AddWithValue("@transcode", reportFields[2]);
                                    cmd.Parameters.AddWithValue("@ProofSequence", reportFields[4]);
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
                        }
                    }
                }
                readFile.Close();
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

        protected string WriteDDASCJRecsToDb(string fileName, DateTime rptDate, string branch, SqlConnection conn)
        {


            string result = "";

            cmd = new SqlCommand("addDDASCJ_bt", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                Thread.Sleep(1000);
                readFile = new StreamReader(fileName);

                while ((line = readFile.ReadLine()) != null)
                {
                    if ((line.Contains("SERVICE")) && (line.Contains("CHG")) && (line.Contains("CODE")))
                    {
                        break;
                    }
                    else
                    {
                        reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.None);

                        // get the correct records to insert
                        if (reportFields.Length > 2)
                        {
                            if ((reportFields[0] != "LST") & (reportFields[0] != "REPORT") & (reportFields[0] != "REPORT") & (reportFields[0] != "CY") & (reportFields[2] != "ACCOUNT") & !(reportFields.Contains("***")))
                            {
                                //determine number of valid data fields
                                numValidDataFields = 0;
                                for (int i = 0; i < reportFields.Length; i++)
                                    if (reportFields[i] != "")
                                        numValidDataFields++;

                                string[] validDataFields = new String[numValidDataFields];
                                j = 0;

                                for (int i = 0; i < reportFields.Length; i++)
                                {
                                    if (reportFields[i] != "")
                                    {
                                        validDataFields[j] = reportFields[i];
                                        j++;
                                    }
                                }
                                if ((validDataFields.Length > 15) && (validDataFields[(validDataFields.Length - 12)]) != ".00")
                                {
                                    try
                                    {
                                        charged = Math.Round((Convert.ToDouble((validDataFields[(validDataFields.Length - 12)]))), 2);
                                        natFees = Math.Round((charged / VatValue), 2);
                                        vat = Math.Round((charged - natFees), 2);
                                        acct = validDataFields[0];

                                        cmd.Parameters.AddWithValue("@Branch_Number", branch);
                                        cmd.Parameters.AddWithValue("@ACCT", validDataFields[0]);
                                        cmd.Parameters.AddWithValue("@Customer_Name", (validDataFields[1] + validDataFields[2] + validDataFields[3]));
                                        cmd.Parameters.AddWithValue("@RptDate", rptDate);
                                        cmd.Parameters.AddWithValue("@Charged", charged);
                                        cmd.Parameters.AddWithValue("@VAT", vat);
                                        cmd.Parameters.AddWithValue("@National_Fees", natFees);

                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();

                                        cmd.Parameters.Clear();
                                    }
                                    catch(Exception ex)
                                    {
                                        
                                    }
                                }
                            }
                        }
                    }
                }
                readFile.Close();
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

        protected string WriteDDA132RecsToDb(string file, DateTime rptDate, string branch, SqlConnection conn)
        {
            string result;

            //count the records for that date to ensure no double posting


            try
            {
                Thread.Sleep(1000);
                readFile = new StreamReader(file);

                while ((line = readFile.ReadLine()) != null)
                {
                    if (line.Contains("=") && line.Contains("SYSTEM") && line.Contains("GENERATED"))
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            reportFields = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            if (!(reportFields.Contains("LST")) & !(reportFields.Contains("REPORT")) & !(reportFields.Contains("C-I-F")) & !(reportFields.Contains("NUMBER")))
                            {
                                if (reportFields.Length > 1)
                                {
                                    switch (reportFields[2])
                                    {
                                        case "*145":
                                            {

                                                cmd = new SqlCommand("addStopCharge_bt", conn);
                                                cmd.CommandType = CommandType.StoredProcedure;

                                                transAmt = Math.Round((Convert.ToDouble(reportFields[5])), 2);
                                                natFees = Math.Round((transAmt / VatValue), 2);
                                                vat = Math.Round((transAmt - natFees), 2);
                                                acct = reportFields[1];
                                                try
                                                {
                                                    cmd.Parameters.AddWithValue("@CIF", reportFields[0]);
                                                    cmd.Parameters.AddWithValue("@Acct", acct);
                                                    cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                                    cmd.Parameters.AddWithValue("@Branch", branch);
                                                    cmd.Parameters.AddWithValue("@transcode", reportFields[2]);
                                                    cmd.Parameters.AddWithValue("@ProofSequence", reportFields[3]);
                                                    cmd.Parameters.AddWithValue("@CheckNumber", reportFields[4]);
                                                    cmd.Parameters.AddWithValue("@transAmt", reportFields[5]);
                                                    cmd.Parameters.AddWithValue("@NationalFees", natFees);
                                                    cmd.Parameters.AddWithValue("@VAT", vat);

                                                    conn.Open();
                                                    cmd.ExecuteNonQuery();
                                                    conn.Close();
                                                    cmd.Parameters.Clear();
                                                }
                                                catch(Exception ex)
                                                {
                                                    if (printlog > 0)
                                                    {
                                                        sb.Clear();
                                                        sb.Append("Error in file " + file + "\n");
                                                        sb.Append("============================================");
                                                        sb.Append("CIF = "+ reportFields[0] + "\n");
                                                        sb.Append("Acct = " + acct + "\n");
                                                        sb.Append("transcode = " + reportFields[2] + "\n");
                                                        sb.Append("ProofSequence = " + reportFields[3] + "\n");
                                                        sb.Append("CheckNumber = " + reportFields[4] + "\n");
                                                        sb.Append("transAmt = " + reportFields[5] + "\n");
                                                        sb.Append("================================================");
                                                        sb.Append("\n");
                                                        File.AppendAllText(logfilepath, sb.ToString());
                                                    }
                                                }
                                                break;
                                            }
                                        case "*127":
                                            {
                                                try
                                                {
                                                    cmd = new SqlCommand("addSafeKeeping_bt", conn);
                                                    cmd.CommandType = CommandType.StoredProcedure;

                                                    transAmt = Math.Round((Convert.ToDouble(reportFields[5])), 2);
                                                    natFees = Math.Round((transAmt / VatValue), 2);
                                                    vat = Math.Round((transAmt - natFees), 2);
                                                    acct = reportFields[1];

                                                    cmd.Parameters.AddWithValue("@CIF", reportFields[0]);
                                                    cmd.Parameters.AddWithValue("@Acct", acct);
                                                    cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                                    cmd.Parameters.AddWithValue("@Branch", branch);
                                                    cmd.Parameters.AddWithValue("@transcode", reportFields[2]);
                                                    cmd.Parameters.AddWithValue("@ProofSequence", reportFields[3]);
                                                    cmd.Parameters.AddWithValue("@CheckNumber", reportFields[4]);
                                                    cmd.Parameters.AddWithValue("@transAmt", reportFields[5]);
                                                    cmd.Parameters.AddWithValue("@NationalFees", natFees);
                                                    cmd.Parameters.AddWithValue("@VAT", vat);

                                                    conn.Open();
                                                    cmd.ExecuteNonQuery();
                                                    conn.Close();
                                                    cmd.Parameters.Clear();
                                                }
                                                catch(Exception ex)
                                                {
                                                    if (printlog > 0)
                                                    {
                                                        sb.Clear();
                                                        sb.Append("Error in file " + file + "\n");
                                                        sb.Append("============================================");
                                                        sb.Append("CIF = " + reportFields[0] + "\n");
                                                        sb.Append("Acct = " + acct + "\n");
                                                        sb.Append("transcode = " + reportFields[2] + "\n");
                                                        sb.Append("ProofSequence = " + reportFields[3] + "\n");
                                                        sb.Append("CheckNumber = " + reportFields[4] + "\n");
                                                        sb.Append("transAmt = " + reportFields[5] + "\n");
                                                        sb.Append("================================================");
                                                        sb.Append("\n");
                                                        File.AppendAllText(logfilepath, sb.ToString());
                                                    }
                                                }
                                                break;
                                            }
                                        case "*164":
                                            {
                                                try
                                                {
                                                    cmd = new SqlCommand("addTransCharge_bt", conn);
                                                    cmd.CommandType = CommandType.StoredProcedure;

                                                    transAmt = Math.Round((Convert.ToDouble(reportFields[5])), 2);
                                                    natFees = Math.Round((transAmt / VatValue), 2);
                                                    vat = Math.Round((transAmt - natFees), 2);
                                                    acct = reportFields[1];

                                                    cmd.Parameters.AddWithValue("@CIF", reportFields[0]);
                                                    cmd.Parameters.AddWithValue("@Acct", acct);
                                                    cmd.Parameters.AddWithValue("@dateactive", rptDate);
                                                    cmd.Parameters.AddWithValue("@Branch", branch);
                                                    cmd.Parameters.AddWithValue("@trasncode", reportFields[2]);
                                                    cmd.Parameters.AddWithValue("@ProffSequence", reportFields[3]);
                                                    cmd.Parameters.AddWithValue("@checkNumber", reportFields[4]);
                                                    cmd.Parameters.AddWithValue("@transAmt", reportFields[5]);
                                                    cmd.Parameters.AddWithValue("@NationalFees", natFees);
                                                    cmd.Parameters.AddWithValue("@VAT", vat);

                                                    conn.Open();
                                                    cmd.ExecuteNonQuery();
                                                    conn.Close();
                                                    cmd.Parameters.Clear();
                                                }
                                                catch(Exception ex)
                                                {
                                                    if (printlog > 0)
                                                    {
                                                        sb.Clear();
                                                        sb.Append("Error in file " + file + "\n");
                                                        sb.Append("============================================");
                                                        sb.Append("CIF = " + reportFields[0] + "\n");
                                                        sb.Append("Acct = " + acct + "\n");
                                                        sb.Append("transcode = " + reportFields[2] + "\n");
                                                        sb.Append("ProofSequence = " + reportFields[3] + "\n");
                                                        sb.Append("CheckNumber = " + reportFields[4] + "\n");
                                                        sb.Append("transAmt = " + reportFields[5] + "\n");
                                                        sb.Append("================================================");
                                                        sb.Append("\n");
                                                        File.AppendAllText(logfilepath, sb.ToString());
                                                    }
                                                }
                                                break;
                                            }
                                    }
                                }
                            }
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

                        }
                    }
                }
                readFile.Close();
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
