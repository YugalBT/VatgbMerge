using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00980
    {
        public string SvcMiscAddressCode { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
