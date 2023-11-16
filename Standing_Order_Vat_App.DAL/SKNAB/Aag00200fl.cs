using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00200fl
    {
        public int Actindx { get; set; }
        public string Actnumbr1 { get; set; } = null!;
        public string Actnumbr2 { get; set; } = null!;
        public string Actnumbr3 { get; set; } = null!;
        public string Actnumbr4 { get; set; } = null!;
        public string Actnumbr5 { get; set; } = null!;
        public string Actnumbr6 { get; set; } = null!;
        public string Actnumbr7 { get; set; } = null!;
        public string Actnumbr8 { get; set; } = null!;
        public string Actnumbr9 { get; set; } = null!;
        public string Actnumbr10 { get; set; } = null!;
        public string Actdescr { get; set; } = null!;
        public short Accttype { get; set; }
        public byte Active { get; set; }
        public int AaAcctClassId { get; set; }
        public string? AaAccountClass { get; set; }
        public string? AaAcctClassDescr { get; set; }
        public string AaNode { get; set; } = null!;
        public byte AaTreeMain { get; set; }
        public int DexRowId { get; set; }
        public string StrAccountNumber { get; set; } = null!;
        public short Pstngtyp { get; set; }
        public string? AaDescr { get; set; }
        public string Dscriptn { get; set; } = null!;
    }
}
