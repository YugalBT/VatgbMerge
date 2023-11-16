using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportUserPref
    {
        public string Userid { get; set; } = null!;
        public byte Askechtm { get; set; }
        public int DexRowId { get; set; }
    }
}
