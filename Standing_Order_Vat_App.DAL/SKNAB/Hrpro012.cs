using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpro012
    {
        public string EmpidI { get; set; } = null!;
        public string ItemnumI { get; set; } = null!;
        public string IserialnumberI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal ValueI { get; set; }
        public byte Check1I { get; set; }
        public DateTime DateoutI { get; set; }
        public DateTime DateinI { get; set; }
        public DateTime DatedueI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public byte BooleanmonitorI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
