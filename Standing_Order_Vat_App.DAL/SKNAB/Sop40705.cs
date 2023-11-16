using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40705
    {
        public string Prcbkid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public int DexRowId { get; set; }
    }
}
