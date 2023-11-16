using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm01101
    {
        public string Grantid { get; set; } = null!;
        public string UserDefinedList01 { get; set; } = null!;
        public string UserDefinedList02 { get; set; } = null!;
        public string UserDefinedList03 { get; set; } = null!;
        public string UserDefinedText01 { get; set; } = null!;
        public string UserDefinedText02 { get; set; } = null!;
        public string UserDefinedText03 { get; set; } = null!;
        public DateTime UserDefinedDate01 { get; set; }
        public DateTime UserDefinedDate02 { get; set; }
        public DateTime UserDefinedDate03 { get; set; }
        public string UserDefNumeric01 { get; set; } = null!;
        public string UserDefNumeric02 { get; set; } = null!;
        public string UserDefNumeric03 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
