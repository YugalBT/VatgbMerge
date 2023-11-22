using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IFrgnChks
    {
        List<BankListVm> GetBanks();

        public Task<IGeneralResult<string>> AddFrgnCheack(ForeignCheckVm foreignCheckVm);
        public Task<string> UpdateFrgn(ForeignCheckVm model);
        public IEnumerable<string> GetFrgnChksBatchByStatus(int status,string branch);

        public Task<int> SaveFrgnBatch(FrgnCheckVm frgnCheckVm);

        public Task<decimal> GetCheckTotal(int BatchId);
        public List<ForeignChecksDetail> GetAllforeign();

        public Task<string> DeleteFrgnChksBatch(int batchId);

        public Task<string> GetFrgnChksBatchByDate(int status, string branch, DateTime dateFrom, DateTime dateto);
        public Task<string> GetFrgnChksBatchByBank(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);

         public Task<IGeneralResult<DataTable>> GetFrgnChksByBatchID(int batchId);


         Task<List<ForeignCheckStatusVM>> GetEntryStatus();
         Task<IGeneralResult<DataTable>> record(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);  
         Task<IGeneralResult<DataTable>> record1(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);  
         Task<IGeneralResult<DataTable>> record2(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);  

    }
}
