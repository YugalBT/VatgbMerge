using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.CoreData_DB;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;

namespace Standing_Order_Vat_App.Common.Services
{
    public class getTransactionChargesService : ITransactionCharges
    {
        private readonly CoreDataContext coreDataContext;

        public getTransactionChargesService(CoreDataContext coreDataContext)
        {
            this.coreDataContext = coreDataContext;
        }
        public async Task<List<VATOnTrancationCharge_db>> GetVATFraudCharge(Summery_VM summery_VM)
        {
            List<VATOnTrancationCharge_db> record = new List<VATOnTrancationCharge_db>();

            string stDate = String.Format("{0:yyyyMMdd}", summery_VM.dateFrom);
            string endDate = String.Format("{0:yyyyMMdd}", summery_VM.DateTo);

            var datefrom = new SqlParameter("@stDate", stDate);
            var dateTo = new SqlParameter("@endDate", endDate);
            record = await coreDataContext.vatOnTransactionCharge.FromSqlRaw("exec getTransactionChargesForPeriod_Temp @stDate,@endDate", datefrom, dateTo).ToListAsync();
            return record;
        }
    }
}
