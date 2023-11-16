using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01403
    {
        public string ParateTableId { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string PapayCode { get; set; } = null!;
        public string PaunitOfMeasure { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public short PaprofitType { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal PaprofitPercent { get; set; }
        public short PaoverheadRateMethod { get; set; }
        public decimal PaovhdAmtPerUnit { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public string PaoverheadGroupId { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public decimal PaOrigProfitAmtTm { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
