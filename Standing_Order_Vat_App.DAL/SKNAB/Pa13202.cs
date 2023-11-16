using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa13202
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Passn { get; set; }
        public int PareferenceLineSeqN { get; set; }
        public string Pacostdocno { get; set; } = null!;
        public int Pacostseqno { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public short Patu { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public short Pabllngtype { get; set; }
        public DateTime Pacostdate { get; set; }
        public string Pacostowner { get; set; } = null!;
        public string PaunitOfMeasure { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public short PaprofitType { get; set; }
        public decimal Pabilrate { get; set; }
        public decimal Pamarkpercent { get; set; }
        public decimal PaqtyQ { get; set; }
        public decimal Paacrev { get; set; }
        public decimal Patotcst { get; set; }
        public decimal PawriteUpDownAmount { get; set; }
        public int PawriteUpDownPercenta { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal Paapprovbillrate { get; set; }
        public decimal Paapprovmkuppct { get; set; }
        public decimal PaapprovedBillingAmou { get; set; }
        public decimal ParecognizedRevenue { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Patmtaxamt { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public decimal Pabackbill { get; set; }
        public decimal PaTradeDiscountAmount { get; set; }
        public int PaarIdx { get; set; }
        public int PacogsIdx { get; set; }
        public int ParevIdx { get; set; }
        public int PaunbilledArIdx { get; set; }
        public int PaunbilledProjRevIdx { get; set; }
        public int Pacgbwipidx { get; set; }
        public byte[] PabillSublineErrors { get; set; } = null!;
        public byte PaVariance { get; set; }
        public decimal PaVarianceAccruedReve { get; set; }
        public decimal PaorigUnitCost { get; set; }
        public decimal Paorigbillrate { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal Paorigtotcost { get; set; }
        public decimal PaorigWudamt { get; set; }
        public decimal PaorigApprBillRate { get; set; }
        public decimal PaorigApprBillAmt { get; set; }
        public decimal PaorigRecogRevenue { get; set; }
        public decimal PaorigTaxAmtTm { get; set; }
        public decimal PaorigBackoutBillAmt { get; set; }
        public decimal PaorigTradeDiscAmt { get; set; }
        public decimal PaorigVarAccruedRev { get; set; }
        public string Pachgordno { get; set; } = null!;
        public decimal BackoutTradeDisc { get; set; }
        public decimal OrigBackoutTradeDisc { get; set; }
        public int DexRowId { get; set; }
    }
}
