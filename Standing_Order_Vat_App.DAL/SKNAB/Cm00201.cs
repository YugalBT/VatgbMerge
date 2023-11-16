using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00201
    {
        public string MerchantId { get; set; } = null!;
        public string StoreNumber { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string EftuserId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
