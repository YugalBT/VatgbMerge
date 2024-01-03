using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class ForeignCheckvmm
    {
        public int RecordId { get; set; }

        public string CheckNumber { get; set; } = null!;

        public string PayerAcctNumber { get; set; } = null!;

        public string PayerAcctName { get; set; } = null!;

        public string DepositAcctNumber { get; set; } = null!;

        public string DepositAcctName { get; set; } = null!;

        public decimal CheckAmount { get; set; }

        public decimal? TotalAmount { get; set; }
        public int BatchId { get; set; }

        public DateTime? DateRecived { get; set; }

    }
}
