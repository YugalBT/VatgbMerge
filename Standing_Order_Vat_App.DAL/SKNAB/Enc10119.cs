using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10119
    {
        public int History { get; set; }
        public string Ponumber { get; set; } = null!;
        public int Ord { get; set; }
        public short Polnesta { get; set; }
        public short Status { get; set; }
        public short Potype { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public DateTime Reqdate { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public int Invindx { get; set; }
        public short Accttype { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Actnumst { get; set; } = null!;
        public short LineNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
