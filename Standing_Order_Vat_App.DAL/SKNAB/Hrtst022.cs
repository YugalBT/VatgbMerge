using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrtst022
    {
        public string EmpidI { get; set; } = null!;
        public short IsequencenumberI { get; set; }
        public string TestcodeI { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public string TestscoreI { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
