using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag60001
    {
        public string Userid { get; set; } = null!;
        public string Trxbtchsrc { get; set; } = null!;
        public short Series { get; set; }
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
