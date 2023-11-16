using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tatm0130
    {
        public string TimecodeI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Inactive { get; set; }
        public short TimetypeI { get; set; }
        public string Payrcord { get; set; } = null!;
        public short Paytype { get; set; }
        public string SeniorityI { get; set; } = null!;
        public string OvertimecodeI { get; set; } = null!;
        public int HoursovertimeI { get; set; }
        public string Bspayrcd { get; set; } = null!;
        public short Payperod { get; set; }
        public byte Wrntimefallsblwzero { get; set; }
        public byte AccruetimebenefitsI { get; set; }
        public short Gbtaben { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
