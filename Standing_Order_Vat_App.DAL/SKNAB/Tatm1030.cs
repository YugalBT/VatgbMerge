using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tatm1030
    {
        public string EmpidI { get; set; } = null!;
        public string TimecodeI { get; set; } = null!;
        public byte Inactive { get; set; }
        public short TimetypeI { get; set; }
        public short Payperod { get; set; }
        public byte Prnavailtmepyrl { get; set; }
        public byte Wrntimefallsblwzero { get; set; }
        public string SeniorityI { get; set; } = null!;
        public DateTime SenioritydateI { get; set; }
        public DateTime NextaccrualdateI { get; set; }
        public DateTime NextsenioritydateI { get; set; }
        public byte AccruetimebenefitsI { get; set; }
        public string WcidI { get; set; } = null!;
        public short TrxcountI { get; set; }
        public int HoursI { get; set; }
        public int HoursavailableI { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public int HoursaccytdI { get; set; }
        public int HourscarriedoverI { get; set; }
        public int HoursperyearI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
