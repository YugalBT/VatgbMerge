using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33202
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public DateTime Cutofdat { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public short PaacctgMethod { get; set; }
        public decimal Patotcst { get; set; }
        public decimal Patqty { get; set; }
        public decimal PapercentCompleted { get; set; }
        public decimal Paffbillamount { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public decimal Pafftaxamt { get; set; }
        public int Lnitmseq { get; set; }
        public decimal Pabackbill { get; set; }
        public short Patu { get; set; }
        public decimal PacostPcntCompleted { get; set; }
        public decimal PaquantityPcntCompleted { get; set; }
        public decimal PaobservedPcntCompleted { get; set; }
        public decimal PaamountEarned { get; set; }
        public decimal PapreviouslyBilled { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public int PaarIdx { get; set; }
        public int PabillRevAcctIdx { get; set; }
        public decimal PaTradeDiscountAmount { get; set; }
        public int PaRetentionIdx { get; set; }
        public decimal Paorigtotcost { get; set; }
        public decimal PaorigBillingAmtFf { get; set; }
        public decimal PaorigRetentionFeeAmt { get; set; }
        public decimal PaorigTaxAmtFf { get; set; }
        public decimal PaorigBackoutBillAmt { get; set; }
        public decimal PaorigAmtEarned { get; set; }
        public decimal PaorigPrevBill { get; set; }
        public decimal PaorigTradeDiscAmt { get; set; }
        public decimal PaPreviousRetention { get; set; }
        public decimal Paoprevretention { get; set; }
        public string Pachgordno { get; set; } = null!;
        public decimal PaBackoutRetentionAmt { get; set; }
        public decimal PaOrigBackRetentionAmt { get; set; }
        public int DexRowId { get; set; }
    }
}
