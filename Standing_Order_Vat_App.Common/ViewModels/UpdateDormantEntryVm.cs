using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class UpdateDormantEntryVm
    {
        public string AccountNo { get; set; }
        public int RecordId { get; set; }
        public string? BranchName { get; set; }
        public int Reactive_id { get; set; }
        public int Status { get; set; }
    }
}
