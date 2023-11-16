using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Taac0130
    {
        public string AccrualI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short AccruebyI { get; set; }
        public int MaxaccrualI { get; set; }
        public int Maxhrsavail { get; set; }
        public int AccrualamountI { get; set; }
        public short DaysI { get; set; }
        public int HoursperyearI { get; set; }
        public short Payperod { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
