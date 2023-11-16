using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02501
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pabillcycleid1 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
