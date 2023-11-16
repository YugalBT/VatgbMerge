using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop50401
    {
        public string Itemnmbr { get; set; } = null!;
        public string Epitmtyp { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Prcshid { get; set; } = null!;
        public string Baseuofm { get; set; } = null!;
        public byte Active { get; set; }
        public string Prodtcod { get; set; } = null!;
        public decimal Qtyfrom { get; set; }
        public decimal Psitmval { get; set; }
        public string Freeitem { get; set; } = null!;
        public string Freeuofm { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
