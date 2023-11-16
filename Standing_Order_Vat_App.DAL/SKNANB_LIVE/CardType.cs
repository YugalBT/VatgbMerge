using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class CardType
    {
        public short IdType { get; set; }
        public string NmType { get; set; } = null!;
        public int? IdBin { get; set; }
    }
}
