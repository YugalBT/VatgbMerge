using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IVATOnFraudCharge
    {
        Task<List<Vat_On_Fraoud_Charge>> GetVATFraudCharge(Summery_VM summery_VM);
    }
}
