using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00303
    {
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public DateTime Instdte { get; set; }
        public decimal Quantity { get; set; }
        public short Cnfglvl { get; set; }
        public short Cnfgseq { get; set; }
        public short Parlevel { get; set; }
        public short Parseq { get; set; }
        public byte Chdflag { get; set; }
        public int DexRowId { get; set; }
    }
}
