using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class DormantRegisterService : IDormantRegister
    {
        

        private readonly General_Banking_RegistersContext _generalBankingRegistersContext;
        private readonly IAccountRepo accountRepo;
        string genBnkRegConStr;


        public DormantRegisterService(General_Banking_RegistersContext generalBankingRegistersContext, IAccountRepo accountRepo )
        {
            _generalBankingRegistersContext = generalBankingRegistersContext;
            this.accountRepo = accountRepo;
            genBnkRegConStr = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
        }

        public IGeneralResult<string> AddDormantRegister(VmDormantRegister dormantRegister)
        {

            IGeneralResult<string> result = new GeneralResult<string>();
            try
            {
                VmDormantRegister vm = new VmDormantRegister();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "NewDormantEntry_New";
                cmd.Parameters.AddWithValue("@date", dormantRegister.DateRequested);
                cmd.Parameters.AddWithValue("@acctNum", dormantRegister.AcctNumber);
                cmd.Parameters.AddWithValue("@name", dormantRegister.Name);
                cmd.Parameters.AddWithValue("@acctType", dormantRegister.AcctType);
                cmd.Parameters.AddWithValue("@particulars", dormantRegister.Particulars);
                cmd.Parameters.AddWithValue("@acctStat", dormantRegister.AcctStatus);
                cmd.Parameters.AddWithValue("@intIDEmp", accountRepo.GetEmpId());
                cmd.Parameters.AddWithValue("@entryStatusId", 1);
                cmd.Parameters.AddWithValue("@coreBrNum", dormantRegister.CoreBranchNumber);
                cmd.Parameters.AddWithValue("@deptId", dormantRegister.IssuingDeptId);
                conn.Open();
                string i = (cmd.ExecuteScalar()).ToString();
                result.Successful = true;
                result.Message = "Data Saved Successfully.";

                conn.Close();
            }
            catch (Exception ex)
            {
                result.Message = "Error saving new entry for Dormant Registry: " + ex.Message;
            }
            return result;
        }
        public IGeneralResult<DataTable> GetDormRegRecsByAcctNum( string acct, string coreBranch, int entry, string jobTitle,string dep)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DbConnection genBnkRegConDbconn = _generalBankingRegistersContext.Database.GetDbConnection();
                conn.ConnectionString = genBnkRegConStr;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                
                if (entry == 1)
                    cmd.CommandText = "FindAllIncompleteDormantEntryByAcctNum";
                else
                    cmd.CommandText = "FindAllCompletedDormantEntryByAcctNum";
               
                cmd.Parameters.AddWithValue("@acctNum", acct);
                cmd.Parameters.AddWithValue("@userBranch", coreBranch);
                cmd.Parameters.AddWithValue("@title", jobTitle);
                cmd.Parameters.AddWithValue("@dept", dep);
                conn.Open();

                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    result.Successful = true;
                    result.Message = "Data Fethed Successfully.";
                    result.Value = dataTable;
                }
            }
            catch (Exception ex)
            {
                result.Message = "Error retrieving Dormant Registry entries by account number " + ex.Message;
            }
            return result;
        }
        public IGeneralResult<DataTable> GetDormRegRecsByDate( DateTime? dtFrom, DateTime? dtTo, string coreBranch, int entry, string jobTitle)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DbConnection genBnkRegConDbconn = _generalBankingRegistersContext.Database.GetDbConnection();
                conn.ConnectionString = genBnkRegConStr;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                if (entry == 1)
                    cmd.CommandText = "FindIncompleteDormantEntryByDate";
                else
                    cmd.CommandText = "FindCompletedDormantEntryByDate";

                cmd.Parameters.AddWithValue("@dateFrom", dtFrom);
                cmd.Parameters.AddWithValue("@dateTo", dtTo);
                cmd.Parameters.AddWithValue("@userBranch", coreBranch);
                cmd.Parameters.AddWithValue("@title", jobTitle);

                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    result.Successful = true;
                    result.Message = "Data Fethed Successfully.";
                    result.Value = dataTable;
                }
            }
            catch (Exception ex)
            {
                result.Message = "Error retrieving Dormant Registry entries by account number " + ex.Message;
            }
            return result;
        }
        public IGeneralResult<DataTable> GetDormRegRecsByStatus( int status, string coreBranch, string jobTitle)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                DbConnection genBnkRegConDbconn = _generalBankingRegistersContext.Database.GetDbConnection();
                conn.ConnectionString = genBnkRegConStr;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FindDormantEntryByStatus";
                cmd.Parameters.AddWithValue("@status", status);

                cmd.Parameters.AddWithValue("@userBranch", coreBranch);
                cmd.Parameters.AddWithValue("@title", jobTitle);
                conn.Open();
                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    result.Successful = true;
                    result.Message = "Data fetch Successfully.";
                    result.Value = dataTable;
                }
            }
            catch (Exception ex)
            {
                result.Message = "Error retrieving Dormant Registry entries by account number " + ex.Message;
            }
            return result;

        }
        public IGeneralResult<Accountinfo> GetAcctCoreInfo(ref Accountinfo vm, string acct)
        {
            IGeneralResult<Accountinfo> result = new GeneralResult<Accountinfo>();
            try
            {
                if (string.IsNullOrEmpty(acct))
                {
                    result.Message = "Invalid account number.";
                }
                else
                {
                    var dataTable = new DataTable();

                    SqlConnection conn = new SqlConnection();
                    SqlCommand command = new SqlCommand();
                    conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetCoreInfo";
                    command.Parameters.AddWithValue("@acct", acct);
                    conn.Open();
                    command.CommandTimeout = 600;
                    //command.ExecuteNonQuery();
                    DbDataAdapter adp = DataAdapterUD.CreateDataAdapter(conn, command);

                    adp.Fill(dataTable);
                    conn.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        vm.Name = dataTable.Rows[0]["Name"].ToString();
                        vm.BranchNumber = dataTable.Rows[0]["BranchNumber"].ToString();
                        vm.AccountType = dataTable.Rows[0]["AccountType"].ToString();
                        vm.AccountStatus = dataTable.Rows[0]["AccountStatus"].ToString();
                        result.Successful = true;
                        result.Message = "Data fetch Successfully.";
                        result.Value = vm;
                    }
                    else
                    {
                        result.Message = "Error, no such account was found, please verify and reenter.";

                    }
                }
            }

            catch (SqlException ex)
            {
                result.Message = "Error retrieving the branch number for account " + acct + ": " + ex.Message;
            }
            return result;
        }
        public async Task<IGeneralResult<string>> DeleteDormant(int id)
        {
            IGeneralResult<string> res = new GeneralResult<string>();
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
                cmd.Connection = conn;
                cmd.CommandText = "DelDormantEntry";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recId", id);

                conn.Open();
                cmd.ExecuteNonQuery();

                res.Successful = true;
                res.Message = "Record deleted successfully.";
            }
            catch (Exception ex)
            {
                res.Message = "Error deleting dormant entry record id = " + id + ": " + ex.Message;
            }
            return res;
        }

        public IGeneralResult<string> UpdateDormRegRecs(UpdateDormantEntryVm vm)
        {
            IGeneralResult<string> result = new GeneralResult<string>();
            if (vm != null && vm.RecordId > 0 && Convert.ToInt64(vm.AccountNo) > 0)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    conn.ConnectionString = genBnkRegConStr;
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdDormantRegistry";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@reactId", Convert.ToInt32(vm.Reactive_id));
                    cmd.Parameters.AddWithValue("@entryStatId", Convert.ToInt32(vm.Status));
                    cmd.Parameters.AddWithValue("@recid", Convert.ToInt32(vm.RecordId));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result.Message = "Record updated.";
                }
                catch (SqlException ex)
                {
                    result.Message = "Error updating Dormant Registry recordID " + vm.RecordId + ":" +
                         ex.Message;
                }
            }
            else
            {
                result.Message = "Record not found.";
            }
            return result;
        }
    }
}

