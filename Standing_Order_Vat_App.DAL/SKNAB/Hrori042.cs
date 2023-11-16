using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrori042
    {
        public string EmpidI { get; set; } = null!;
        public string OrsetupcodeI { get; set; } = null!;
        public string OrsetupnameI { get; set; } = null!;
        public DateTime DateinI { get; set; }
        public DateTime DateoutI { get; set; }
        public string ClosedbyI { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public DateTime DateoflastchangeI { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
