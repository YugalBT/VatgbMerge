using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00710
    {
        public string Srcdocnum { get; set; } = null!;
        public short Srcdoctyp { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemdesc { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public decimal Qtyorder { get; set; }
        public string Trnsfloc { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public decimal Qtybacko { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Atyalloc { get; set; }
        public decimal Trnsfqty { get; set; }
        public string Stationid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public byte Trnflag { get; set; }
        public byte SvcDisableXfrGrouping { get; set; }
        public string Userid { get; set; } = null!;
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short SvcAddressOption { get; set; }
        public string SvcMiscAddressCode { get; set; } = null!;
        public DateTime Prmdate { get; set; }
        public byte Mkdtopst { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
