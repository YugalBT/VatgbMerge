using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr19900
    {
        public byte Istippay { get; set; }
        public int Actindx { get; set; }
        public decimal Acctamnt { get; set; }
        public short Accttype { get; set; }
        public string Statecd { get; set; } = null!;
        public string Payrcord { get; set; } = null!;
        public short Paytype { get; set; }
        public decimal Groswags1 { get; set; }
        public decimal Groswags2 { get; set; }
        public decimal Groswags3 { get; set; }
        public decimal Groswags4 { get; set; }
        public decimal Groswags5 { get; set; }
        public decimal Groswags6 { get; set; }
        public decimal Groswags7 { get; set; }
        public decimal Groswags8 { get; set; }
        public decimal Groswags9 { get; set; }
        public decimal Groswags10 { get; set; }
        public decimal Groswags11 { get; set; }
        public decimal Groswags12 { get; set; }
        public short Ffedtxrt { get; set; }
        public short Flsttxrt { get; set; }
        public int DexRowId { get; set; }
    }
}
