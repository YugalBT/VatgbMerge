using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Te024230
    {
        public string EmpidI { get; set; } = null!;
        public DateTime TerminationdateI { get; set; }
        public byte TerminatedI { get; set; }
        public string TermsetupcodeI { get; set; } = null!;
        public string TermsetupnameI { get; set; } = null!;
        public DateTime DateinI { get; set; }
        public DateTime DateoutI { get; set; }
        public string ClosedbyI { get; set; } = null!;
        public DateTime DateoflastchangeI { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime ExitinterviewdateI { get; set; }
        public byte RehireI { get; set; }
        public decimal NotesindexI { get; set; }
        public decimal Notesindex2I { get; set; }
        public int DexRowId { get; set; }
    }
}
