using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upra0102
    {
        public string Employid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public byte ForeignAddress { get; set; }
        public string ForeignStateProvince { get; set; } = null!;
        public string ForeignPostalCode { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
