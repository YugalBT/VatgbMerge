using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy04800
    {
        public short Cmpanyid { get; set; }
        public string Inetprmpts1 { get; set; } = null!;
        public string Inetprmpts2 { get; set; } = null!;
        public string Inetprmpts3 { get; set; } = null!;
        public string Inetprmpts4 { get; set; } = null!;
        public string Inetprmpts5 { get; set; } = null!;
        public string Inetprmpts6 { get; set; } = null!;
        public string Inetprmpts7 { get; set; } = null!;
        public string Inetprmpts8 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
