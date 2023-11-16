using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa40202
    {
        public string Pactid { get; set; } = null!;
        public string Paptid { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal PabaseProfitAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PabunitCost { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal PabprofitAmt { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PafunitCost { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PafprofitAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public string Uofm { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal PauofMmult { get; set; }
        public string Pricelvl { get; set; } = null!;
        public short Pabllngtype { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public string Pacostaxscheduleid { get; set; } = null!;
        public short PasalesTaxOptions { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public int PalineItemSeq { get; set; }
        public DateTime Reqdate { get; set; }
        public int DexRowId { get; set; }
    }
}
