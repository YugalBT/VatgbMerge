using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext00150
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public string PtUdKey { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Userid { get; set; } = null!;
        public short NoteType { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
