using Microsoft.Extensions.Primitives;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.DAL.CoreData_DB;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace VATCustomServices
{
    public class OnlineBankingSerices
    {
        private readonly CoreDataContext coreDataContext;

        public OnlineBankingSerices(CoreDataContext coreDataContext)
        {
            this.coreDataContext = coreDataContext;
        }
        string log;
        StreamWriter stw;
        DbAccess dbaccess;
        static string extension;
        string recipient, delResult;
        int result;
        static string fileMonth;
        static string[] fileName;
        string mailSubject;
        string StatusMessage;
        string logfilepath = "";
        int printlog = 0;
        SqlConnection conn;
        SqlCommand cmd;
        StringBuilder sb = new StringBuilder();
        IGeneralResult<string> res = new GeneralResult<string>();
        public async Task<IGeneralResult<string>> UploadFiles(DateTime date,bool IsChecked, string connectionstring, int printLog, string logpath, string SoucPath, string DesPath,string ftp,string UserName,string password)
        {
            dbaccess = new DbAccess();
            extension = date.Year.ToString() + date.Month.ToString("00") + date.Day.ToString("00");
            int recordsThere = 0;
            //string sourceDir = @"\\bank10\winpoint$\oda0\MISC\" + fileMonth + @"\"; 
            // string sourceDir = SoucPath + fileMonth ;
            string sourceDir = SoucPath;
            //string sourceDir = SoucPath+ date.Month.ToString("00")+"\\";
            logfilepath = logpath;
            printlog = printLog;
            if (printlog > 0)
            {
                sb.Clear();
                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                sb.Append("log start\n");
                System.IO.File.AppendAllText(logfilepath, sb.ToString());
            }

            try
            {
                // get the file wih the date selected from the calendar 
                //delete the DayTrnTemp table to prevent duplication of records only proceed if the delete was successful
                delResult = dbaccess.DeleteDayTrnTemp(printLog, logpath, connectionstring);

                result = dbaccess.CheckForDayTrnRecords(extension, ref recordsThere, printLog, logpath, connectionstring);
                if (result == 0 && delResult.Contains("Records successfully deleted from DayTrnHistoryTemp"))
                {
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append("Check DeleteDayTrnTemp record deleted and CheckForDayTenRecord Empty\n");
                        System.IO.File.AppendAllText(logfilepath, sb.ToString());
                    }
                    if (recordsThere == 0)
                    {
                        if (printlog > 0)
                        {
                            sb.Clear();
                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                            sb.Append("CheckDayTrnRecord contain 0 now continue with sourceDir.\n");
                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                        }
                        try
                        {
                            if (printlog > 0)
                            {
                                sb.Clear();
                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                sb.Append("sourceDir=" + sourceDir + "\n");
                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                            }
                            // retrieve the file from the directory on bank10 to upload

                            if (Directory.Exists(sourceDir))
                            {
                                fileName = Directory.GetFiles(sourceDir, "DAYTRN." + extension);
                                if (printlog > 0)
                                {
                                    sb.Clear();
                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                    sb.Append("Getting the Source Path " + sourceDir + "\n");
                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                }
                                if (fileName[0] != null)
                                {
                                    //get the files selected
                                    try
                                    {
                                        #region tryblock
                                        string targetDir = DesPath;
                                        string result1;

                                        // save the file selected locally for faster reading
                                        string newFile = Path.Combine(targetDir, "DAYTRN." + extension);
                                        System.IO.File.Copy(fileName[0], targetDir + "DAYTRN." + extension, true);
                                        FileInfo dayTrnFile = new FileInfo(targetDir + "DAYTRN." + extension);

                                        FileInfo jhhFile = new FileInfo(targetDir + "jhhistory.txt");
                                        jhhFile.Delete();
                                        if (printlog > 0)
                                        {
                                            sb.Clear();
                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                            sb.Append("jhhistory.txt file created on your Destination Path." + targetDir + "\n");
                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                        }
                                        // read the daytrn file
                                        using (StreamReader str = new StreamReader(dayTrnFile.OpenRead(), false))
                                        {
                                            // first fill the DayTrnFormat data tables to get the format of each line
                                            //CoreDataDsTableAdapters.DayTrnFormatTableAdapter daytrnTA = new CoreDataDsTableAdapters.DayTrnFormatTableAdapter();
                                            //daytrnTA.Fill(coreDS.DayTrnFormat); // fill the daytrn format datatable
                                            string line;
                                            dbaccess.OpenConnBnk30(connectionstring);

                                            var lst = dbaccess.checkDayTrnFromate(connectionstring).ToList();

                                            int count = lst.Count();

                                            while ((line = str.ReadLine()) != null)
                                            {
                                                if (printlog > 0)
                                                {
                                                    sb.Clear();
                                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                    sb.Append("file start reading from the source file " + targetDir + "\n");
                                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                }

                                                if (printlog > 0)
                                                {
                                                    sb.Clear();
                                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                    sb.Append("count=" + count.ToString() + "\n");
                                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                }

                                                string[] recordCols = new string[count];

                                                for (int x = 0; x < lst.Count; x++)
                                                {
                                                    int start = Convert.ToInt32(lst[x].FieldStartPosition);
                                                    int fieldLength = Convert.ToInt32(lst[x].FieldLength);
                                                    recordCols[x] = line.Substring(start, fieldLength);
                                                }

                                                if (printlog > 0)
                                                {
                                                    sb.Clear();
                                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                    sb.Append("for loop for list insert:" + recordCols.Count().ToString() + "\n");
                                                    sb.Append("connectionstring" + connectionstring + "\n");
                                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                }

                                                // pass the data to the DbAccess.cs to inserted into the \\Bank\CoreData db
                                                result1 = dbaccess.AddDayTrnRec(recordCols, connectionstring);

                                                if (result1.Contains("Error"))
                                                {
                                                    res.Message = "Eror reading the DayTrn files " + extension + ", contact MIS";
                                                    res.Successful = false;
                                                }
                                            }
                                            // close streamreader
                                            str.Close();
                                            dbaccess.closeConnection();
                                            ;
                                        }  //using streamreader
                                           //  MessageBox.Show("streamreader closed");
                                           //after exporting daytrn to the db build the jhhistory file
                                           // 1. fill the daytrn and jhhistoryformatforpadding data tables in the dataset
                                           // 2. row by row, column ny column build the corresponding record for the jhhistory file
                                           // 3. use the jhhistory format datatable to get the fields that need padding
                                           // 4. use streamwriter to build each field per record for the jhhistory file
                                           // 5. send to As400 via Ftp

                                        //remove the unused 184 & 185 records from temp table to prevent errors
                                        string nullCodes = dbaccess.RemoveNullCodes(connectionstring);
                                        if (printlog > 0)
                                        {
                                            sb.Clear();
                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                            sb.Append("Remove null code\n");
                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                        }
                                        if (!nullCodes.Contains("error"))  // 184 and 185 successfully moved
                                        {
                                            string deletetemptable;
                                            string field = "";
                                            if (printlog > 0)
                                            {
                                                sb.Clear();
                                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                sb.Append("Move184_185Records , Delete from DayTrnHistoryTemp where column name TranCode(184 and 185)\n");
                                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                            }
                                            // var dayTrn = coreDataContext.DayTrnHistoryTemps.ToList();
                                            var dayTrn = dbaccess.GetDayTrnTemp(connectionstring).ToList();
                                            if (printlog > 0)
                                            {
                                                sb.Clear();
                                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                sb.Append("get the list from DayTrnHistory\n");
                                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                            }
                                            //var jhh = coreDataContext.JhhistoryFormats.ToList();
                                            var jhh = dbaccess.GetJhhistoryFormat(connectionstring).ToList();
                                            if (printlog > 0)
                                            {
                                                sb.Clear();
                                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                sb.Append("get the list from jhhistoryFormats\n");
                                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                            }
                                            DataTableConvertor converter = new DataTableConvertor();
                                            DataTable dt = converter.ToDataTable(dayTrn);
                                            DataTable jhhistory = converter.ToDataTable(jhh);

                                            using (StreamWriter stwr = jhhFile.CreateText())
                                            {
                                                foreach (DataRow row in dt.Rows)
                                                {
                                                    try
                                                    {
                                                        if (printlog > 0)
                                                        {
                                                            sb.Clear();
                                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                            sb.Append("jhhistory file start creating\n");
                                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                        }
                                                        //bank number
                                                        stwr.WriteAsync("001");

                                                        //branch# pad on the right
                                                        string brch = row[10].ToString().Substring(1, 1);
                                                        field = (FormatField(brch, "right", ' ', jhhistory, "JHBCH#"));
                                                        stwr.WriteAsync(field);

                                                        // acct type 
                                                        stwr.WriteAsync(row[0].ToString());

                                                        //   acct num
                                                        field = (FormatField(row[1].ToString(), "left", '0', jhhistory, "JHACCT"));
                                                        stwr.WriteAsync(field);

                                                        // curr code  ( get the numeric code from the tranCode table)
                                                        // field = dbaccess.GetCurrencyCode(row[32].ToString());
                                                        field = "951";
                                                        stwr.WriteAsync(field);

                                                        //    acct stat its blank for now
                                                        field = (FormatField("", "right", ' ', jhhistory, "JHSTAT"));
                                                        stwr.WriteAsync(field);

                                                        // tran code
                                                        field = (FormatField(row[2].ToString().Trim(), "left", ' ', jhhistory, "JHTRCD"));
                                                        stwr.WriteAsync(field);

                                                        //tran date
                                                        field = (FormatField(row[3].ToString().Trim(), "left", ' ', jhhistory, "JHTRDT"));
                                                        stwr.WriteAsync(field);

                                                        // effective date
                                                        field = (FormatField(row[3].ToString().Trim(), "left", ' ', jhhistory, "JHEFDT"));
                                                        stwr.WriteAsync(field);

                                                        // rate
                                                        field = (FormatField("0", "right", '0', jhhistory, "JHRATE"));
                                                        stwr.WriteAsync(field);

                                                        //tran amt
                                                        field = (FormatField(row[31].ToString(), "left", '0', jhhistory, "JHAMT"));
                                                        stwr.WriteAsync(field);

                                                        //tran chq#
                                                        field = (FormatField(row[6].ToString(), "left", '0', jhhistory, "JHSER"));
                                                        stwr.WriteAsync(field);

                                                        //  batch number
                                                        field = (FormatField("0", "left", '0', jhhistory, "JHBCH"));
                                                        stwr.WriteAsync(field);

                                                        //seq#
                                                        field = FormatField(row[9].ToString(), "left", '0', jhhistory, "JHSEQ");
                                                        stwr.WriteAsync(field);

                                                        //expiration date
                                                        field = FormatField("0", "left", '0', jhhistory, "JHEXP");
                                                        stwr.WriteAsync(field);

                                                        //ach code
                                                        field = FormatField("0", "left", '0', jhhistory, "JHACH");
                                                        stwr.WriteAsync(field);

                                                        //charge flag
                                                        field = " ";
                                                        stwr.WriteAsync(field);

                                                        //nobook trans
                                                        field = " ";
                                                        stwr.WriteAsync(field);

                                                        //input source 
                                                        field = " ";
                                                        stwr.WriteAsync(field);

                                                        //debit/credit
                                                        field = dbaccess.GetTranDbCr(row[3].ToString(), connectionstring);
                                                        stwr.WriteAsync(field);

                                                        //balance / int
                                                        field = " ";
                                                        stwr.WriteAsync(field);

                                                        //descr
                                                        field = " ";
                                                        stwr.WriteAsync(field);

                                                        //posted seq
                                                        field = FormatField("0", "left", '0', jhhistory, "JHPSEQ");
                                                        stwr.WriteAsync(field);

                                                        //tran desc 1
                                                        field = FormatField(row[28].ToString(), "left", ' ', jhhistory, "JHDES1");
                                                        stwr.WriteAsync(field);

                                                        // tran desc 2
                                                        field = FormatField(dbaccess.GetTranDescr(row[3].ToString(), connectionstring), "left", ' ', jhhistory, "JHDES2");
                                                        stwr.WriteLineAsync(field);

                                                        stwr.Flush();
                                                    }

                                                    catch (Exception ep)
                                                    {
                                                        //add the row to the errors table
                                                        object[] errRow = row.ItemArray;
                                                        string msg;
                                                        dbaccess.AddDayTrnRecErrors(errRow, connectionstring);
                                                        dbaccess.DeleteDayTrnRecs(Convert.ToString(date), connectionstring);
                                                        if (field.Contains("Error"))
                                                        {
                                                            res.Message = "Error writing to jhhistory file " + field;
                                                        }
                                                        else
                                                        {
                                                            res.Message = "Error writing to jhhistory file " + ep.ToString();
                                                        }
                                                        if (printlog > 0)
                                                        {
                                                            sb.Clear();
                                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                            sb.Append("" + res.Message + " " + sourceDir + "   \n");
                                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                        }
                                                    }
                                                }
                                            }
                                            if(IsChecked == true)
                                            {
                                                string ftpResult = "done";
                                                ftpResult = FtpFile(DesPath, ftp, UserName, password);

                                                if (ftpResult.Contains("Error"))
                                                {
                                                    res.Message = "Status:....Error Uploading the jhhistory in Server.";
                                                    res.Successful = false;
                                                    if (printlog > 0)
                                                    {
                                                        sb.Clear();
                                                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                        sb.Append("" + res.Message + " \n");
                                                        System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                    }
                                                }
                                                else
                                                {
                                                    // remove any data from daytrntemptableelse
                                                    deletetemptable = dbaccess.MoveDaytrnData(connectionstring);
                                                    if (!deletetemptable.Contains("error"))
                                                    {
                                                        res.Message = "status:Jhhistory successfully exported " + extension + " ";
                                                        res.Successful = true;
                                                    }
                                                    else
                                                    {
                                                        res.Message = "jhhistory successfully exported but error deleting temp tables in database" + deletetemptable;
                                                        res.Successful = false;
                                                    }
                                                    if (printlog > 0)
                                                    {
                                                        sb.Clear();
                                                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                        sb.Append("" + res.Message + " \n");
                                                        System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                deletetemptable = dbaccess.MoveDaytrnData(connectionstring);
                                                if (!deletetemptable.Contains("error"))
                                                {
                                                    res.Message = "status:Jhhistory successfully exported " + extension + " ";
                                                    res.Successful = true;
                                                }
                                                else
                                                {
                                                    res.Message = "jhhistory successfully exported but error deleting temp tables in database" + deletetemptable;
                                                    res.Successful = false;
                                                }
                                                if (printlog > 0)
                                                {
                                                    sb.Clear();
                                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                    sb.Append("" + res.Message + " \n");
                                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                                }
                                            }
                                            //  remove the temp files
                                            dayTrnFile.Delete();
                                            //jhhFile.Delete();

                                        }

                                        else
                                        {
                                            if (printlog > 0)
                                            {
                                                sb.Clear();
                                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                                sb.Append("" + res.Message + "   \n");
                                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                            }
                                            res.Message = "Error while removing the null code" + nullCodes;
                                            res.Successful = false;
                                        }
                                        #endregion
                                    }
                                    catch (Exception ex)
                                    {
                                        res.Message = "Error Upload Status: failed ";
                                        if (printlog > 0)
                                        {
                                            sb.Clear();
                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                            sb.Append(""+ex.ToString()+" + res.Message +   \n");
                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                        }
                                    }
                                    finally
                                    {

                                        dbaccess.closeConnection();
                                        if (printlog > 0)
                                        {
                                            sb.Clear();
                                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                            sb.Append("closeConnection" + res.Message + " \n");
                                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                        }
                                    }
                                } //if (fileName[0] != null > daytrn file found for the selected date)
                            }
                            else
                            {
                                if (printlog > 0)
                                {
                                    sb.Clear();
                                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                    sb.Append(" file does not exists " + sourceDir + " \n");
                                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                                }
                                res.Message = "File does not exists in your source path." + sourceDir;
                                res.Successful = false;
                            }

                        }
                        catch (Exception err)
                        {
                            if (printlog > 0)
                            {
                                sb.Clear();
                                sb.Append("------------" + System.DateTime.Now + "-----------\n");
                                sb.Append(" file doesnot exists " + sourceDir + " \n");
                                System.IO.File.AppendAllText(logfilepath, sb.ToString());
                            }
                            res.Message = "File does not exists in your source path.";
                            res.Successful = false;
                        }
                    } //if (recordsThere ==0)
                    else
                    {
                        if (printlog > 0)
                        {
                            sb.Clear();
                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                            sb.Append(" Selected date is not in source file \n");
                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                        }
                        res.Message = "Selected date is not in source file";

                    }
                }
                else
                {
                    res.Message = "This file is already exist in table.";
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append(" Error While reading the procedure DeleteDayTrnTemp & CheckForDayTrnRecords \n");
                        System.IO.File.AppendAllText(logfilepath, sb.ToString());
                    }
                }
            }

            catch (Exception ex)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("Error deleting temp " + ex + "  \n");
                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                }
                res.Message = "Error deleting temp table. ";
                res.Successful = false;
            }
            return res;

        }

       // ftp_upload
        private string FtpFile(string DesPath,string ftp,string UserName,string password)
        {
            string result = "Jhhistory successfully uploaded";
            try
            {
                // ftp to AS400
                //Upload in local remote
                string host = ftp;
               
                string user = UserName;
                string pwd = password;
                string sourceFile = DesPath+"/"+"jhhistory.txt";
                // host = "ftp://" + host+"/"+ "jhhistory.txt";
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("In Uploading on ftp server the destinaton path fetch to upload\n");
                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                }
                //get file size
                FileInfo srcFile = new FileInfo(sourceFile);
                long srcFileSize = srcFile.Length;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
                request.Credentials = new NetworkCredential(user, pwd);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = System.IO.File.OpenRead(sourceFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (printlog > 0)
                        {
                            sb.Clear();
                            sb.Append("------------" + System.DateTime.Now + "-----------\n");
                            sb.Append("Jhhistory file uploading on a server \n");
                            System.IO.File.AppendAllText(logfilepath, sb.ToString());
                        }
                        ftpStream.Write(buffer, 0, read);
                        Console.WriteLine("Uploaded {0} bytes", fileStream.Position);
                    }
                }

                return result;
            }
            catch (Exception f)
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(f+"\n");
                    System.IO.File.AppendAllText(logfilepath, sb.ToString());
                }
                result = "Error setting up for ftp " + f.ToString();
                return result;
            }
        }
        public string FormatField(string fld, string direction, char padChar, DataTable dt, string jhhCode)
        {
            string field;

            try
            {
                int length = (from DataRow dr in dt.Rows
                              where (string)dr[0] == jhhCode
                              select Convert.ToInt16(dr[1])).FirstOrDefault();
                if (direction == "right")
                    field = fld.PadRight(length, padChar);
                else
                    field = fld.PadLeft(length, padChar);
                return field;
            }
            catch (Exception e)
            {
                field = "Error formatting Data field " + e.ToString();
                return field;

            }
        }

    }
}
