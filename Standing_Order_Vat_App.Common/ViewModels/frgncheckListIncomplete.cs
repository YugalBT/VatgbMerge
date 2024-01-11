using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class frgncheckListIncomplete
    {
        public long BatchId { get; set; }
        [Required]
        public DateTime? DatePaymentRequested { get; set; }
        
        public DateTime DateProcessed { get; set; }
        public DateTime DateReceived { get; set; }
        public decimal BatchTotal { get; set; }
        public int BankId { get; set; }
        public string? BankName { get; set; } = null!;
        public int ProcessedBy_ID_Employee { get; set; }
        public string? EntryStatusDescription { get; set; } = null!;
        public string? ProcessName { get; set; } = null!;
        
    }
}
