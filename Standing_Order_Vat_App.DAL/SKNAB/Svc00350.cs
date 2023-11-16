using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00350
    {
        public int Equipid { get; set; }
        public DateTime SvcPmAnnualDate { get; set; }
        public string Schedid { get; set; } = null!;
        public string Pmdtlid { get; set; } = null!;
        public short Freqofpm { get; set; }
        public string Srvtype { get; set; } = null!;
        public decimal Quantity { get; set; }
        public short SvcPmType { get; set; }
        public short SvcMeterType { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int DexRowId { get; set; }
    }
}
