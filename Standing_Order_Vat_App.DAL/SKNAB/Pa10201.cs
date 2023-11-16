using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10201
    {
        public short Psmiscltrxtype { get; set; }
        public string Pamiscldocno { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string Psmiscid { get; set; } = null!;
        public DateTime Padt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public decimal PaqtyQ { get; set; }
        public decimal PabaseQty { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal Paroundamt { get; set; }
        public decimal Paunitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Paorgbsunitcst { get; set; }
        public decimal Paextcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Patotcst { get; set; }
        public decimal Paorigtotcost { get; set; }
        public decimal PaoverheadAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal Paorigovhdamt { get; set; }
        public decimal Paorigbaseovrhcst { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public decimal Patotaloverh { get; set; }
        public decimal Paorigtotovrhd { get; set; }
        public decimal Pabilrate { get; set; }
        public decimal Paorigbillrate { get; set; }
        public decimal PaBaseBillingRate { get; set; }
        public decimal Paorigbsbillrte { get; set; }
        public decimal Pamarkpercent { get; set; }
        public decimal Paacrev { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal PastdQty { get; set; }
        public decimal PancQty { get; set; }
        public decimal PanbQty { get; set; }
        public int Lnitmseq { get; set; }
        public int PareferenceLineSeqN { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public short Pabllngtype { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public short PaprofitType { get; set; }
        public decimal PaprofitPercent { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal Paorigprofamt { get; set; }
        public decimal PatotalProfit { get; set; }
        public decimal Paorigtotprof { get; set; }
        public DateTime Paexptdate { get; set; }
        public byte[] PamlLineErrors { get; set; } = null!;
        public byte[] Pamllineerr2 { get; set; } = null!;
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
        public int Rnddiff { get; set; }
        public string Pachgordno { get; set; } = null!;
        public byte Pacbaddfrmfly { get; set; }
        public string Pamccurncyid { get; set; } = null!;
        public decimal PaMcBillingRate { get; set; }
        public decimal PaMcBaseBillingRate { get; set; }
        public decimal PaMcAccruedRevenue { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short CorrectingTrxType { get; set; }
        public string Paoriginldocnum { get; set; } = null!;
        public int Paoriglineimseq { get; set; }
        public int DexRowId { get; set; }
    }
}
