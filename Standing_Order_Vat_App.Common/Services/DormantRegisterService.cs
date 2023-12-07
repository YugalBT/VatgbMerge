using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.GeneralResult;
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
        //string dtable;

        private readonly General_Banking_RegistersContext _generalBankingRegistersContext;
        private string genBnkRegConStr;
        private DbConnection genBnkRegConDbconn;

        public DormantRegisterService(General_Banking_RegistersContext generalBankingRegistersContext)
        {
            _generalBankingRegistersContext = generalBankingRegistersContext;
            genBnkRegConDbconn = _generalBankingRegistersContext.Database.GetDbConnection();
            genBnkRegConStr = genBnkRegConDbconn.ConnectionString;
        }

        public async Task<IGeneralResult<string>> AddDormantRegister(VmDormantRegister dormantRegister)
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
                cmd.Parameters.AddWithValue("@intIDEmp", dormantRegister.InitialIdEmployee);
                cmd.Parameters.AddWithValue("@entryStatusId", dormantRegister.EntryStatusId);
                cmd.Parameters.AddWithValue("@coreBrNum", dormantRegister.CoreBranchNumber);
                cmd.Parameters.AddWithValue("@deptId", dormantRegister.InitialIdEmployee);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
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
        public IGeneralResult<DataTable> GetDormRegRecsByAcctNum(ref DataTable dtable, string acct, string coreBranch, int entry, string jobTitle)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
                cmd.CommandType = CommandType.StoredProcedure;
                if (entry == 1)
                    cmd.CommandText = "FindAllIncompleteDormantEntryByDate";
                else
                    cmd.CommandText = "FindAllCompletedDormantEntryByDate";
                cmd.CommandText = "FindAllCompletedDormantEntryByAcctNum";
                cmd.Parameters.AddWithValue("@acctNum", acct);
                cmd.Parameters.AddWithValue("@userBranch", coreBranch);
                cmd.Parameters.AddWithValue("@title", jobTitle);

                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
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
        public IGeneralResult<DataTable> GetDormRegRecsByDate(ref DataTable dtable, DateTime? dtFrom, DateTime? dtTo, string coreBranch, int entry, string jobTitle)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
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
        public IGeneralResult<DataTable> GetDormRegRecsByStatus(ref DataTable dtable, int status, string coreBranch, string jobTitle)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            try
            {
                DormantAllAccountVm vm = new DormantAllAccountVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FindDormantEntryByStatus";
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@userBranch", coreBranch);
                cmd.Parameters.AddWithValue("@title", jobTitle);

                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
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
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = genBnkRegConStr;
                cmd.CommandText = "GetCoreInfo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@acct", acct);
                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(genBnkRegConDbconn, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
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
            
            catch (SqlException ex)
            {
                result.Message = "Error retrieving the branch number for account " + acct + ": " + ex.Message;
            }
            return result;
        }
    }
}

