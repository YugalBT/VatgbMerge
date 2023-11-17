using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

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

        public List<Bank> GetBanks()
        {
            var banks = _sknanbLiveContext.Banks.FromSqlRaw("exec getBank").ToList();
            return banks;
        }
        public async Task <String> AddFrgnCheack(ForeignCheckVm foreignCheckVm)
        {
            var result = "";
            try
            {
                ForeignCheckBatchVm vm = new ForeignCheckBatchVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.CommandText = "NewFrgnChkDetails";
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@btchId", foreignCheckVm.BatchId);
                cmd.Parameters.AddWithValue("@chkNum", foreignCheckVm.CheckNumber);
                cmd.Parameters.AddWithValue("@payAcctNum", foreignCheckVm.PayerAcctNumber);
                cmd.Parameters.AddWithValue("@payAcctName", foreignCheckVm.PayerAcctName);
                cmd.Parameters.AddWithValue("@depAcctNum", foreignCheckVm.DepositAcctNumber);
                cmd.Parameters.AddWithValue("@depAcctName", foreignCheckVm.DepositAcctName);
                cmd.Parameters.AddWithValue("@chkAmt", Convert.ToDouble(foreignCheckVm.CheckAmount));

                conn.Open();
                int i=  cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                 result = "Error saving checks for batch: " + foreignCheckVm.BatchId + ": " + ex.Message;

            }

            finally
            {
               
            }

            return result;
        }

        public async Task<String> UpdateFrgn(ForeignCheckVm model)
        {

         var   result = "Update Successful";
            try
            {
                ForeignCheckBatchVm vm = new ForeignCheckBatchVm();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _generalBankingRegistersContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdFrgnChkDtls";

                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@btchId", Convert.ToInt16(model.BatchId));
                cmd.Parameters.AddWithValue("@chkNum", model.CheckNumber);
                cmd.Parameters.AddWithValue("@payAcctNum", model.PayerAcctNumber);
                cmd.Parameters.AddWithValue("@payAcctName", model.PayerAcctName);
                cmd.Parameters.AddWithValue("@depAcctNum", model.DepositAcctNumber);
                cmd.Parameters.AddWithValue("@depAcctName", model.DepositAcctName);
                cmd.Parameters.AddWithValue("@chkAmt", Convert.ToDouble(model.CheckAmount));
                cmd.Parameters.AddWithValue("@recId", Convert.ToInt16(model.RecordId));

                conn.Open();
                int i = cmd.ExecuteNonQuery();
               var  batchTotal = Convert.ToDecimal(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                result = "Error updating check recordID- " + model.RecordId + ": " + ex.Message;
            }
            finally
            {
                
            }
            return result;
        }

        public IEnumerable<ForeignCheckBatchVm> GetFrgnChksBatchByStatus(int status, string branch)
        {
            List<ForeignCheckBatchVm> foreignCheckBatchVms = new List<ForeignCheckBatchVm>();
            var stat = new SqlParameter("@status", status);
            var branc = new SqlParameter("@branch", branch);
            try
            {
                var data = _generalBankingRegistersContext.ForeignChecksDetails.FromSqlRaw("exec FindFrgnChkBatchByStatus @status,@branch", stat, branc);
            }

            catch (Exception ex)
            {

            }

            return foreignCheckBatchVms;
        }

        public async Task<ForeignCheckBatchVm> SaveFrgnBatch(FrgnCheckVm frgnCheckVm )
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
            vm.BatchId = id;
            return vm;
        }
        public List<ForeignChecksDetail> GetAllforeign()
        {
            List<ForeignChecksDetail> frgn=new List<ForeignChecksDetail>();
            
            return frgn;
        }
    }
    }
    

