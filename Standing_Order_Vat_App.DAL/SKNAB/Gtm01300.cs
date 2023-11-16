using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm01300
    {
        public string Grantid { get; set; } = null!;
        public string Sponsorid { get; set; } = null!;
        public decimal Awardamount { get; set; }
        public int DexRowId { get; set; }
    }
}
