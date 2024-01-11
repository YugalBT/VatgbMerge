using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Standing_Order_Vat_App.Common.Services
{
    public class FrgnChksService : IFrgnChks
    {

        private readonly SKNANBLIVEContext _sknanbLiveContext;
        private readonly General_Banking_RegistersContext _generalBankingRegistersContext;

        public FrgnChksService(SKNANBLIVEContext sknanbLiveContext, General_Banking_RegistersContext generalBankingRegistersContext)
        {
            _sknanbLiveContext = sknanbLiveContext;
            _generalBankingRegistersContext = generalBankingRegistersContext;
        }

        public List<BankListVm> GetBanks()
        {
            List<BankListVm> list = new List<BankListVm>();

            list = _sknanbLiveContext.Banks.Select(s => new BankListVm()
            {
                BankId = s.BankId,
                BankName = s.Name
            }).Take(100).ToList();
            
            return list;
        }
        public async Task<IGeneralResult<string>> AddFrgnCheack(ForeignCheckVm foreignCheckVm)
        {
            IGeneralResult<string> result = new GeneralResult<string>();
            try
            {
                ForeignCheckBatchVm vm = new ForeignCheckBatchVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "NewFrgnChkDetails_New";
                cmd.Parameters.AddWithValue("@btchId", foreignCheckVm.BatchId);
                cmd.Parameters.AddWithValue("@chkNum", foreignCheckVm.CheckNumber);
                cmd.Parameters.AddWithValue("@payAcctNum", foreignCheckVm.PayerAcctNumber);
                cmd.Parameters.AddWithValue("@payAcctName", foreignCheckVm.PayerAcctName);
                cmd.Parameters.AddWithValue("@depAcctNum", foreignCheckVm.DepositAcctNumber);
                cmd.Parameters.AddWithValue("@depAcctName", foreignCheckVm.DepositAcctName);
                cmd.Parameters.AddWithValue("@chkAmt", Convert.ToDouble(foreignCheckVm.CheckAmount));
                cmd.Parameters.Add("@batchTotal", SqlDbType.Money, 100);
                cmd.Parameters["@batchTotal"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@insertRecordId", SqlDbType.Int, 100);
                cmd.Parameters["@insertRecordId"].Direction = ParameterDirection.Output;

                conn.Open();
                int i = cmd.ExecuteNonQuery();
                var batchTotal = cmd.Parameters["@batchTotal"].Value;
                int insertRecordId = Convert.ToInt32(cmd.Parameters["@insertRecordId"].Value);
                result.Successful = true;
                result.Message = "Data Saved Successfully.";
                result.Value = batchTotal.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                result.Message = "Error saving checks for batch: " + foreignCheckVm.BatchId + ": " + ex.Message;

            }
            return result;
        }

        public async Task<IGeneralResult<string>> UpdateFrgn(ForeignCheckvmm model)
        {
            IGeneralResult<string> result = new GeneralResult<string>();
            try
            {
                ForeignCheckBatchVm vm = new ForeignCheckBatchVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdFrgnChkDtls";
                //cmd.CommandText = "UpdFrgnChkDtls_New";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@btchId", Convert.ToInt32(model.BatchId));
                cmd.Parameters.AddWithValue("@chkNum", model.CheckNumber);
                cmd.Parameters.AddWithValue("@payAcctNum", model.PayerAcctNumber);
                cmd.Parameters.AddWithValue("@payAcctName", model.PayerAcctName);
                cmd.Parameters.AddWithValue("@depAcctNum", model.DepositAcctNumber);
                cmd.Parameters.AddWithValue("@depAcctName", model.DepositAcctName);
                cmd.Parameters.AddWithValue("@chkAmt", Convert.ToDouble(model.CheckAmount));
                cmd.Parameters.AddWithValue("@recId", Convert.ToInt32(model.RecordId));
                //cmd.Parameters.Add("@btchTotal", SqlDbType.Money, 100);
                //cmd.Parameters["@btchTotal"].Direction = ParameterDirection.Output;
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                var batchTotal = Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
                result.Successful = true;
                result.Message = "Data Updated Successfully.";
                result.Value = batchTotal.ToString();
            }
            catch (SqlException ex)
            {
                result.Message = "Error updating check recordID " + model.RecordId + ": " + ex.Message;
            }

            return result;
        }

        public IEnumerable<string> GetFrgnChksBatchByStatus(int status, string branch)
        {
            var result = "success";
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                using (conn)
                {
                    cmd.CommandText = "FindFrgnChkBatchByStatus";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@branch", branch);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                }
            }
            catch (SqlException ex)
            {
                result = "Error retreiving batch by stats: " + status + ": " + ex.Message;
            }
            finally
            {

            }
            yield return result;
        }

        public async Task<int> SaveFrgnBatch(FrgnCheckVm frgnCheckVm)
        {
            ForeignCheckBatchVm vm = new ForeignCheckBatchVm();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CreateNewFrgnChkBtch";
            cmd.Parameters.AddWithValue("@bankId", frgnCheckVm.bankId);
            cmd.Parameters.AddWithValue("@dtRecvd", frgnCheckVm.dtRecvd);
            cmd.Parameters.AddWithValue("@empId", frgnCheckVm.empId);
            cmd.Parameters.AddWithValue("@btchStatId", frgnCheckVm.batchStat);
            cmd.Parameters.AddWithValue("@branch", frgnCheckVm.branch);
            cmd.Parameters.AddWithValue("@dateProcessed", frgnCheckVm.dtRecvd);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar, 100);
            cmd.Parameters["@Id"].Direction = ParameterDirection.Output;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd.Parameters["@Id"].Value);
            conn.Close();
            //vm.BatchId = id;
            return id;
        }

        public async Task<decimal> GetCheckTotal(int BatchId)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertFrgnChkBtchTotal_New";
            cmd.Parameters.AddWithValue("@batchId", BatchId);
            cmd.Parameters.Add("@total", SqlDbType.Money, 100);
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            var BatchTotal = cmd.Parameters["@total"].Value;
            conn.Close();
            return (decimal)BatchTotal;
        }
        public List<ForeignChecksDetail> GetAllforeign()
        {
            List<ForeignChecksDetail> frgn = new List<ForeignChecksDetail>();

            return frgn;
        }

        public async Task<IGeneralResult<string>> DeleteFrgnChksBatch(int batchId)
        {
            IGeneralResult<string> res = new GeneralResult<string>();

            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DelFrgnChkBatchAndChks";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@batchId", batchId);

                conn.Open();
                cmd.ExecuteNonQuery();

                res.Successful = true;
                res.Message = "Record deleted successfully.";


            }
            catch (Exception ex)
            {
                res.Message = "Error deleting batch id = " + batchId + ": " + ex.Message;
            }

            return res;
        }
        public async Task<string> GetFrgnChksBatchByDate(int status, string branch, DateTime dateFrom, DateTime dateTo)
        {
            var result = "success";

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                using (conn)
                {
                    cmd.CommandText = "FindFrgnChkBatchByDate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@branch", branch);
                    cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@dateTo", dateTo);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                }
            }
            catch (SqlException ex)
            {
                result = "Error retreiving batch by stats: " + status + ": " + ex.Message;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return result;
        }
        //Findfrgncheckbatchbybank
        public async Task<string> GetFrgnChksBatchByBank(Getfrgncheckvm getfrgncheckvm)
        {
            var result = "success";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                using (conn)
                {
                    cmd.CommandText = "FindFrgnChkBatchByBank";

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@status", getfrgncheckvm.status);
                    cmd.Parameters.AddWithValue("@branch", getfrgncheckvm.branch);
                    cmd.Parameters.AddWithValue("@bankId", getfrgncheckvm.bankId);
                    cmd.Parameters.AddWithValue("@dateFrom", getfrgncheckvm.dateFrom);
                    cmd.Parameters.AddWithValue("@dateTo", getfrgncheckvm.dateTo);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                }
            }
            catch (SqlException ex)
            {
                result = "Error retreiving batch by bank: " + getfrgncheckvm.bankId + ": " + ex.Message;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return result;
        }
        public async Task<IGeneralResult<DataTable>> GetFrgnChksByBatchID(int batchId)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            var connString = _generalBankingRegistersContext.Database.GetDbConnection();
            using (var cmd = _generalBankingRegistersContext.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "GetFrgnChkDetailsByBatchId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@batchId", batchId));
                    cmd.CommandTimeout = 600;
                    DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                    var dataTable = new DataTable();
                    adp.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        result.Successful = true;
                        result.Message = "Data Saved Successfully.";
                        result.Value = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    result.Message = "Error retreiving checks for batch: " + batchId + ": " + ex.Message;
                }
                return result;
            }
        }
        public IGeneralResult<string> UpdateDatePaymentRequest(UpdateDatePaymentVm vm)
        {
            IGeneralResult<string> res = new GeneralResult<string>();
            if (vm.BatchId > 0 && vm.BatchId != null)
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    using (conn)
                    {
                        cmd.CommandText = "UpdFrgnChkBtchHdr";

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@batchId", Convert.ToInt32(vm.BatchId));
                        cmd.Parameters.AddWithValue("@dtSent", Convert.ToDateTime(vm.DatePaymentRequest));

                        if (conn.State != ConnectionState.Open)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        res.Successful = true;
                        res.Message = "Data updated successfully.";
                    }
                }
                catch (SqlException ex)
                {
                    res.Message = "Error saving settlement details for batch : " + vm.BatchId + ": " + ex.Message;
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
            else
            {
                res.Message = "Invalid data.";
            }
            return res;
        }
        public async Task<List<ForeignCheckStatusVM>> GetEntryStatus()
        {
            List<ForeignCheckStatusVM> rec = new List<ForeignCheckStatusVM>();
            rec = await _generalBankingRegistersContext.EntryStatuses.Select(s => new ForeignCheckStatusVM()
            {
                StatusId = s.EntryStatusId,
                StatusName = s.EntryStatusDescription
            }).ToListAsync();
            return rec;
        }


        public async Task<IGeneralResult<DataTable>> record(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            var connString = _generalBankingRegistersContext.Database.GetDbConnection();
            using (var cmd = _generalBankingRegistersContext.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "FindFrgnChkBatchByBank";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@status", status));
                    cmd.Parameters.Add(new SqlParameter("@branch", branch));
                    cmd.Parameters.Add(new SqlParameter("@bankId", bankId));
                    cmd.Parameters.Add(new SqlParameter("@dateFrom", dateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateTo", dateTo));

                    cmd.CommandTimeout = 6000;
                    DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                    var dataTable = new DataTable();
                    adp.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        result.Successful = true;
                        result.Message = "Data Saved Successfully.";
                        result.Value = dataTable;
                    }


                }
                catch (Exception ex)
                {
                    result.Message = "Error retreiving checks for batch: " + branch + ": " + ex.Message;
                }
            }
            return result;
        }


        public async Task<IGeneralResult<DataTable>> record1(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            var connString = _generalBankingRegistersContext.Database.GetDbConnection();
            using (var cmd = _generalBankingRegistersContext.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "FindFrgnChkBatchByDate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@status", status));
                    cmd.Parameters.Add(new SqlParameter("@branch", branch));
                    cmd.Parameters.Add(new SqlParameter("@dateFrom", dateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateTo", dateTo));

                    cmd.CommandTimeout = 6000;
                    DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                    var dataTable = new DataTable();
                    adp.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        result.Successful = true;
                        result.Message = "Data Saved Successfully.";
                        result.Value = dataTable;
                    }


                }
                catch (Exception ex)
                {
                    result.Message = "Error retreiving checks for batch: " + branch + ": " + ex.Message;
                }
            }
            return result;
        }



        public async Task<IGeneralResult<DataTable>> record2(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo)
        {
            IGeneralResult<DataTable> result = new GeneralResult<DataTable>();
            var connString = _generalBankingRegistersContext.Database.GetDbConnection();
            using (var cmd = _generalBankingRegistersContext.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "FindFrgnChkBatchByStatus_New";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@status", status));
                    cmd.Parameters.Add(new SqlParameter("@branch", branch));

                    cmd.CommandTimeout = 6000;
                    DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                    var dataTable = new DataTable();
                    adp.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        result.Successful = true;
                        result.Message = "Data Saved Successfully.";
                        result.Value = dataTable;
                    }


                }
                catch (Exception ex)
                {
                    result.Message = "Error retreiving checks for batch: " + branch + ": " + ex.Message;
                }
            }
            return result;
        }



    }
}




 

