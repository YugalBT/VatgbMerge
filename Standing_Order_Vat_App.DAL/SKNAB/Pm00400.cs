using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00400
    {
        public string Cntrlnum { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public short Dcstatus { get; set; }
        public short Doctype { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public DateTime Duedate { get; set; }
        public DateTime Discdate { get; set; }
        public string Bchsourc { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
