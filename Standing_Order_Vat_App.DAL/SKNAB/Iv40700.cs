using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40700
    {
        public string Locncode { get; set; } = null!;
        public string Locndscr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string LocationSegment { get; set; } = null!;
        public string Staxschd { get; set; } = null!;
        public string Pctaxsch { get; set; } = null!;
        public byte Inclddinplnnng { get; set; }
        public string Poreceiptbin { get; set; } = null!;
        public string Poretrnbin { get; set; } = null!;
        public string Sofulfillmentbin { get; set; } = null!;
        public string Soreturnbin { get; set; } = null!;
        public string Bomrcptbin { get; set; } = null!;
        public string Materialissuebin { get; set; } = null!;
        public string Moreceiptbin { get; set; } = null!;
        public string Repairissuesbin { get; set; } = null!;
        public byte Wmsint { get; set; }
        public short Pickticketsiteopt { get; set; }
        public short Binbreak { get; set; }
        public string Ccode { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
