using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ada01
    {
        public string PositioncodeI { get; set; } = null!;
        public string ReportstoI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public string Userid { get; set; } = null!;
        public short SitI { get; set; }
        public short StandI { get; set; }
        public short WalkI { get; set; }
        public string HeightI { get; set; } = null!;
        public short BalancegbI { get; set; }
        public short BendgbI { get; set; }
        public short ClimbgbI { get; set; }
        public short CrawlgbI { get; set; }
        public short CrouchgbI { get; set; }
        public short KneelgbI { get; set; }
        public short PushgbI { get; set; }
        public short ReachgbI { get; set; }
        public short SquatgbI { get; set; }
        public short CarrygbI1 { get; set; }
        public short CarrygbI2 { get; set; }
        public short CarrygbI3 { get; set; }
        public short CarrygbI4 { get; set; }
        public short CarrygbI5 { get; set; }
        public short CarrygbI6 { get; set; }
        public short LiftgbI1 { get; set; }
        public short LiftgbI2 { get; set; }
        public short LiftgbI3 { get; set; }
        public short LiftgbI4 { get; set; }
        public short LiftgbI5 { get; set; }
        public short LiftgbI6 { get; set; }
        public short RfootgbI { get; set; }
        public short LfootgbI { get; set; }
        public short RhandgbI1 { get; set; }
        public short RhandgbI2 { get; set; }
        public short RhandgbI3 { get; set; }
        public short LhandgbI1 { get; set; }
        public short LhandgbI2 { get; set; }
        public short LhandgbI3 { get; set; }
        public short DangergbI1 { get; set; }
        public short DangergbI2 { get; set; }
        public short DangergbI3 { get; set; }
        public short DangergbI4 { get; set; }
        public short DangergbI5 { get; set; }
        public string Cmnts1I { get; set; } = null!;
        public string Cmnts2I { get; set; } = null!;
        public string Cmnts3I { get; set; } = null!;
        public string Cmnts4I { get; set; } = null!;
        public string Cmnts5I { get; set; } = null!;
        public string EmprepresentI { get; set; } = null!;
        public string Title0I { get; set; } = null!;
        public DateTime IdateI { get; set; }
        public int DexRowId { get; set; }
        public string JobpurposeI { get; set; } = null!;
    }
}
