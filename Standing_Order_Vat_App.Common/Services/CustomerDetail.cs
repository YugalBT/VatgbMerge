using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;

namespace Standing_Order_Vat_App.Common.Services
{
    public class CustomerDetail : ICustomerdetail
    {
        private readonly Standing_Order_VATContext stopPayCharge;

        public CustomerDetail(Standing_Order_VATContext stopPayCharge)
        {
            this.stopPayCharge = stopPayCharge;
        }
        public List<Customer_VM> GetCustomerDetail(int reportid)
        {
            List<Customer_VM> customers = new List<Customer_VM>();
            switch (reportid)
            {
                case 1:
                    {
                        customers = stopPayCharge.StandingOrders.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = x.Name,
                            Customer = x.Acct + "-" + x.Name
                        }).Distinct().OrderBy(x => x.CustomerName).ToList();
                        break;
                    }
                case 2:
                    {
                        customers = stopPayCharge.Ddascjs.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = x.CustomerName,
                            Customer = x.Acct + "-" + x.CustomerName
                        }).Distinct().OrderBy(x => x.Acct).OrderBy(x => x.CustomerName).ToList();
                        break;
                    }
                case 3:
                    {
                        customers = stopPayCharge.LoanCharges.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = "",
                            Customer = x.Acct
                        }).Distinct().OrderBy(x => x.Acct).ToList();
                        break;
                    }
                case 4:
                    {
                        customers = stopPayCharge.StopCharges.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = "",
                            Customer = x.Acct
                        }).Distinct().OrderBy(x => x.Acct).ToList();
                        break;
                    }
                case 5:
                    {
                        customers = stopPayCharge.TansferCharges.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = x.Cif,
                            Customer = x.Cif + "-" + x.Acct
                        }).Distinct().OrderBy(x => x.Acct).ToList();
                        break;
                    }
                case 6:
                    {
                        customers = stopPayCharge.SafeKeepingPayments.Select(x => new Customer_VM
                        {
                            Acct = x.Acct,
                            CustomerName = x.Cif,
                            Customer = x.Cif + "-" + x.Acct
                        }).Distinct().OrderBy(x => x.Acct).ToList();
                        break;
                    }
            }
            return customers;
        }
    }
}
