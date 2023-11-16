using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0203v
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public string Itemusetype { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string WorkType { get; set; } = null!;
        public string Transtme { get; set; } = null!;
        public string Billabltim { get; set; } = null!;
        public decimal Qtyorder { get; set; }
        public decimal Qtysold { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtme { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public int? DexRowId { get; set; }
    }
}
