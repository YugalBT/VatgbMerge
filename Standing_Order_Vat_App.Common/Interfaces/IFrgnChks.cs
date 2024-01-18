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

        Task<IGeneralResult<string>> AddFrgnCheack(ForeignCheckVm foreignCheckVm);
        Task<IGeneralResult<string>> AddBatchSettlementDetails(AddCheckSettlementDetailVm addCheckSettlementDetailVm);

        
        Task<IGeneralResult<string>> UpdateFrgn(ForeignCheckvmm model);
        IGeneralResult<string> UpdateDatePaymentRequest(UpdateDatePaymentVm vm);
        IEnumerable<string> GetFrgnChksBatchByStatus(int status, string branch);
        IGeneralResult<DataTable> GetBatchSettlementDetails(int batchid);
        Task<IGeneralResult<string>> CompleteSettleBatch(List<string> batches);
        Task<int> SaveFrgnBatch(FrgnCheckVm frgnCheckVm);
        Task<decimal> GetCheckTotal(int BatchId);
        List<ForeignChecksDetail> GetAllforeign();
        Task<IGeneralResult<string>> DeleteFrgnChksBatch(int batchId);
        Task<string> GetFrgnChksBatchByDate(int status, string branch, DateTime dateFrom, DateTime dateto);
        Task<string> GetFrgnChksBatchByBank(Getfrgncheckvm getfrgncheckvm);
        Task<IGeneralResult<DataTable>> GetFrgnChksByBatchID(int batchId);
        Task<List<ForeignCheckStatusVM>> GetEntryStatus();
        Task<IGeneralResult<DataTable>> record(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);
        Task<IGeneralResult<DataTable>> record1(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);
        Task<IGeneralResult<DataTable>> record2(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);

    }
}
