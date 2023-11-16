using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30700
    {
        public string Stckcntid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Stckcntdscrptn { get; set; } = null!;
        public DateTime Cntstrtdt { get; set; }
        public DateTime Cntstrttm { get; set; }
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Docdate { get; set; }
        public int DexRowId { get; set; }
    }
}
