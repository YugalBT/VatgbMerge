using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40500
    {
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Payrolcd { get; set; } = null!;
        public short Upractyp { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
