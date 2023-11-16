using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00800v
    {
        public int? AaMstrId { get; set; }
        public int? AaLinkType { get; set; }
        public int? AaDimId { get; set; }
        public string? AaMasterId { get; set; }
        public string? AaMstrIddescr { get; set; }
        public int DexRowId { get; set; }
    }
}
