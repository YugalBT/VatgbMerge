using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2di04
    {
        public string EmpidI { get; set; } = null!;
        public short PointsI { get; set; }
        public byte BooleanflagI { get; set; }
        public int DexRowId { get; set; }
    }
}
