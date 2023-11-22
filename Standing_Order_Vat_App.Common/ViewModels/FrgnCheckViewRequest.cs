using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class FrgnCheckViewRequest
    {
        public DateTime From { get; set; } = DateTime.Now;
        public DateTime To { get; set; } = DateTime.Now;
        public int Status { get; set; }
        public int Banks { get; set; }
        public int Options { get; set; }
    }
}
