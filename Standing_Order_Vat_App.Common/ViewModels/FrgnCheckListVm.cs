using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class FrgnCheckListVm
    {
        public long RecordId { get; set; } 
        public string CheckNumber { get; set; } = null!;
        public string PayerAcctNumber { get; set; } = null!;
        public string PayerAcctName { get; set; } = null!;
        public string DepositAcctNumber { get; set; } = null!;
        public string DepositAcctName { get; set; } = null!;
        public decimal CheckAmount { get; set; }
        public int BatchId { get; set; }
    }
}
