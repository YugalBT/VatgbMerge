using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm00101
    {
        public string EbsForecastId { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public decimal CfmExchangeRate { get; set; }
        public short CfmCalcMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
