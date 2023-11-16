using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2di05
    {
        public string EmpidI { get; set; } = null!;
        public DateTime DatefiledI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public short PointsI { get; set; }
        public short ChangesI { get; set; }
        public int DexRowId { get; set; }
    }
}
