using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01303
    {
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal PabaseProfitAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PaforecastBaseQty { get; set; }
        public decimal PaforecastBaseUnitCost { get; set; }
        public decimal PaforecastBaseProfitAmt { get; set; }
        public decimal PabunitCost { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal PabprofitAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public short PabaselinePtaxOptions { get; set; }
        public string PabaselineCtaxSchedId { get; set; } = null!;
        public short PabaselineStaxOptions { get; set; }
        public string PabaselineBtaxSchedId { get; set; } = null!;
        public decimal Pafquantity { get; set; }
        public decimal PafunitCost { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PafprofitAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public short PaforecastPtaxOptions { get; set; }
        public string PaforecastCtaxSchedId { get; set; } = null!;
        public short PaforecastStaxOptions { get; set; }
        public string PaforecastBtaxSchedId { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public string Pricelvl { get; set; } = null!;
        public decimal PauofMmult { get; set; }
        public short Pabllngtype { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal Papstdcosts { get; set; }
        public decimal PapostedAccrRevN { get; set; }
        public decimal PapostedReturnQty { get; set; }
        public decimal PapostedReturnCosts { get; set; }
        public decimal PaactualReturnAccrRev { get; set; }
        public decimal Paunpcosts { get; set; }
        public decimal PaunpQty { get; set; }
        public decimal PaunpostAccrRevN { get; set; }
        public decimal PaunpostedReturnQty { get; set; }
        public decimal PaunpostedReturnCost { get; set; }
        public decimal PaunpostedReturnAccrRev { get; set; }
        public decimal Papocost { get; set; }
        public decimal Papoqty { get; set; }
        public decimal PacommittedCosts { get; set; }
        public decimal PacommittedQty { get; set; }
        public decimal PapopostedQty { get; set; }
        public decimal PapopostedCost { get; set; }
        public DateTime Reqdate { get; set; }
        public int PalineItemSeq { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PaunpostedTaxAmount { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
