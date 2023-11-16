using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01241
    {
        public string Paprojnumber { get; set; } = null!;
        public byte Patrkchgords { get; set; }
        public byte Patrkcobdgaddfly { get; set; }
        public decimal Patotchgordamt { get; set; }
        public short Panopendco { get; set; }
        public short Panumco { get; set; }
        public decimal Pacobaseprojamt { get; set; }
        public decimal Paunprrtotprojamt { get; set; }
        public decimal Pacobslnfeeprojamt { get; set; }
        public decimal Paunabstotbill { get; set; }
        public decimal Paunpbstotcst { get; set; }
        public decimal Paunpbsltotprof { get; set; }
        public decimal Paunpbstotqty { get; set; }
        public decimal Paunapfrtotbill { get; set; }
        public decimal Paunappfrtotcst { get; set; }
        public decimal Paunfrctotprof { get; set; }
        public decimal Paunpfrtotqty { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal PapostedOverhead { get; set; }
        public decimal PapostedProfitN { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal Paacrev { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal Papostbillamt { get; set; }
        public decimal PaActualReceiptsAmoun { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PapostedDiscDolAmtN { get; set; }
        public decimal PapostedSalesTaxAmou { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
        public decimal Paactjtaxpd { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal PaactualWotaxAmt { get; set; }
        public decimal PaactualTermsTakenTax { get; set; }
        public decimal PapostedProjectFee { get; set; }
        public decimal PapostedRetainerFee { get; set; }
        public decimal PapostedServiceFee { get; set; }
        public int DexRowId { get; set; }
    }
}
