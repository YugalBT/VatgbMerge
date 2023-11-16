using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2dis02
    {
        public string EmpidI { get; set; } = null!;
        public short EntrynumberI { get; set; }
        public short SeqorderI { get; set; }
        public string StagenameI { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public string PersonfilingI { get; set; } = null!;
        public short StagetypeI { get; set; }
        public DateTime DateinI { get; set; }
        public DateTime DateoutI { get; set; }
        public short GbI { get; set; }
        public byte TerminationcbI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
