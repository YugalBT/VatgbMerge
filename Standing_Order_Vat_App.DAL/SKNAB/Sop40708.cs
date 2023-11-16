using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40708
    {
        public string Userid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
