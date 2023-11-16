using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01301
    {
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public short Patu { get; set; }
        public byte PaivItemCheckbox { get; set; }
        public short Pastat { get; set; }
        public short PaprofitType { get; set; }
        public short Pabllngtype { get; set; }
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal PabaseProfitAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal PaforecastBaseOvrhdAmt { get; set; }
        public decimal PaforecastBaseQty { get; set; }
        public decimal PaforecastBaseUnitCost { get; set; }
        public decimal PaforecastBaseProfitAmt { get; set; }
        public DateTime PabbeginDate { get; set; }
        public DateTime PabendDate { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PabunitCost { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal Pabprofit { get; set; }
        public decimal PabprofitAmt { get; set; }
        public decimal PabprofitPcnt { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public short PabaselinePtaxOptions { get; set; }
        public string PabaselineCtaxSchedId { get; set; } = null!;
        public short PabaselineStaxOptions { get; set; }
        public string PabaselineBtaxSchedId { get; set; } = null!;
        public DateTime Paactualbegdate { get; set; }
        public DateTime PaActualEndDate { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PafunitCost { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal Pafprofit { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public decimal PafprofitAmt { get; set; }
        public decimal PafprofitPcnt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public short PaforecastPtaxOptions { get; set; }
        public string PaforecastCtaxSchedId { get; set; } = null!;
        public short PaforecastStaxOptions { get; set; }
        public string PaforecastBtaxSchedId { get; set; } = null!;
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal PauofMmult { get; set; }
        public short Decplqty { get; set; }
        public string PapayCodeHourly { get; set; } = null!;
        public string PapayCodeSalary { get; set; } = null!;
        public short Decplcur { get; set; }
        public string PalaborRateTableId { get; set; } = null!;
        public short PalaborRateTableType { get; set; }
        public byte PalaborRateTableAcc { get; set; }
        public string PaequipRateTableId { get; set; } = null!;
        public byte PaequipRateTableAcc { get; set; }
        public short TmWipSrc { get; set; }
        public short TmCogsSrc { get; set; }
        public short TmCostContraSrc { get; set; }
        public short TmUnbilledArSrc { get; set; }
        public short TmUnbilledRevSrc { get; set; }
        public short TmArSrc { get; set; }
        public short TmPrjRevSrc { get; set; }
        public short TmOvhdSrc { get; set; }
        public short FfWipSrc { get; set; }
        public short FfCostContraSrc { get; set; }
        public short FfArSrc { get; set; }
        public short FfPrjBillingsSrc { get; set; }
        public short FfPrjExpenseSrc { get; set; }
        public short FfPrjRevenueSrc { get; set; }
        public short FfPrjLossSrc { get; set; }
        public short FfBieeSrc { get; set; }
        public short FfEiebSrc { get; set; }
        public short FfOvhdSrc { get; set; }
        public decimal PaprojectAmount { get; set; }
        public short PaoverheadRateMethod { get; set; }
        public decimal PabaselineOvhdAmtPerUnit { get; set; }
        public decimal PabaselineOvrhdPct { get; set; }
        public decimal PaforecastOvrhdAmtPerUnt { get; set; }
        public decimal PaforecastOvrhdPct { get; set; }
        public DateTime PaubeginDate { get; set; }
        public DateTime PauendDate { get; set; }
        public decimal PaunpostedQty { get; set; }
        public decimal PaunpostedTotalCostN { get; set; }
        public decimal PaunpostedOverhead { get; set; }
        public decimal PaunpostedProfitN { get; set; }
        public decimal PaunpostedTaxAmount { get; set; }
        public decimal PaunpostAccrRevN { get; set; }
        public decimal PaunpostedCommitedQty { get; set; }
        public decimal PaunpostedCommitedCost { get; set; }
        public decimal PaunpostedCommitedTaxAmt { get; set; }
        public decimal Paunpostbieeamount { get; set; }
        public decimal Paunpeiebamount { get; set; }
        public decimal Paunpostbillamt { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal PapostedOverhead { get; set; }
        public decimal PapostedProfitN { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal PapostedAccrRevN { get; set; }
        public decimal PapostedCommitedQty { get; set; }
        public decimal PapostedCommitedCost { get; set; }
        public decimal PapostedCommitedTaxAmt { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal Papostbillamt { get; set; }
        public decimal PawriteUpDownAmount { get; set; }
        public decimal PabilledQtyN { get; set; }
        public decimal PabilledCost { get; set; }
        public decimal PabilledAccruedRevenu { get; set; }
        public decimal PacostPcntCompleted { get; set; }
        public decimal PaquantityPcntCompleted { get; set; }
        public decimal PaReceiptsAmount { get; set; }
        public decimal PaActualReceiptsAmoun { get; set; }
        public decimal PaEarnings { get; set; }
        public decimal PaCostOfEarnings { get; set; }
        public decimal PaunpostBillN { get; set; }
        public decimal PaunpostDiscDolAmtN { get; set; }
        public decimal PaunpostedSalesTaxAm { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PapostedDiscDolAmtN { get; set; }
        public decimal PapostedSalesTaxAmou { get; set; }
        public decimal Pabcwpamt { get; set; }
        public decimal Pabcwsamt { get; set; }
        public decimal Paacwpamt { get; set; }
        public int Lnitmseq { get; set; }
        public int PalineItemSeq { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal PaunpostedRecogRevN { get; set; }
        public decimal PaapprovedAccruedReve { get; set; }
        public decimal PaapprovedCost { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal PacommittedCosts { get; set; }
        public decimal PacommittedQty { get; set; }
        public decimal Papoqty { get; set; }
        public decimal Papocost { get; set; }
        public decimal PapopostedQty { get; set; }
        public decimal PapopostedCost { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal Distknam { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
        public short Pasfid { get; set; }
        public byte PapreviouslyOpen { get; set; }
        public decimal Pataxpaidamt { get; set; }
        public decimal PapostedTaxPaidN { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal Paunpostretamt { get; set; }
        public decimal PaWriteOffTaxAmount { get; set; }
        public decimal PaactualWotaxAmt { get; set; }
        public decimal PaTermsTakenTaxAmt { get; set; }
        public decimal PaactualTermsTakenTax { get; set; }
        public string Pachgordno { get; set; } = null!;
        public decimal Paunapprvprojamt { get; set; }
        public decimal Paunapfrtotbill { get; set; }
        public decimal Paunappfrtotcst { get; set; }
        public decimal Paunfrctotprof { get; set; }
        public decimal Paunpfrtotqty { get; set; }
        public decimal Paunabstotbill { get; set; }
        public decimal Paunpbstotcst { get; set; }
        public decimal Paunpbsltotprof { get; set; }
        public decimal Paunpbstotqty { get; set; }
        public decimal Patotchgordamt { get; set; }
        public decimal PapostedEarnings { get; set; }
        public decimal PaactualCostofEarnings { get; set; }
        public decimal PaunpostedLossAmount { get; set; }
        public decimal PaactualLossAmount { get; set; }
        public string Pamccurncyid { get; set; } = null!;
        public decimal PamcbprofitAmt { get; set; }
        public decimal Pamcbbillings { get; set; }
        public decimal PamcfprofitAmt { get; set; }
        public decimal Pamcfbillings { get; set; }
        public decimal PamcbaseProfitAmount { get; set; }
        public decimal PamcforecastBprofitAmt { get; set; }
        public decimal PamcprojectAmount { get; set; }
        public decimal PamcactualBillings { get; set; }
        public decimal PamcactualDiscountAmt { get; set; }
        public decimal PamcactualSalesTaxAmt { get; set; }
        public decimal PamcunpostBillN { get; set; }
        public decimal PamcunpostedDiscount { get; set; }
        public decimal PamcunpostedSalesTax { get; set; }
        public int DexRowId { get; set; }
    }
}
