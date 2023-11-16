using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm20401
    {
        public string ScheduleNumber { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short SchedulePaymentNumber { get; set; }
        public string Custnmbr { get; set; } = null!;
        public decimal PaymentAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal PrincipalAmount { get; set; }
        public decimal PrincipalBalance { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Docdate { get; set; }
        public short Status { get; set; }
        public byte Marked { get; set; }
        public string Mkdbyusr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
