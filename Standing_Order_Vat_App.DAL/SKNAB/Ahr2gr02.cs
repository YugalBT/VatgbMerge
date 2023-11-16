using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2gr02
    {
        public string EmpidI { get; set; } = null!;
        public short EntrynumberI { get; set; }
        public short StagenumberI { get; set; }
        public short SeqorderI { get; set; }
        public string StagenameI { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
