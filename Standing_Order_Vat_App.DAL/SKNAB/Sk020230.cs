using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sk020230
    {
        public short QueryIndex { get; set; }
        public short SkillnumberI { get; set; }
        public short PointsI { get; set; }
        public short GbI { get; set; }
        public string SkilltitleI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
