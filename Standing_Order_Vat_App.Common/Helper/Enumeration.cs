using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Helper
{
    public class Enumeration
    {
        public enum ApplicationAccess
        {
            [Display(Name = "Vat")]
            Vat,
            [Display(Name = "Foreign Check")]
            Foreign_Check
        }
        public enum FolderEnum
        {
            dda = 1,
            lon = 2,
            misc = 4,
            sav = 3,
        }
    }
}
