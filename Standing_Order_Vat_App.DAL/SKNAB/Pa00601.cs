using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00601
    {
        public string Employid { get; set; } = null!;
        public byte Pafileemplreim { get; set; }
        public byte Panota1099vendor { get; set; }
        public byte Papmcb { get; set; }
        public byte Pabmcb { get; set; }
        public short PaemployeeType { get; set; }
        public short PaEmployedBy { get; set; }
        public string PapayCode { get; set; } = null!;
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
        public string PaunitOfMeasure { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public short PatmprofitType { get; set; }
        public decimal PatmprofitAmount { get; set; }
        public decimal PaOrigProfitAmtTm { get; set; }
        public decimal PatmprofitPercent { get; set; }
        public short PaprofitTypeCp { get; set; }
        public decimal PaprofitAmountCp { get; set; }
        public decimal PaprofitPercentCp { get; set; }
        public short PaffprofitType { get; set; }
        public decimal PaffprofitAmount { get; set; }
        public decimal PaffprofitPercent { get; set; }
        public string Vendorid { get; set; } = null!;
        public short PaoverheadRateMethod { get; set; }
        public decimal PaovhdAmtPerUnit { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public byte PaAllowVendorForPo { get; set; }
        public int DexRowId { get; set; }
    }
}
