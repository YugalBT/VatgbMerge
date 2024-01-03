using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class FrgnCheckListRecVm
    {
        public long BatchId { get; set; }
        public DateTime DatePaymentRequested { get; set; }
        public decimal BatchTotal { get; set; }
        public DateTime DateProcessed  { get; set; }
        public DateTime DateReceived  { get; set; }

        public DateTime DateSettled { get; set; }
        public int BankId { get; set; }
        public string? BankName { get; set; } = null!;
        public int ProcessedBy_ID_Employee { get; set; } 
        public int SettledBy_ID_Employee { get; set; } 
        public string? EntryStatusDescription { get; set; } = null!;
        public string? ProcessName { get; set; } = null!;
        public string? CompName { get; set; } = null!;
    }
}
