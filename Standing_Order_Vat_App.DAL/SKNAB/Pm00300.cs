using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00300
    {
        public string Vendorid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Vndcntct { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Upszone { get; set; } = null!;
        public string Phnumbr1 { get; set; } = null!;
        public string Phnumbr2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public byte EmailPos { get; set; }
        public string PoemailRecipient { get; set; } = null!;
        public short EmailPoformat { get; set; }
        public byte FaxPos { get; set; }
        public string PofaxNumber { get; set; } = null!;
        public short FaxPoformat { get; set; }
        public string Ccode { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
