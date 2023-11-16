using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10403
    {
        public string Prcshid { get; set; } = null!;
        public string Epitmtyp { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Freeitem { get; set; } = null!;
        public string Freeuofm { get; set; } = null!;
        public decimal Maxqtyfr { get; set; }
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public int DexRowId { get; set; }
    }
}
