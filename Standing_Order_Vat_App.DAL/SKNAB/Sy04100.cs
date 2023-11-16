using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy04100
    {
        public string Bankid { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phnumbr1 { get; set; } = null!;
        public string Phnumbr2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string Trnstnbr { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Ddtranum { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
