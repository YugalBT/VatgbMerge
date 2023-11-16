using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2uni01
    {
        public string EmpidI { get; set; } = null!;
        public DateTime SenioritydateI { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string UnionnameI { get; set; } = null!;
        public decimal UnionduesamountI { get; set; }
        public short ContactnumberI { get; set; }
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
