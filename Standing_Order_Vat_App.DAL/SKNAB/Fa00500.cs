using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00500
    {
        public int Assetindex { get; set; }
        public int Leasecompindx { get; set; }
        public short Leasetype { get; set; }
        public string Leasecontractid { get; set; } = null!;
        public decimal Leasepayment { get; set; }
        public short Leaseintrate { get; set; }
        public DateTime Leaseenddate { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
