using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm20102
    {
        public string Custnmbr { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public string Userid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Aptodcnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Rlganlos { get; set; }
        public decimal FuncRndAmt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
