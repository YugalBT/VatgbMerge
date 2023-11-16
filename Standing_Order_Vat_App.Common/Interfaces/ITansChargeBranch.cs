using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface ITansChargeBranch
    {
        List<TansChargeBranch_VM> GetCustomerTansChargeBranch(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<TansChargeBranch_VM_Download> GetCustomerTansChargeBranchDawnload(CustomerSummary_VM customerSummary_VM);
        List<TansChargeBranch_VM> GetTansChargeBranch(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<TansChargeBranch_VM_Download> GetTansChargeBranchDawnload(Summery_VM summery_VM);
    }
}
