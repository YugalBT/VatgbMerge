using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.CoreData_DB;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.Data;

namespace Standing_Order_Vat_App.Common.Services
{
    public class getVATOnFraudCharge : IVATOnFraudCharge
    {
        private readonly CoreDataContext _coreDataContext;

        public getVATOnFraudCharge(CoreDataContext coreDataContext)
        {
            _coreDataContext = coreDataContext;
        }
        public async Task<List<Vat_On_Fraoud_Charge>> GetVATFraudCharge(Summery_VM summery_VM)
        {
            List<Vat_On_Fraoud_Charge> record = new List<Vat_On_Fraoud_Charge>();

            string stDate = String.Format("{0:yyyyMMdd}", summery_VM.dateFrom);
            string endDate = String.Format("{0:yyyyMMdd}", summery_VM.DateTo);
            SqlConnection conn = new SqlConnection();
            SqlCommand command = new SqlCommand();
            conn.ConnectionString = _coreDataContext.Database.GetDbConnection().ConnectionString;
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "getFraudChargesForPeriod_Temp";
            var datefrom = new SqlParameter("@stDate", stDate);
            var dateTo = new SqlParameter("@endDate", endDate);
            conn.Open();
            command.CommandTimeout = 600;
            // record = await _coreDataContext.vatOnFraudCharge.FromSqlRaw("exec getFraudChargesForPeriod_Temp @stDate,@endDate", datefrom, dateTo).ToListAsync();
            return record;
        }
    }
}   
