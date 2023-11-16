using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01200
    {
        public string MasterType { get; set; } = null!;
        public string MasterId { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Inet1 { get; set; } = null!;
        public string Inet2 { get; set; } = null!;
        public string Inet3 { get; set; } = null!;
        public string Inet4 { get; set; } = null!;
        public string Inet5 { get; set; } = null!;
        public string Inet6 { get; set; } = null!;
        public string Inet7 { get; set; } = null!;
        public string Inet8 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Inetinfo { get; set; } = null!;
    }
}
