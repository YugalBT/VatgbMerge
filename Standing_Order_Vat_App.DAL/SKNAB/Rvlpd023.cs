using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd023
    {
        public string Cntrlnum { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public string Pmtdocid { get; set; } = null!;
        public short Dcstatus { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
