using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag2000t
    {
        public byte Voided { get; set; }
        public int Dstsqnum { get; set; }
        public int Actindx { get; set; }
        public short Accttype { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string DistRef { get; set; } = null!;
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public int DexRowId { get; set; }
    }
}
