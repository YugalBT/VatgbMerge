using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfmtemp
    {
        public string Chekbkid { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public decimal CfmExchangeRate { get; set; }
        public short CfmCalcMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
