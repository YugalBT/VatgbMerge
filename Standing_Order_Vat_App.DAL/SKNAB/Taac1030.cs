using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Taac1030
    {
        public string SeniorityI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
