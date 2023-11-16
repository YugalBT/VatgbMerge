using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30700
    {
        public string Orddocid { get; set; } = null!;
        public string Rfrncdoc { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public short Status { get; set; }
        public DateTime Ordrdate { get; set; }
        public DateTime Etadte { get; set; }
        public string Custname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Trnsfloc { get; set; } = null!;
        public string Itlocn { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short SvcAddressOption { get; set; }
        public string SvcMiscAddressCode { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
