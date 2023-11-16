using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pt10000
    {
        public string Projname { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public short Noninven { get; set; }
        public short ProjDistDocSource { get; set; }
        public string Docnumbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public int Dstsqnum { get; set; }
        public DateTime Docdate { get; set; }
        public string Whom { get; set; } = null!;
        public short ProjDistType { get; set; }
        public short ProDistCategory { get; set; }
        public short Incordec { get; set; }
        public decimal Distamnt { get; set; }
        public decimal Quantity { get; set; }
        public short BillableType { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public byte Posted { get; set; }
        public short ProjDistBillStatus { get; set; }
        public string PayCode { get; set; } = null!;
        public decimal Payrate { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
