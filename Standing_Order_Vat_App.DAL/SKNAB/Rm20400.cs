using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm20400
    {
        public string ScheduleNumber { get; set; } = null!;
        public string ScheduleDesc { get; set; } = null!;
        public string OrigDocNumber { get; set; } = null!;
        public short OrigDocType { get; set; }
        public string Custnmbr { get; set; } = null!;
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
        public int RecAcctIdx { get; set; }
        public int RecOffsetAcctIdx { get; set; }
        public int IntIncomeAcctIdx { get; set; }
        public string CreditMemoDocNum { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
