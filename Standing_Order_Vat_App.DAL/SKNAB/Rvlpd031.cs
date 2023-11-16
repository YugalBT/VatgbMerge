using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd031
    {
        public string Inqid { get; set; } = null!;
        public short Sortby { get; set; }
        public string PmntDocIdfrom { get; set; } = null!;
        public string PmntDocIdto { get; set; } = null!;
        public byte Workcb1 { get; set; }
        public byte Open1 { get; set; }
        public byte History { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
