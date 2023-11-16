using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pavw31102
    {
        public string Pavidn { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Papurordnum { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal BackoutTradeDiscTax { get; set; }
        public short Mcbillcurrnidx { get; set; }
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
        public string Poprctnm { get; set; } = null!;
        public string Ponumber { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public string Vnditdsc { get; set; } = null!;
        public decimal Umqtyinb { get; set; }
        public DateTime Actlship { get; set; }
        public string Commntid { get; set; } = null!;
        public int Invindx { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public string Locncode { get; set; } = null!;
        public decimal RcptLineNoteIdarray1 { get; set; }
        public decimal RcptLineNoteIdarray2 { get; set; }
        public decimal RcptLineNoteIdarray3 { get; set; }
        public decimal RcptLineNoteIdarray4 { get; set; }
        public decimal RcptLineNoteIdarray5 { get; set; }
        public decimal RcptLineNoteIdarray6 { get; set; }
        public decimal RcptLineNoteIdarray7 { get; set; }
        public decimal RcptLineNoteIdarray8 { get; set; }
        public short Noninven { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public short Itmtrkop { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Jobnumbr { get; set; } = null!;
        public string Costcode { get; set; } = null!;
        public short Costtype { get; set; }
        public short Currnidx { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Orextcst { get; set; }
        public short Odecplcu { get; set; }
        public string Bolpronumber { get; set; } = null!;
        public byte CapitalItem { get; set; }
        public short ProductIndicator { get; set; }
        public short PurchaseIvItemTaxable { get; set; }
        public string PurchaseItemTaxSchedu { get; set; } = null!;
        public string PurchaseSiteTaxSchedu { get; set; } = null!;
        public byte Bsivcttl { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public int Purpvidx { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string LandedCostGroupId { get; set; } = null!;
        public short LandedCostWarnings { get; set; }
        public byte LandedCost { get; set; }
        public byte InvoiceMatch { get; set; }
        public string Rcptretnum { get; set; } = null!;
        public int Rcptretlnnum { get; set; }
        public string Invretnum { get; set; } = null!;
        public int Invretlnnum { get; set; }
        public byte Islineintra { get; set; }
        public string ProjNum { get; set; } = null!;
        public string CostCatId { get; set; } = null!;
    }
}
