using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41303
    {
        public string Paprojnumber { get; set; } = null!;
        public byte Pasegfpar { get; set; }
        public byte Pasegfpbiee { get; set; }
        public byte Pasegfpcontra { get; set; }
        public byte Pasegfpeieb { get; set; }
        public byte Pasegfpoverhd { get; set; }
        public byte Pasegfprojbill { get; set; }
        public byte Pasegfprojexp { get; set; }
        public byte Pasegfprojloss { get; set; }
        public byte Pasegfprojrev { get; set; }
        public byte Pasegfpretenar { get; set; }
        public byte Pasegfpwip { get; set; }
        public byte Pasegfpdeferev { get; set; }
        public byte Pasegtmar { get; set; }
        public byte OvrsegFparfee { get; set; }
        public byte OvrsegFpexcessBlngFee { get; set; }
        public byte OvrsegFpexcessEarnFee { get; set; }
        public byte OvrsegFpprojBillingsFee { get; set; }
        public byte OvrsegFpprojDefRev { get; set; }
        public byte OvrsegFpprojRevFee { get; set; }
        public byte OvrsegFpprojWipfee { get; set; }
        public byte Paoveridesegtmcogs { get; set; }
        public byte Paoveridesegtmcontra { get; set; }
        public byte Pasegtmdeferev { get; set; }
        public byte Pasegtmoverhead { get; set; }
        public byte Pasegtmprojrev { get; set; }
        public byte Paoveridesegtmunbillar { get; set; }
        public byte Pasegtmunbillrev { get; set; }
        public byte Paoveridesegtmwip { get; set; }
        public byte OvrsegTmprojSales { get; set; }
        public byte OvrsegTmarfee { get; set; }
        public int DexRowId { get; set; }
    }
}
