using GbRegister.Core.ViewModel;
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
        public async Task<ForeignCheckVm> AddFrgnCheack(ForeignCheckVm foreignCheckVm)
        {

            ForeignCheckVm dormantRegisters = new ForeignCheckVm();

            var btchId = new SqlParameter("@btchId", foreignCheckVm.BatchId);
            var chkNum = new SqlParameter("@chkNum", foreignCheckVm.CheckNumber);
            var payAcctNum = new SqlParameter("@payAcctNum", foreignCheckVm.PayerAcctNumber);
            var payAcctName = new SqlParameter("@payAcctName", foreignCheckVm.PayerAcctName);
            var depAcctNum = new SqlParameter("@depAcctNum", foreignCheckVm.DepositAcctNumber);
            var depAcctName = new SqlParameter("@depAcctName", foreignCheckVm.DepositAcctName);
            var chkAmt = new SqlParameter("@chkAmt", foreignCheckVm.CheckAmount);
            try
            {

                var data = _generalBankingRegistersContext.ForeignChecksDetails.FromSqlRaw("exec NewFrgnChkDetails @btchId,@chkNum,@payAcctNum,@payAcctName,@depAcctNum,@depAcctName,@chkAmt", btchId, chkNum, payAcctNum, payAcctName, depAcctNum, depAcctName, chkAmt);

            }

            catch (Exception ex)
            {

            }

            return foreignCheckVm;

        }

        public ForeignCheckVm UpdateFrgn(ForeignCheckVm model)
        {
           
            ForeignCheckVm dormantRegisters = new ForeignCheckVm();
            var recId = new SqlParameter("@recId", model.RecordId);
            var chkNum = new SqlParameter("@chkNum", model.CheckNumber);
            var chkAmt = new SqlParameter("@chkAmt", model.CheckAmount);
            var payAcctNum = new SqlParameter("@payAcctNum", model.PayerAcctNumber);
            var payAcctName = new SqlParameter("@payAcctName", model.PayerAcctName);
            var depAcctNum = new SqlParameter("@depAcctNum", model.DepositAcctNumber);
            var depAcctName = new SqlParameter("@depAcctName", model.DepositAcctName);
            var btchId = new SqlParameter("@btchId", model.BatchId);

            try
            {
                 var data = _generalBankingRegistersContext.ForeignChecksDetails.FromSqlRaw("exec UpdFrgnChkDtls @recId,@chkNum,@chkAmt,@payAcctNum,@payAcctName,@depAcctNum,@depAcctName,@btchId", recId, chkNum, chkAmt, payAcctNum, payAcctName, depAcctNum, depAcctName, btchId);
            }

            catch (Exception ex)
            {

            }

            return model;
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
    

