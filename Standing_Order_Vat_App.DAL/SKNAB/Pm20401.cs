using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm20401
    {
        public string ScheduleNumber { get; set; } = null!;
        public short SchedulePaymentNumber { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public decimal PaymentAmount { get; set; }
        public string Vendorid { get; set; } = null!;
        public decimal InterestAmount { get; set; }
        public decimal PrincipalAmount { get; set; }
        public decimal PrincipalBalance { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public short Status { get; set; }
        public byte Marked { get; set; }
        public string Mkdbyusr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
