using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01304
    {
        public string Paprojnumber { get; set; } = null!;
        public short Patu { get; set; }
        public short Pasfid { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public DateTime PaperiodStartDate { get; set; }
        public DateTime PaperiodEndDate { get; set; }
        public DateTime Perioddt { get; set; }
        public DateTime Paactualbegdate { get; set; }
        public DateTime PaActualEndDate { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PabunitCost { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabprofit { get; set; }
        public decimal PabprofitAmt { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PafunitCost { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafprofit { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public int Lnitmseq { get; set; }
        public decimal PaunpostedQty { get; set; }
        public decimal PaunpostedTotalCostN { get; set; }
        public decimal PaunpostedOverhead { get; set; }
        public decimal PaunpostedProfitN { get; set; }
        public decimal PaunpostedTaxAmount { get; set; }
        public decimal PaunpostAccrRevN { get; set; }
        public decimal PaunpostedCommitedQty { get; set; }
        public decimal PaunpostedCommitedCost { get; set; }
        public decimal PaunpostedCommitedTaxAmt { get; set; }
        public decimal PaunpostedRecogRevN { get; set; }
        public decimal PaunpostedFeeAmount { get; set; }
        public decimal Paunpostbieeamount { get; set; }
        public decimal Paunpeiebamount { get; set; }
        public decimal PaUnpostedBilledReten { get; set; }
        public decimal Paunpostbillamt { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal PapostedOverhead { get; set; }
        public decimal PapostedProfitN { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal PapostedAccrRevN { get; set; }
        public decimal PapostedCommitedQty { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal PapostedCommitedCost { get; set; }
        public decimal PapostedCommitedTaxAmt { get; set; }
        public decimal PapostedFeeAmount { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal PaActualBilledRetenti { get; set; }
        public decimal Papostbillamt { get; set; }
        public decimal PawriteUpDownAmount { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal ParemainingQuantity { get; set; }
        public decimal PabilledQtyN { get; set; }
        public decimal PaapprovedCost { get; set; }
        public decimal ParemainingCost { get; set; }
        public decimal PabilledCost { get; set; }
        public decimal PaapprovedAccruedReve { get; set; }
        public decimal ParemainingAccruedRev { get; set; }
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
        public decimal Wrofamnt { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal Distknam { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
        public decimal PacommittedCosts { get; set; }
        public decimal PacommittedQty { get; set; }
        public decimal Papocost { get; set; }
        public decimal Papoqty { get; set; }
        public decimal PapopostedCost { get; set; }
        public decimal PapopostedQty { get; set; }
        public decimal Pataxpaidamt { get; set; }
        public decimal PapostedTaxPaidN { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal Paunpostretamt { get; set; }
        public decimal PaWriteOffTaxAmount { get; set; }
        public decimal PaactualWotaxAmt { get; set; }
        public decimal PaTermsTakenTaxAmt { get; set; }
        public decimal PaactualTermsTakenTax { get; set; }
        public decimal PapostedEarnings { get; set; }
        public decimal PaactualCostofEarnings { get; set; }
        public decimal PaunpostedLossAmount { get; set; }
        public decimal PaactualLossAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
