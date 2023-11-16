using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn100100
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public decimal Balover { get; set; }
        public decimal Custblnc { get; set; }
        public string Custclas { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public short PreferredContactMethod { get; set; }
        public short TimeZone { get; set; }
        public int DexRowId { get; set; }
    }
}
