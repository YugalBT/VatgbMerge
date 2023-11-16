using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2tra04
    {
        public string EmpidI { get; set; } = null!;
        public string CourseidI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public byte CbI { get; set; }
        public DateTime Date1 { get; set; }
        public string Str20dummyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public string Userid { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
