using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class FrgnViewCheckVm
    {

        public  DateTime From {  get; set; } = DateTime.Now;
        public DateTime To { get; set; } = DateTime.Now;
        public int Status { get; set; } 
        public int Banks { get; set; } 
        public int Options { get; set; }

        public virtual List<BankListVm>? bankList { get; set; }
        public virtual List<ForeignCheckStatusVM>? entryStatusVM { get; set; }
        public virtual List<FrgnCheckListRecVm> FrgnCheckListRecVms { get; set; }
        public virtual List<frgncheckListIncomplete> FrgncheckListIncompletes { get; set; }

    }
}
