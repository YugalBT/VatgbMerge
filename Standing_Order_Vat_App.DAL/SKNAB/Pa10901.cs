using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10901
    {
        public string PaivDocumentNo { get; set; } = null!;
        public short PaivTransferType { get; set; }
        public int Lnitmseq { get; set; }
        public int PalineItemSeq { get; set; }
        public string Parefno { get; set; } = null!;
        public int PareferenceLineSeqN { get; set; }
        public DateTime Padt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public string Locncode { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal PabaseQty { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Patotcst { get; set; }
        public decimal PaoverheadAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public decimal Patotaloverh { get; set; }
        public string Pricelvl { get; set; } = null!;
        public decimal Pabilrate { get; set; }
        public decimal PaBaseBillingRate { get; set; }
        public decimal Pamarkpercent { get; set; }
        public decimal Paacrev { get; set; }
        public short Pabllngtype { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public DateTime Paexptdate { get; set; }
        public decimal PastdQty { get; set; }
        public decimal PancQty { get; set; }
        public decimal PanbQty { get; set; }
        public short PaprofitType { get; set; }
        public decimal PaprofitPercent { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal PatotalProfit { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal Paapprovbillrate { get; set; }
        public decimal Paapprovmkuppct { get; set; }
        public decimal PaapprovedBillingAmou { get; set; }
        public decimal PabilledProfitPercentage { get; set; }
        public decimal PaBilledProfitAmount { get; set; }
        public decimal PabilledAmount { get; set; }
        public decimal PabilledTax { get; set; }
        public decimal PabilledMisc { get; set; }
        public decimal PabilledFreight { get; set; }
        public decimal PabilledDiscount { get; set; }
        public decimal PawriteUpDownAmount { get; set; }
        public int PawriteUpDownPercenta { get; set; }
        public string PaapproverId { get; set; } = null!;
        public decimal PabilledQtyN { get; set; }
        public short PaapproverType { get; set; }
        public byte PapartialBill { get; set; }
        public short PabillingStatusN { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PaunbilledArIdx { get; set; }
        public int PacogsIdx { get; set; }
        public int PacontraAccountIdx { get; set; }
        public int PaoverheadIdx { get; set; }
        public int PaunbilledProjRevIdx { get; set; }
        public int Ivivindx { get; set; }
        public byte[] PaivLineErrors { get; set; } = null!;
        public byte[] Paivlinerr2 { get; set; } = null!;
        public short PapurchaseTaxOptions { get; set; }
        public string Itmtshid { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Paextcost { get; set; }
        public string Uomschdl { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public byte Pacbaddfrmfly { get; set; }
        public string Trnstloc { get; set; } = null!;
        public string Pamccurncyid { get; set; } = null!;
        public decimal PaMcBillingRate { get; set; }
        public decimal PaMcBaseBillingRate { get; set; }
        public decimal PaMcAccruedRevenue { get; set; }
        public short Currnidx { get; set; }
        public decimal Denxrate { get; set; }
        public DateTime Exchdate { get; set; }
        public string Exgtblid { get; set; } = null!;
        public short Mctrxstt { get; set; }
        public short Ratecalc { get; set; }
        public string Ratetpid { get; set; } = null!;
        public DateTime Time1 { get; set; }
        public decimal Xchgrate { get; set; }
        public int DexRowId { get; set; }
    }
}
