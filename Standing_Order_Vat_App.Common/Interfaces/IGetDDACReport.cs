using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IGetDDACReport
    {
        List<DDASCReport_VM> GetCustomerDDASCReport(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<DDASCReport_VM_Download> GetCustomerDDASCReportDawnload(CustomerSummary_VM customerSummary_VM);
        List<DDASCReport_VM> GetDDASCReport(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<DDASCReport_VM_Download> GetDDASCReportDawnload(Summery_VM summery_VM);
    }
}
