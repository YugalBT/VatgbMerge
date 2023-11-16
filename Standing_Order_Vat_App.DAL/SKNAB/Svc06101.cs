using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06101
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Wostat { get; set; } = null!;
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemusetype { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public decimal Qtyorder { get; set; }
        public decimal Atyalloc { get; set; }
        public decimal Qtybacko { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Xtndprce { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public string Transtme { get; set; } = null!;
        public string Billabltim { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public decimal Sequence1 { get; set; }
        public string Orddocid { get; set; } = null!;
        public int Translineseq { get; set; }
        public string Ponmbrstr { get; set; } = null!;
        public decimal Polnseq { get; set; }
        public DateTime Fufildat { get; set; }
        public int DexRowId { get; set; }
    }
}
