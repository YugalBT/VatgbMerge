using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr19901
    {
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Payrolcd { get; set; } = null!;
        public int Actindx { get; set; }
        public short Upractyp { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
