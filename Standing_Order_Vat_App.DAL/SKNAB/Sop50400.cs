using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop50400
    {
        public string Userid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Prcshid { get; set; } = null!;
        public string Epitmtyp { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Psitmval { get; set; }
        public decimal Equomqty { get; set; }
        public string Baseuofm { get; set; } = null!;
        public short Promolvl { get; set; }
        public short Promotyp { get; set; }
        public string Prcgrpid { get; set; } = null!;
        public string Prodtcod { get; set; } = null!;
        public byte Active { get; set; }
        public int DexRowId { get; set; }
    }
}
