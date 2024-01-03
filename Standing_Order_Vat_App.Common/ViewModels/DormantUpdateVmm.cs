using GbRegister.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class DormantUpdateVmm
    {

        public int Report { get; set; }
        public string coreBranch { get; set; }
        public int MyProperty { get; set; }

        public string jobTitle { get; set; }
        [Required]
        public DateTime? dtFrom { get; set; }
        [Required]
        public DateTime? dtTo { get; set; }
        [Required]
        public int status { get; set; }
        [Required]
        public long? AccountNumber { get; set; }
        [Required]
        public int Options { get; set; }
        public string acct { get; set; }
        public string Department { get; set; }
        public virtual List<ForeignCheckStatusVM>? entryStatusVM { get; set; }
        public virtual List<DormantListIncomplete> DormantListIncompletes { get; set; }
        public virtual List<DormantListRecVm> DormantCheckListRecVms { get; set; }
    }
}
