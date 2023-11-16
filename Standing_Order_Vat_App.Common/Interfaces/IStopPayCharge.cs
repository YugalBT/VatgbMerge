using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;
namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IStopPayCharge
    {
        List<StopPayCharge_VM> GetCustomerStopPayCharge(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<StopPayCharge_VM_Download> GetCustomerStopPayChargeDawnload(CustomerSummary_VM customerSummary_VM);
        List<StopPayCharge_VM> GetStopPayCharge(Summery_VM summery_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<StopPayCharge_VM_Download> GetStopPayChargeDawnload(Summery_VM summery_VM);

    }

}
