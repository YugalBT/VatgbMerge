using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2dis01
    {
        public string EmpidI { get; set; } = null!;
        public short EntrynumberI { get; set; }
        public string OffenseI { get; set; } = null!;
        public DateTime DateofoffenseI { get; set; }
        public DateTime DateclosedI { get; set; }
        public DateTime DateoflastchangeI { get; set; }
        public string Userid { get; set; } = null!;
        public string DisctypecomboI { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
