using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10200
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Pymttype { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Cardname { get; set; } = null!;
        public string Rctnccrd { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public decimal Amntpaid { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Expndate { get; set; }
        public string Authcode { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
