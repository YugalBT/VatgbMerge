using GbRegister.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class DormantUpdateVmm
    {

     public  string coreBranch { get; set; }
    
     public string jobTitle { get; set; }
     public DateTime dtFrom { get; set; } = DateTime.Now;
     public DateTime dtTo { get; set; } = DateTime.Now;
     public int status { get; set; }
     public int AccountNumber { get; set; }
     public int Options { get; set; }
     public string acct { get; set; }
     public string Department { get; set; }
        public virtual List<ForeignCheckStatusVM>? entryStatusVM { get; set; }

     public virtual List<DormantListIncomplete> DormantListIncompletes { get; set; }
      public virtual List<DormantListRecVm> DormantCheckListRecVms { get; set; }
    }
}
