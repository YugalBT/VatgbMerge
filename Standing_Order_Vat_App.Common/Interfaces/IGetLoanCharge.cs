using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;
namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IGetLoanCharge
    {
        List<LoanCharge_VM> GetCustomerLoanCharge(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<LoanCharge_VM_Download> GetCustomerLoanChargeDawnload(CustomerSummary_VM customerSummary_VM);
        List<LoanCharge_VM> GetLoanCharge(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<LoanCharge_VM_Download> GetLoanChargeDawnload(Summery_VM summery_VM);
    }
}
