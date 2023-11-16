using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IgetSummary
    {

        List<StandingOrder_VM> GetSummaryReport(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage);

        List<StandingOrder_VM_Download> GetSummaryReportDawnload(Summery_VM summery_VM);
        List<StandingOrder_VM_Download> GetCustomerDetailDawnload(CustomerSummary_VM customerSummary_VM);
        List<StandingOrder_VM> GetCustomerDetail(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
    }
}
