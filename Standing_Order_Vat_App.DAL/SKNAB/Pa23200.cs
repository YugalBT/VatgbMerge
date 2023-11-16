using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23200
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Parefno { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public string Papurordnum { get; set; } = null!;
        public decimal PabillingAmount { get; set; }
        public decimal Patmbillamount { get; set; }
        public decimal Paffbillamount { get; set; }
        public decimal Pafeebillamount { get; set; }
        public decimal Patotbillings { get; set; }
        public short PaDiscountType { get; set; }
        public decimal Trdisamt { get; set; }
        public short PaTradeDiscountPcnt { get; set; }
        public decimal Patottax { get; set; }
        public decimal Patmtaxamt { get; set; }
        public decimal Pafftaxamt { get; set; }
        public decimal Pafeetaxamount { get; set; }
        public decimal Pabackbill { get; set; }
        public decimal Patmbckoutbillamt { get; set; }
        public decimal Papbbckoutbillamt { get; set; }
        public decimal Pafeebckoutbillamt { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Acctamnt { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public decimal PaAppliedRetainer { get; set; }
        public decimal PaAppliedFreightMisc { get; set; }
        public short Agngbukt { get; set; }
        public decimal Curtrxam { get; set; }
        public int PaTradeIdx { get; set; }
        public string Taxschid { get; set; } = null!;
        public decimal PaorigBillAmount { get; set; }
        public decimal PaorigBillingAmtTm { get; set; }
        public decimal PaorigBillingAmtFf { get; set; }
        public decimal PaorigBillingAmtFee { get; set; }
        public decimal PaorigTotalBilings { get; set; }
        public decimal PaorigTotalTaxAmt { get; set; }
        public decimal PaorigTaxAmtTm { get; set; }
        public decimal PaorigTaxAmtFf { get; set; }
        public decimal PaorigTaxAmtFee { get; set; }
        public decimal PaorigBackoutBillAmt { get; set; }
        public decimal PaorigBackoutBillTm { get; set; }
        public decimal PaorigBackoutBillFf { get; set; }
        public decimal PaorigBackoutBillFee { get; set; }
        public decimal PaorigRetentionFeeAmt { get; set; }
        public decimal PaorigRetainerFeeAmt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Oractamt { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal PaorigAppliedDocAmt { get; set; }
        public decimal PaorigAppliedFreightMisc { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public byte PaThirdPartyCb { get; set; }
        public decimal BackoutTradeDiscTax { get; set; }
        public decimal OrigBackoutTradeDiscTax { get; set; }
        public decimal PaBackoutRetentionTax { get; set; }
        public decimal PaOrigBackRetentionTax { get; set; }
        public int DexRowId { get; set; }
    }
}
