using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.MvcHelper
{
    public class Enumration
    {
        public enum ApplicationAccess
        {
            [Display(Name ="Vat")]
            Vat,
            [Display(Name = "Foreign Check")]
            Foreign_Check
        }
    }
}
