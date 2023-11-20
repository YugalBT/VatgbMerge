using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IFrgnChks
    {
        List<Bank> GetBanks();

        public Task<string> AddFrgnCheack(ForeignCheckVm foreignCheckVm);
        public Task<string> UpdateFrgn(ForeignCheckVm model);
        public IEnumerable<string> GetFrgnChksBatchByStatus(int status,string branch);

        public Task<ForeignCheckBatchVm> SaveFrgnBatch(FrgnCheckVm frgnCheckVm);

        public List<ForeignChecksDetail> GetAllforeign();

        public Task<string> DeleteFrgnChksBatch(int batchId);

        public Task<string> GetFrgnChksBatchByDate(int status, string branch, DateTime dateFrom, DateTime dateto);
        public Task<string> GetFrgnChksBatchByBank(int status, string branch, int bankId, DateTime dateFrom, DateTime dateTo);

    }
}
