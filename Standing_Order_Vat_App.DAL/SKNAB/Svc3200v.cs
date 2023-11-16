using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc3200v
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public decimal Extdcost { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Qtyfulfi { get; set; }
        public int DexRowId { get; set; }
    }
}
