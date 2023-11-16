using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class ForeignChecksDetail
    {
       
        public long RecordId { get; set; }
        public string CheckNumber { get; set; } = null!;
        public string PayerAcctNumber { get; set; } = null!;
        public string PayerAcctName { get; set; } = null!;
        public string DepositAcctNumber { get; set; } = null!;
        public string DepositAcctName { get; set; } = null!;
        public decimal CheckAmount { get; set; }
        public long BatchId { get; set; }
        public virtual ForeignChecksBatch Batch { get; set; } = null!;
    }
}
