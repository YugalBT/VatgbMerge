using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40301
    {
        public string Jobtitle { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short EeoclassI { get; set; }
        public short Flsastatus { get; set; }
        public string Reportstopos { get; set; } = null!;
        public string ReviewsetupcodeI { get; set; } = null!;
        public int SkillsetnumberI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Noteindx2 { get; set; }
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
