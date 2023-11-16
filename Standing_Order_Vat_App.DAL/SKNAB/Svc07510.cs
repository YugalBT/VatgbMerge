using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07510
    {
        public string Techid { get; set; } = null!;
        public string SvcFormId { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Socscnum { get; set; } = null!;
        public string SvcExpensePurpose { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
