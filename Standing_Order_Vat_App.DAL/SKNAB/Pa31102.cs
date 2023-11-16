using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa31102
    {
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Papurordnum { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal BackoutTradeDiscTax { get; set; }
        public short Currnidx { get; set; }
        public decimal Denxrate { get; set; }
        public DateTime Exchdate { get; set; }
        public decimal Xchgrate { get; set; }
        public string Exgtblid { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short Mctrxstt { get; set; }
        public int Ord { get; set; }
        public decimal OrigBackoutTradeDiscTax { get; set; }
        public decimal Ortdisam { get; set; }
        public short PaacctgMethod { get; set; }
        public decimal Paacrev { get; set; }
        public decimal PaapprovedBillingAmou { get; set; }
        public decimal Paapprovbillrate { get; set; }
        public decimal Paapprovmkuppct { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal PaBaseBillingRate { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal PabilledAmount { get; set; }
        public decimal PabilledDiscount { get; set; }
        public decimal PaBilledProfitAmount { get; set; }
        public decimal PabilledProfitPercentage { get; set; }
        public byte PaBilledStatus { get; set; }
        public decimal PabilledQtyN { get; set; }
        public decimal PabilledTax { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Pabilrate { get; set; }
        public short PabillingStatusN { get; set; }
        public short Pabllngtype { get; set; }
        public byte Pacbaddfrmfly { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int PacogsIdx { get; set; }
        public int PacontraAccountIdx { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string Pacostcatnme { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public int PalineItemSeq { get; set; }
        public decimal Pamarkpercent { get; set; }
        public decimal PaMcAccruedRevenue { get; set; }
        public decimal PaMcBaseBillingRate { get; set; }
        public decimal PaMcBillingRate { get; set; }
        public string Pamccurncyid { get; set; } = null!;
        public decimal PaMcVarianceAccruedRev { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal Paorigbaseovrhcst { get; set; }
        public decimal Paorigbillrate { get; set; }
        public decimal Paorigovhdamt { get; set; }
        public decimal Paorigprofamt { get; set; }
        public decimal PaorigSec { get; set; }
        public decimal Paorigtotovrhd { get; set; }
        public decimal Paorigtotprof { get; set; }
        public decimal PaorigVarExt { get; set; }
        public decimal PaoverheadAmount { get; set; }
        public int PaoverheadIdx { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public byte[] PapoLineErrors { get; set; } = null!;
        public decimal PaprofitAmount { get; set; }
        public decimal PaprofitPercent { get; set; }
        public short PaprofitType { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public int PareferenceLineSeqN { get; set; }
        public decimal PashipmentExtCost { get; set; }
        public decimal Patotaloverh { get; set; }
        public decimal PatotalProfit { get; set; }
        public short Patu { get; set; }
        public int PaunbilledArIdx { get; set; }
        public int PaunbilledProjRevIdx { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public byte PaVarianceCost { get; set; }
        public decimal PaVarianceAccruedReve { get; set; }
        public decimal PaVarianceQtyAccrued { get; set; }
        public string Pavendid { get; set; } = null!;
        public int Pacgbwipidx { get; set; }
        public short Potype { get; set; }
        public short Poptype { get; set; }
        public string Pricelvl { get; set; } = null!;
        public short Ratecalc { get; set; }
        public string Ratetpid { get; set; } = null!;
        public DateTime Receiptdate { get; set; }
        public DateTime Time1 { get; set; }
        public decimal Trdisamt { get; set; }
        public string Uomschdl { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
