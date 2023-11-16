using Standing_Order_Vat_App.Common.ViewModels;
using System.Runtime.InteropServices;
namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface ISafekeepingPayments
    {
        List<SafekeepingPayment_VM> getCustomerSafekeepingPayments(CustomerSummary_VM customerSummary_VM, [Optional] int pageNum, [Optional] int recordPerPage);
        List<SafekeepingPayment_VM_Download> getCustomerSafekeepingPaymentsDawnload(CustomerSummary_VM customerSummary_VM);
        List<SafekeepingPayment_VM> getSafekeepingPayments(Summery_VM vm, [Optional] int pageNum, [Optional] int recordPerPage);
        List<SafekeepingPayment_VM_Download> getSafekeepingPaymentsDawnload(Summery_VM vm);
    }
}
