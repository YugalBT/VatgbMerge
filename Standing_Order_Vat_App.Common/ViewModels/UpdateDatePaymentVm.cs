using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class UpdateDatePaymentVm
    {
        public int BatchId { get; set; }
        public DateTime DatePaymentRequest { get; set; }
    }
}
