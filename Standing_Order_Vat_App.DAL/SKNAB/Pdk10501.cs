using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk10501
    {
        public string PdkEeNo { get; set; } = null!;
        public short PdkEeTrxType { get; set; }
        public string Employid { get; set; } = null!;
        public DateTime Padt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string Paitemnumber { get; set; } = null!;
        public decimal PdkQuantity { get; set; }
        public decimal PabaseQty { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Paorgbsunitcst { get; set; }
        public decimal Paextcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Patotcst { get; set; }
        public decimal Paorigtotcost { get; set; }
        public decimal PaoverheadAmount { get; set; }
        public decimal Paorigovhdamt { get; set; }
        public decimal PabaseOvhdCost { get; set; }
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
        public decimal PaprofitAmount { get; set; }
        public decimal Paorigprofamt { get; set; }
        public decimal PaprofitPercent { get; set; }
        public decimal Paorigtotprof { get; set; }
        public decimal PatotalProfit { get; set; }
        public short PaprofitType { get; set; }
        public decimal PastdQty { get; set; }
        public decimal PancQty { get; set; }
        public decimal PanbQty { get; set; }
        public int Lnitmseq { get; set; }
        public string Parefno { get; set; } = null!;
        public int PareferenceLineSeqN { get; set; }
        public short Pabllngtype { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string PdkBillingNoteId { get; set; } = null!;
        public decimal Bktpuram { get; set; }
        public decimal Obkpuramt { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short PabillingStatusN { get; set; }
        public short PaexpenseType { get; set; }
        public short PapaymentMethod { get; set; }
        public decimal PareimbursableAmount { get; set; }
        public decimal PaorigReimbursableAmt { get; set; }
        public decimal Paroundamt { get; set; }
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
        public int DexRowId { get; set; }
    }
}
