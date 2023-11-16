using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop10150
    {
        public string Popnumbe { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Comment3 { get; set; } = null!;
        public string Comment4 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
