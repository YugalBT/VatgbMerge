using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd007
    {
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public short Dcstatus { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
