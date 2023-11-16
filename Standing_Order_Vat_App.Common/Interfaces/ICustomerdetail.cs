using Standing_Order_Vat_App.Common.ViewModels;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface ICustomerdetail
    {
        List<Customer_VM> GetCustomerDetail(int reportid);
    }
}
