using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm30401
    {
        public string ScheduleNumber { get; set; } = null!;
        public string ScheduleDesc { get; set; } = null!;
        public string OrigDocNumber { get; set; } = null!;
        public short OrigDocType { get; set; }
        public string OrigVoucherNum { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public DateTime SchDocDate { get; set; }
        public decimal ScheduleAmount { get; set; }
        public decimal FuncSchAmnt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short ScheduleIntType1 { get; set; }
        public int ScheduleIntRate { get; set; }
        public short NumPayments { get; set; }
        public short PymntFrequency { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime FirstInvDocDate { get; set; }
        public DateTime FirstInvDueDate { get; set; }
        public int PayAcctIdx { get; set; }
        public int PayOffsetAcctIdx { get; set; }
        public int IntExpAcctIdx { get; set; }
        public decimal Noteindx { get; set; }
        public short Status { get; set; }
        public string CreditMemoDocNum { get; set; } = null!;
        public string Vadcdtro { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
