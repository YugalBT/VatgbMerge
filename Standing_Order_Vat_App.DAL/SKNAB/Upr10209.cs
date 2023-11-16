using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10209
    {
        public string Userid { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Amntopst { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
