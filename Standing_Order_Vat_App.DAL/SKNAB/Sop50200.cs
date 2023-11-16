using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop50200
    {
        public short Doctype { get; set; }
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int Docprintseq { get; set; }
        public string ShipToName { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public byte Reprint { get; set; }
        public int DexRowId { get; set; }
    }
}
