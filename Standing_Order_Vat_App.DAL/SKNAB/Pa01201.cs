using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01201
    {
        public string Custnmbr { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string Pacontid { get; set; } = null!;
        public string Paprojid { get; set; } = null!;
        public string Paprojname { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string Paprjclsid { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public short Currnidx { get; set; }
        public string Papurordnum { get; set; } = null!;
        public DateTime PabbeginDate { get; set; }
        public DateTime PabendDate { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabprofit { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public DateTime Paactualbegdate { get; set; }
        public DateTime PaActualEndDate { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafprofit { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public byte PacloseProjcosts { get; set; }
        public byte Paclosetobillings { get; set; }
        public string Padepartment { get; set; } = null!;
        public string PaestimatorId { get; set; } = null!;
        public string Paprojmngrid { get; set; } = null!;
        public string PabusMgrId { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Comprcnt { get; set; }
        public short Comappto { get; set; }
        public string Cntcprsn { get; set; } = null!;
        public string Prbtadcd { get; set; } = null!;
        public string PalaborRateTableId { get; set; } = null!;
        public short PalaborRateTableType { get; set; }
        public byte PalaborRateTableAcc { get; set; }
        public string PaequipRateTableId { get; set; } = null!;
        public byte PaequipRateTableAcc { get; set; }
        public short Pabllngtype { get; set; }
        public decimal PaserviceFeeAmount { get; set; }
        public decimal PaprojectFeeAmount { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal Acctamnt { get; set; }
        public string Pabillformat { get; set; } = null!;
        public short Dscpctam { get; set; }
        public decimal PaRetentionPercent { get; set; }
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public byte Patotcbfee { get; set; }
        public string Paud1proj { get; set; } = null!;
        public string Paud2Proj { get; set; } = null!;
        public byte PasegmentCb { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Pabillnoteidxts { get; set; }
        public decimal Paelbillniteidx { get; set; }
        public decimal PabillnoteidxMl { get; set; }
        public decimal Pabillnoteidxvi { get; set; }
        public decimal Pabillnoteidxee { get; set; }
        public decimal Pabillnoteidxinv { get; set; }
        public decimal Pabillnoteidxfee { get; set; }
        public decimal PaunpostedQty { get; set; }
        public decimal PaunpostedTotalCostN { get; set; }
        public decimal PaunpostedOverhead { get; set; }
        public decimal PaunpostedProfitN { get; set; }
        public decimal PaunpostedTaxAmount { get; set; }
        public decimal PaunpostAccrRevN { get; set; }
        public decimal PaunpostedRecogRevN { get; set; }
        public decimal PaunpostedCommitedQty { get; set; }
        public decimal PaunpostedCommitedCost { get; set; }
        public decimal PaunpostedCommitedTaxAmt { get; set; }
        public decimal PaunpostedProjectFee { get; set; }
        public decimal PaunpostedRetainerFee { get; set; }
        public decimal PaunpostedServiceFee { get; set; }
        public decimal Paunpostretamt { get; set; }
        public decimal Paunpostbieeamount { get; set; }
        public decimal Paunpeiebamount { get; set; }
        public decimal PaUnpostedBilledReten { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal PapostedProfitN { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal PapostedAccrRevN { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal PapostedCommitedQty { get; set; }
        public decimal PapostedCommitedCost { get; set; }
        public decimal PapostedCommitedTaxAmt { get; set; }
        public decimal PapostedProjectFee { get; set; }
        public decimal PapostedRetainerFee { get; set; }
        public decimal PapostedServiceFee { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal PaActualBilledRetenti { get; set; }
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
        public decimal Noteindx { get; set; }
        public decimal PapostedOverhead { get; set; }
        public decimal PaapprovedAccruedReve { get; set; }
        public decimal PaapprovedCost { get; set; }
        public decimal PaapprovedQuantity { get; set; }
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
        public decimal Papretainage { get; set; }
        public decimal Paunpretainage { get; set; }
        public decimal PaWriteOffTaxAmount { get; set; }
        public decimal PaactualWotaxAmt { get; set; }
        public decimal PaTermsTakenTaxAmt { get; set; }
        public decimal PaactualTermsTakenTax { get; set; }
        public string Wrkrcomp { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public decimal PaActualBillingNotRm { get; set; }
        public decimal PaActualDiscnotRm { get; set; }
        public byte PaRestrictCustomerList { get; set; }
        public decimal PapostedEarnings { get; set; }
        public decimal PaactualCostofEarnings { get; set; }
        public decimal PaunpostedLossAmount { get; set; }
        public decimal PaactualLossAmount { get; set; }
        public decimal PafqlaborOnly { get; set; }
        public decimal PaaqlaborOnly { get; set; }
        public string Pamccurncyid { get; set; } = null!;
        public decimal PamcprojectAmount { get; set; }
        public decimal PamcunpostBillN { get; set; }
        public decimal PamcunpostedSalesTax { get; set; }
        public decimal PamcunpostedDiscount { get; set; }
        public decimal PamcactualBillings { get; set; }
        public decimal PamcactualSalesTaxAmt { get; set; }
        public decimal PamcactualDiscountAmt { get; set; }
        public decimal Pamcbbillings { get; set; }
        public decimal Pamcfbillings { get; set; }
        public decimal PaMcProjectFeeAmount { get; set; }
        public decimal PaMcServiceFeeAmount { get; set; }
        public decimal PaMcRetainerFeeAmt { get; set; }
        public decimal PaMcUnpostedProjectFee { get; set; }
        public decimal PaMcUnpostedRetainer { get; set; }
        public decimal PaMcUnpostedServiceFee { get; set; }
        public decimal PaMcActualProjectFee { get; set; }
        public decimal PaMcActualRetainerFee { get; set; }
        public decimal PaMcActualServiceFee { get; set; }
        public int DexRowId { get; set; }
    }
}
