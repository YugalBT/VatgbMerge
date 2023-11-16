using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30702
    {
        public int Rnnmbr { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Currnidx { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Docprfix { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docdescr { get; set; } = null!;
        public string Pordnmbr { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public string CreditAmountString30 { get; set; } = null!;
        public decimal Debitamt { get; set; }
        public decimal Balncdue { get; set; }
        public short Agngbukt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Chcumnum { get; set; } = null!;
        public string Chcumnam { get; set; } = null!;
        public decimal Curtrxam { get; set; }
        public decimal Amntpaid { get; set; }
        public int DexRowId { get; set; }
    }
}
