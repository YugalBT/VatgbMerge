using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00402
    {
        public string Paprojnumber { get; set; } = null!;
        public string PafeeId { get; set; } = null!;
        public short PafeeType { get; set; }
        public decimal PafeeAmount { get; set; }
        public DateTime PaubeginDate { get; set; }
        public DateTime PauendDate { get; set; }
        public decimal PaunpostedFeeAmount { get; set; }
        public decimal PaunpostedTaxAmount { get; set; }
        public decimal Paunpostbieeamount { get; set; }
        public decimal Paunpeiebamount { get; set; }
        public decimal PaunpostedRecogRevN { get; set; }
        public decimal PaUnpostedBilledReten { get; set; }
        public decimal PaunpostDiscDolAmtN { get; set; }
        public decimal PaunpostBillN { get; set; }
        public decimal PapostedFeeAmount { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal PaActualBilledRetenti { get; set; }
        public decimal PapostedDiscDolAmtN { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public DateTime Paactualbegdate { get; set; }
        public DateTime PaActualEndDate { get; set; }
        public decimal PaReceiptsAmount { get; set; }
        public decimal PaActualReceiptsAmoun { get; set; }
        public decimal PaEarnings { get; set; }
        public decimal PaCostOfEarnings { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal Distknam { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
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
        public decimal PaMcFeeAmount { get; set; }
        public decimal PaMcUnpostedFeeAmt { get; set; }
        public decimal PaMcUnpostedTaxAmt { get; set; }
        public decimal PaMcUnpostedDiscount { get; set; }
        public decimal PamcunpostBillN { get; set; }
        public decimal PaMcActualFeeAmount { get; set; }
        public decimal PaMcActualTaxAmount { get; set; }
        public decimal PaMcActualDiscount { get; set; }
        public decimal PamcactualBillings { get; set; }
        public int DexRowId { get; set; }
    }
}
