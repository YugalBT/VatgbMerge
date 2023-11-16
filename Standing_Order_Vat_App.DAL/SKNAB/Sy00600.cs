using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy00600
    {
        public short Cmpanyid { get; set; }
        public string Locatnid { get; set; } = null!;
        public string Locatnnm { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Adrcntct { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal Noteindx { get; set; }
        public string Ccode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
