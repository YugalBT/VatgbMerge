using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tx00201
    {
        public string Taxdtlid { get; set; } = null!;
        public string Txdtldsc { get; set; } = null!;
        public short Txdtltyp { get; set; }
        public int Actindx { get; set; }
        public string Txidnmbr { get; set; } = null!;
        public short Txdtlbse { get; set; }
        public decimal Txdtlpct { get; set; }
        public decimal Txdtlamt { get; set; }
        public short Tdtlrndg { get; set; }
        public string Txdbodtl { get; set; } = null!;
        public decimal Tdtabmin { get; set; }
        public decimal Tdtabmax { get; set; }
        public decimal Tdtaxmin { get; set; }
        public decimal Tdtaxmax { get; set; }
        public short Tdrngtyp { get; set; }
        public short Txdtqual { get; set; }
        public byte Tdtaxtax { get; set; }
        public byte Txdtlpdc { get; set; }
        public string Txdtlpch { get; set; } = null!;
        public byte Txdxdisc { get; set; }
        public string Cmnytxid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Name { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
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
        public string Fax { get; set; } = null!;
        public string Txusrdf1 { get; set; } = null!;
        public string Txusrdf2 { get; set; } = null!;
        public byte Vatregtx { get; set; }
        public byte TaxInvReqd { get; set; }
        public short TaxPostToAcct { get; set; }
        public byte[] TaxBoxes { get; set; } = null!;
        public byte Ignrgrssamnt { get; set; }
        public decimal Tdtabpct { get; set; }
        public int DexRowId { get; set; }
    }
}
