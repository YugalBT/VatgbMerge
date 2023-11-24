using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class Getfrgncheckvm
    {
        public int status { get; set; }
        public string branch { get; set; }
        public int bankId { get; set; }
        public DateTime dateFrom { get; set; }
        public DateTime dateTo  { get; set; }
    }
}
