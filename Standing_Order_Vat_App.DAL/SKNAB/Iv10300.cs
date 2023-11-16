using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10300
    {
        public string Stckcntid { get; set; } = null!;
        public string Stckcntdscrptn { get; set; } = null!;
        public short Stckcntstts { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Cntstrtdt { get; set; }
        public DateTime Cntstrttm { get; set; }
        public byte Atpstvrnc { get; set; }
        public byte Rsstckcnt { get; set; }
        public DateTime Dfltcntdt { get; set; }
        public DateTime Dfltcnttm { get; set; }
        public DateTime Lstcntdt { get; set; }
        public byte Enablemultibin { get; set; }
        public string Locncode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
