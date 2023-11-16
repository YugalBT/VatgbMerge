using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tast0130
    {
        public string CompanycodeI { get; set; } = null!;
        public byte Taaccrue { get; set; }
        public byte Alwtyprsnpyrl { get; set; }
        public short Year1 { get; set; }
        public DateTime Lastdac { get; set; }
        public short Tasenior { get; set; }
        public byte UsevacationI { get; set; }
        public short DaysI { get; set; }
        public int HoursI { get; set; }
        public int TrxI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
