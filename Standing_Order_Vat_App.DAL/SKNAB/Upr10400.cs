using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10400
    {
        public string Userid { get; set; } = null!;
        public string Srcecode { get; set; } = null!;
        public string Futasuta { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Payrolcd { get; set; } = null!;
        public short Upractyp { get; set; }
        public int Actindx { get; set; }
        public decimal Amntopst { get; set; }
        public int DexRowId { get; set; }
    }
}
