using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using VATCustomServices.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;

namespace VATCustomServices
{
    public class DbAccess
    {
        SqlCommand cmd;
        string cmdSelect;
        int printlog = 0;
        StringBuilder sb = new StringBuilder();
        string logfilepath = "";
        SqlConnection conn;
        //SqlConnection db = new SqlConnection("Server=BANKSQL;Database=CoreData;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;");
        //SqlConnection db = new SqlConnection("Server=SYS82\\SQLEXPRESS,1433;Database=CoreData;TrustServerCertificate=true;Trusted_Connection=True;user id=server;password=Bt1234%^;Integrated Security=false;");
        public void OpenConnBnk30(string connectionstring)
        {
            conn = new SqlConnection(connectionstring);

            if (conn?.State == ConnectionState.Open)
            {
                conn?.Close();
                conn?.Open();
            }
            else
                conn?.Open();
        }

        public void closeConnection()
        {
            conn?.Close();
        }

        public void OpenConnBnk30()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else
                conn.Open();
        }

        public string AddDayTrnRec(string[] data,string connectionstring)
        {
            //SqlConnection con = new SqlConnection(connectionstring);
            string result = "DayTrn records saved to DayTrnHistoryTemp Table";

            try
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("Inserting the Data from addDayTrnRec procedure");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                    cmd = new SqlCommand("addDayTrnRec", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", data[0].Trim());
                    cmd.Parameters.AddWithValue("@AcctNum", data[1].Trim());
                    cmd.Parameters.AddWithValue("@TranCode", data[2].Trim());
                    cmd.Parameters.AddWithValue("@TranDate", data[3].Trim());
                    cmd.Parameters.AddWithValue("@ErrorCode", data[4].Trim());
                    cmd.Parameters.AddWithValue("@TranAmount", data[5].Trim());
                    cmd.Parameters.AddWithValue("@CheckNum", data[6].Trim());
                    cmd.Parameters.AddWithValue("@CstUtil1", data[7].Trim());
                    cmd.Parameters.AddWithValue("@TranFlag", data[8].Trim());
                    cmd.Parameters.AddWithValue("@SeqNum", data[9].Trim());
                    cmd.Parameters.AddWithValue("@BrchNum", data[10].Trim());
                    cmd.Parameters.AddWithValue("@GlCode", data[11].Trim());
                    cmd.Parameters.AddWithValue("@SrcSeqNum", data[12].Trim());
                    cmd.Parameters.AddWithValue("@TranSource", data[13].Trim());
                    cmd.Parameters.AddWithValue("@FloatField1", data[14].Trim());
                    cmd.Parameters.AddWithValue("@UtlCompCode", data[15].Trim());
                    cmd.Parameters.AddWithValue("@CstUtil2", data[16].Trim());
                    cmd.Parameters.AddWithValue("@FloatField2", data[17].Trim());
                    cmd.Parameters.AddWithValue("@DtkUtl", data[18].Trim());
                    cmd.Parameters.AddWithValue("@FloatField3", data[19].Trim());
                    cmd.Parameters.AddWithValue("@FloatDays1", data[20].Trim());
                    cmd.Parameters.AddWithValue("@FloatDays2", data[21].Trim());
                    cmd.Parameters.AddWithValue("@FloatDays3", data[22].Trim());
                    cmd.Parameters.AddWithValue("@DepItmCnt", data[23].Trim());
                    cmd.Parameters.AddWithValue("@UsDepItmCnt", data[24].Trim());
                    cmd.Parameters.AddWithValue("@clrItmCnt", data[25].Trim());
                    cmd.Parameters.AddWithValue("@ErrorCode2", data[26].Trim());
                    cmd.Parameters.AddWithValue("@Pstng", data[27].Trim());
                    cmd.Parameters.AddWithValue("@Description", data[28].Trim());
                    cmd.Parameters.AddWithValue("@DsiSeqNum", data[29].Trim());
                    cmd.Parameters.AddWithValue("@TranTime", data[30].Trim());
                    cmd.Parameters.AddWithValue("@FcAmount", data[31].Trim());
                    cmd.Parameters.AddWithValue("@FcCode", data[32].Trim());
                    cmd.Parameters.AddWithValue("@EccbType", data[33].Trim());
                    cmd.Parameters.AddWithValue("@EccbCode", data[34].Trim());
                    cmd.Parameters.AddWithValue("@Teller", data[35].Trim());
                    cmd.Parameters.AddWithValue("@Date", data[36].Trim());
                    cmd.Parameters.AddWithValue("@Time", data[37].Trim());


                    cmd.ExecuteNonQuery();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("Data inserted addDayTrnRec procedure");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                //}
            }
            catch (SqlException s)
            {
                result = "Error adding daytrn records to DayTrnHistoryTemp Table: " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result +s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
            //finally
            //{
            //    //conn.Close();
            //    if (printlog > 0)
            //    {
            //        sb.Clear();
            //        sb.Append("------------" + System.DateTime.Now + "-----------\n");
            //        sb.Append("AddDayTrnRec Database connection close \n" + connectionstring);
            //        File.AppendAllText(logfilepath, sb.ToString());
            //    }
            //}
            return result;
        }

        public string AddDayTrnRecErrors(object[] data,string connectionstring)
        {
            string result = "DayTrn records saved to DayTrnHistoryTemp Table";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("addDayTrnRecErrors", conn);
                cmd.CommandTimeout = 36000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", data[0].ToString().Trim());
                cmd.Parameters.AddWithValue("@AcctNum", data[1].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranCode", data[2].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranDate", data[3].ToString().Trim());
                cmd.Parameters.AddWithValue("@ErrorCode", data[4].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranAmount", data[5].ToString().Trim());
                cmd.Parameters.AddWithValue("@CheckNum", data[6].ToString().Trim());
                cmd.Parameters.AddWithValue("@CstUtil1", data[7].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranFlag", data[8].ToString().Trim());
                cmd.Parameters.AddWithValue("@SeqNum", data[9].ToString().Trim());
                cmd.Parameters.AddWithValue("@BrchNum", data[10].ToString().Trim());
                cmd.Parameters.AddWithValue("@GlCode", data[11].ToString().Trim());
                cmd.Parameters.AddWithValue("@SrcSeqNum", data[12].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranSource", data[13].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatField1", data[14].ToString().Trim());
                cmd.Parameters.AddWithValue("@UtlCompCode", data[15].ToString().Trim());
                cmd.Parameters.AddWithValue("@CstUtil2", data[16].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatField2", data[17].ToString().Trim());
                cmd.Parameters.AddWithValue("@DtkUtl", data[18].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatField3", data[19].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatDays1", data[20].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatDays2", data[21].ToString().Trim());
                cmd.Parameters.AddWithValue("@FloatDays3", data[22].ToString().Trim());
                cmd.Parameters.AddWithValue("@DepItmCnt", data[23].ToString().Trim());
                cmd.Parameters.AddWithValue("@UsDepItmCnt", data[24].ToString().Trim());
                cmd.Parameters.AddWithValue("@clrItmCnt", data[25].ToString().Trim());
                cmd.Parameters.AddWithValue("@ErrorCode2", data[26].ToString().Trim());
                cmd.Parameters.AddWithValue("@Pstng", data[27].ToString().Trim());
                cmd.Parameters.AddWithValue("@Description", data[28].ToString().Trim());
                cmd.Parameters.AddWithValue("@DsiSeqNum", data[29].ToString().Trim());
                cmd.Parameters.AddWithValue("@TranTime", data[30].ToString().Trim());
                cmd.Parameters.AddWithValue("@FcAmount", data[31].ToString().Trim());
                cmd.Parameters.AddWithValue("@FcCode", data[32].ToString().Trim());
                cmd.Parameters.AddWithValue("@EccbType", data[33].ToString().Trim());
                cmd.Parameters.AddWithValue("@EccbCode", data[34].ToString().Trim());
                cmd.Parameters.AddWithValue("@Teller", data[35].ToString().Trim());
                cmd.Parameters.AddWithValue("@Date", data[36].ToString().Trim());
                cmd.Parameters.AddWithValue("@Time", data[37].ToString().Trim());

                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmd.ExecuteScalar();
                cmd.Connection.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                result = "Error adding daytrn records to DayTrnHistoryError Table: " + s.ToString();
            }
            return result;
        }

        internal string RemoveNullCodes(string connectionstring)
        {
            string result = "Records Moved";
            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("Move184_185Records", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                cmd.ExecuteScalar();
                cmd.Dispose();
                conn.Close();
            }
            catch (SqlException sp)
            {
                result = "Error moving 184 / 185 records " + sp.ToString();
            }

            return result;
        }

        public string GetTranDescr(string code,string connectionstring)
        {
            string result = "";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("getTranDescription", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", code.Trim());

                conn.Open();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getTranDescription connection open");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                conn.Close();

                return result;
            }
            catch (SqlException s)
            {
                result = "Error retrieving tran description " + s.ToString();
                return result;
            }
            finally
            {
                conn.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getTranDescription connection close");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
        }


        public string GetTranDbCr(string code,string connectionstring)
        {
            string result = "";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("getTranDbCr", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", code.Trim());

                conn.Open();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getTranDbCr connection open");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                result = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                conn.Close();

                return result;
            }
            catch (SqlException s)
            {
                result = "Error retrieving whether transaction is a debit / credit " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                return result;
            }
            finally
            {
                conn.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getTranDbCr connection close");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
        }

        public string GetCurrencyCode(string code,string connectionstring)
        {
            string result = "";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("getCurrencyCode", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", code.Trim());

                conn.Open();
                result = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();
                conn.Close();
                return result;
            }
            catch (SqlException s)
            {
                result = "Error retrieving currency code " + s.ToString();
                return result;
            }


        }
        public List<DayTrnFormateVm> checkDayTrnFromate(string connectionstring)
        {

            string result = "Check formate from DayTrnFormate";
            List<DayTrnFormateVm> DayTrnFormateList = new List<DayTrnFormateVm>();

            try
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("CheckDayTrnFormat", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DayTrnFormateVm lst = null;

                while (reader.Read())
                {
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append("checkDAyTrnFormat reader start");
                        File.AppendAllText(logfilepath, sb.ToString());
                    }
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append("Reading the formate from CheckDayTrnFormat procedure");
                        File.AppendAllText(logfilepath, sb.ToString());
                    }
                    lst = new DayTrnFormateVm();
                    lst.Code = reader["Code"].ToString();
                    lst.FieldLength = (int)reader["FieldLength"];
                    lst.Description = reader["Description"].ToString();
                    lst.FieldStartPosition = (int)reader["FieldStartPosition"];
                    DayTrnFormateList.Add(lst);
                }
                reader.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("checkDAyTrnFormat reader close");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                return DayTrnFormateList;
            }
            catch (SqlException s)
            {
                result = "Error checkingformate from DayTrnFormate " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result + s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            //finally
            //{
                //conn.Close();
               
                //if (printlog > 0)
                //{
                //    sb.Clear();
                //    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                //    sb.Append("CheckDayTrnFormat Database connection close \n" + connectionstring);
                //    File.AppendAllText(logfilepath, sb.ToString());
                //}
            //}
            return DayTrnFormateList;
        }


        public List<DayTrnTemp> GetDayTrnTemp(string connectionstring)
        {

            string result = "Check formate from DayTrnFormate";
            List<DayTrnTemp> DayTrnFormateList = new List<DayTrnTemp>();

            try
            {

                //if (conn.State != ConnectionState.Open)
                  conn.Open();
                //SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("getDayTrnHistoryTemp", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DayTrnTemp lst = null;

                while (reader.Read())
                {
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append("Reading the formate from CheckDayTrnFormat procedure");
                        File.AppendAllText(logfilepath, sb.ToString());
                    }
                    lst = new DayTrnTemp();
                    //lst.Code = reader["Code"].ToString();
                    //lst.FieldLength = (int)reader["FieldLength"];
                    //lst.Description = reader["Description"].ToString();
                    //lst.FieldStartPosition = (int)reader["FieldStartPosition"];

                    lst.RecId= Convert.ToInt64(reader["RecId"].ToString());
                    lst.Type= reader["Type"].ToString();
                    lst.AcctNum = reader["AcctNum"].ToString();
                    lst.TranCode = reader["TranCode"].ToString();
                    lst.TranDate = reader["TranDate"].ToString();
                    lst.ErrorCode = reader["ErrorCode"].ToString();
                    lst.TranAmount = reader["TranAmount"].ToString();
                    lst.CheckNum = reader["CheckNum"].ToString();
                    lst.CstUtil1 = reader["CstUtil1"].ToString();
                    lst.TranFlag = reader["TranFlag"].ToString();
                    lst.SeqNum = reader["SeqNum"].ToString();
                    lst.BrchNum = reader["BrchNum"].ToString();
                    lst.GlCode = reader["GlCode"].ToString();
                    lst.SrcSeqNum = reader["SrcSeqNum"].ToString();
                    lst.TranSource = reader["TranSource"].ToString();
                    lst.FloatField1 = reader["FloatField1"].ToString();
                    lst.UtlCompCode = reader["UtlCompCode"].ToString();
                    lst.CstUtil2 = reader["CstUtil2"].ToString();
                    lst.FloatField2 = reader["FloatField2"].ToString();
                    lst.DtkUtl = reader["DtkUtl"].ToString();
                    lst.FloatField3 = reader["FloatField3"].ToString();
                    lst.FloatDays1 = reader["FloatDays1"].ToString();
                    lst.FloatDays2 = reader["FloatDays2"].ToString();
                    lst.FloatDays3 = reader["FloatDays3"].ToString();
                    lst.DepItmCnt = reader["DepItmCnt"].ToString();
                    lst.UsDepItmCnt = reader["UsDepItmCnt"].ToString();
                    lst.ClrItmCnt = reader["ClrItmCnt"].ToString();

                    lst.ErrorCode2 = reader["ErrorCode2"].ToString();
                    lst.Pstng = reader["Pstng"].ToString();
                    lst.Description = reader["Description"].ToString();
                    lst.DsiSeqNum = reader["DsiSeqNum"].ToString();
                    lst.TranTime = reader["TranTime"].ToString();
                    lst.FcAmount = reader["FcAmount"].ToString();
                    lst.FcCode = reader["FcCode"].ToString();
                    lst.EccbType = reader["EccbType"].ToString();
                    lst.EccbCode = reader["EccbCode"].ToString();
                    lst.Teller = reader["Teller"].ToString();
                    lst.Date = reader["Date"].ToString();
                    lst.Time = reader["Time"].ToString();
                    DayTrnFormateList.Add(lst);
                }
                reader.Close();
                return DayTrnFormateList;
            }
            catch (SqlException s)
            {
                result = "Error checkingformate from DayTrnFormate " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result + s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
            }
            
            return DayTrnFormateList;
        }


        public List<JhhistoryFormatVm> GetJhhistoryFormat(string connectionstring)
        {

            string result = "Check formate from JhhistoryFormat";
            List<JhhistoryFormatVm> DayTrnFormateList = new List<JhhistoryFormatVm>();

            try
            {
                conn.Open();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getJhhistoryFormat connection open");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                //SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("getJhhistoryFormat", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                JhhistoryFormatVm lst = null;

                while (reader.Read())
                {
                    if (printlog > 0)
                    {
                        sb.Clear();
                        sb.Append("------------" + System.DateTime.Now + "-----------\n");
                        sb.Append("Reading the formate from getJhhistoryFormat procedure");
                        File.AppendAllText(logfilepath, sb.ToString());
                    }
                    lst = new JhhistoryFormatVm();
                    lst.Code = reader["Code"].ToString();
                    lst.FieldLength = Convert.ToInt32(reader["FieldLength"].ToString());
                    lst.Description = reader["Description"].ToString();
                    lst.FieldStartPosition = Convert.ToInt32(reader["FieldStartPosition"].ToString());
                   
                    DayTrnFormateList.Add(lst);
                }
                reader.Close();
                return DayTrnFormateList;
            }
            catch (SqlException s)
            {
                result = "Error getJhhistoryFormat from JhhistoryFormat " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result + s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getJhhistoryFormat connection close");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }

            return DayTrnFormateList;
        }
        public string MoveDaytrnData(string connectionstring)
        {

            //move data from [DayTrnHistoryTemp] to [DayTrnHistory]
            string result = "Export Successful from Temp Table to DayTrnHistory successful";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("ExportDayTrnRecords", conn);
                cmd.CommandTimeout = 36000;
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("MoveDaytrnData Database connection open \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            catch (SqlException s)
            {
                result = "Error deleting data from DayTrnHistoryTemp " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result +s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                } 
                cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("MoveDaytrnData Database connection close \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
            return result;
        }

        public string getDayTrnTemp(string connectionstring)
        {

            //move data from [DayTrnHistoryTemp] to [DayTrnHistory]
            string result = "Export Successful from Temp Table to DayTrnHistory successful";

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("getDayTrnHistoryTemp", conn);
                cmd.CommandTimeout = 36000;
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getDayTrnHistoryTemp Database connection open \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            catch (SqlException s)
            {
                result = "Error deleting data from getDayTrnHistoryTemp " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(result + s.ToString);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("getDayTrnHistoryTemp Database connection close \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
            return result;
        }

        public string DeleteDayTrnTemp(int printLog, string logpath,string connectionstring)
        {
            string result = "";
            logfilepath = logpath;
            printlog = printLog;
            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("DeleteDayTrnTempRecords", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("DeleteDayTrnTempRecords Database connection open \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                cmd.ExecuteScalar();
                result = "Records successfully deleted from DayTrnHistoryTemp";

            }
            catch (SqlException s)
            {
                result = "Error deleting data from DayTrnHistoryTemp "+connectionstring+""  + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(" "+result+"\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
            finally
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("DeleteDayTrnTempRecords Database connection close \n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                conn.Close();
            }
            return result;
        }

        public string CheckIfHistoryMoved(string connectionstring)
        {
            string result = "";
            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("CheckTrnRecords", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                cmd.ExecuteScalar();
                cmd.Connection.Close();
                conn.Close();
                result = "Records not in DayTrnHist";
                return result;
            }

            catch (SqlException s)
            {
                result = "Error checking for records in DayTrnHistoryTemp " + s.ToString();
                return result;
            }
            finally
            {
                conn.Close();
            }
        }

        public int CheckForDayTrnRecords(string date, ref int recs, int printLog, string logpath,string connectionstring)
        {
            string result = "";
            int recordCount;

            List<checkdayTrnRecordDateVm> DayTrnFormateList = new List<checkdayTrnRecordDateVm>();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("CheckForDayTrnRecords" , conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@date", date);
                var  count = command.ExecuteScalar();
                recordCount = Convert.ToInt32(count);
                
                return recordCount;
            }
            catch (SqlException s)
            {
                result = "Error checking for records dated " + date + " in the CheckForDayTrnRecords Table. Error: " + s.ToString();
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append(" " + result + "\n");
                    File.AppendAllText(logfilepath, sb.ToString());
                }
            }
            finally
            {
                if (printlog > 0)
                {
                    sb.Clear();
                    sb.Append("------------" + System.DateTime.Now + "-----------\n");
                    sb.Append("CheckForDayTrnRecords database connection close\n" + connectionstring);
                    File.AppendAllText(logfilepath, sb.ToString());
                }
                conn.Close();
            }
            return Convert.ToInt32(result);
        }

        public string DeleteDayTrnRecs(string date,string connectionstring)
        {
            string result = "";
            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("DeleteDayTrnTempRecordsError", conn);
                cmd.CommandTimeout = 36000;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recDate", date);

                conn.Open();
                cmd.ExecuteScalar();
              
                result = "Records successfully deleted from DayTrnHistory";

            }
            catch (SqlException s)
            {
                result = "Error deleting data from DayTrnHistory " + s.ToString();
            }
            finally
            {
                conn.Close();
            }
            return result;
        }




        //internal string GetBillPay(ref DataTable dt, string pd)
        //{
        //    string result = "";
        //    try
        //    {
        //        cmd = new SqlCommand("retrieveAllBillPay", bnk59);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@pdate", Convert.ToInt64(pd));
        //        cmd.CommandTimeout = 600; // allow 10mins for execution
        //        bnk59.Open();
        //        dt.Load(cmd.ExecuteReader());
        //        cmd.Connection.Close();
        //        bnk59.Close();
        //        result = "Bill Pay records successfully retreived";

        //    }
        //    catch (SqlException s)
        //    {
        //        result = "Error retrieving bill pay " + s.ToString();
        //    }
        //    finally
        //    {
        //        db.Close();
        //    }
        //    return result;
        //}
    }
}
