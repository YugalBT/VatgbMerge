using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33201
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public DateTime Cutofdat { get; set; }
        public int Lnitmseq { get; set; }
        public string PafeeId { get; set; } = null!;
        public decimal Pafeebillamount { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PapreviouslyBilled { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public decimal Pafeetaxamount { get; set; }
        public decimal Pabackbill { get; set; }
        public short PafeeType { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public int PaProjectSalesIdx { get; set; }
        public int PaarIdx { get; set; }
        public int PaDeferredRevIdx { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PabprojectBlgsIdx { get; set; }
        public int PaFfArIdx { get; set; }
        public int PabprojectRevenueIdx { get; set; }
        public int PaRetentionAr { get; set; }
        public int PaFfDeferredRevIdx { get; set; }
        public decimal PaTradeDiscountAmount { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public int PaRetentionIdx { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal PaorigBillingAmtFee { get; set; }
        public decimal PaorigFeeAmount { get; set; }
        public decimal PaorigPrevBill { get; set; }
        public decimal PaorigTaxAmtFee { get; set; }
        public decimal PaorigBackoutBillAmt { get; set; }
        public decimal PaorigTradeDiscAmt { get; set; }
        public decimal PaorigRetentionFeeAmt { get; set; }
        public decimal PaPreviousRetention { get; set; }
        public decimal Paoprevretention { get; set; }
        public string Pachgordno { get; set; } = null!;
        public decimal BackoutTradeDisc { get; set; }
        public decimal OrigBackoutTradeDisc { get; set; }
        public decimal PaBackoutRetentionAmt { get; set; }
        public decimal PaOrigBackRetentionAmt { get; set; }
        public int DexRowId { get; set; }
    }
}
