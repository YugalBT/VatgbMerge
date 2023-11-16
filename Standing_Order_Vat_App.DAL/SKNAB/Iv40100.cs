using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40100
    {
        public short Setupkey { get; set; }
        public string Uscatdsc1 { get; set; } = null!;
        public string Uscatdsc2 { get; set; } = null!;
        public string Uscatdsc3 { get; set; } = null!;
        public string Uscatdsc4 { get; set; } = null!;
        public string Uscatdsc5 { get; set; } = null!;
        public string Uscatdsc6 { get; set; } = null!;
        public byte Dcdcradj { get; set; }
        public short Acsgfloc { get; set; }
        public string Mainlocn { get; set; } = null!;
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Nxadjdoc { get; set; } = null!;
        public string Txtrdnum { get; set; } = null!;
        public string Nxtvdnum { get; set; } = null!;
        public string Nxprdnum { get; set; } = null!;
        public byte Aladjovr { get; set; }
        public byte Avarovrd { get; set; }
        public byte Atrsovrd { get; set; }
        public byte Atpstvrnc { get; set; }
        public byte Enablemultibin { get; set; }
        public byte Enpickshorttsk { get; set; }
        public string Userid { get; set; } = null!;
        public byte Disableavgperpadj { get; set; }
        public byte Disableperpadj { get; set; }
        public int DexRowId { get; set; }
    }
}
