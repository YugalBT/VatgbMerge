using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30203
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public string Srvstat { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemusetype { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public decimal Qtyorder { get; set; }
        public decimal Atyalloc { get; set; }
        public decimal Qtybacko { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtme { get; set; }
        public string Transtme { get; set; } = null!;
        public string Billabltim { get; set; } = null!;
        public string Trnsfloc { get; set; } = null!;
        public decimal Trnsfqty { get; set; }
        public byte Trnflag { get; set; }
        public string Orddocid { get; set; } = null!;
        public int Translineseq { get; set; }
        public decimal Labpct { get; set; }
        public decimal Partpct { get; set; }
        public decimal Miscpct { get; set; }
        public DateTime Fufildat { get; set; }
        public string Ponmbrstr { get; set; } = null!;
        public decimal Polnseq { get; set; }
        public byte OnReturn { get; set; }
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int MilesStart { get; set; }
        public int MilesEnd { get; set; }
        public int MilesUsed { get; set; }
        public string Pricelvl { get; set; } = null!;
        public short SvcAddressOption { get; set; }
        public string SvcMiscAddressCode { get; set; } = null!;
        public byte SvcDisableXfrGrouping { get; set; }
        public string WorkType { get; set; } = null!;
        public decimal Oruntcst { get; set; }
        public decimal Oruntprc { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Oxtndprc { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public string SvcFoId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
