using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Taac2030
    {
        public string SeniorityI { get; set; } = null!;
        public short MonthsI { get; set; }
        public string AccrualI { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
