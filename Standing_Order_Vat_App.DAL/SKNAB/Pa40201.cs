using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa40201
    {
        public string Pactid { get; set; } = null!;
        public string Paptid { get; set; } = null!;
        public short Patu { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public short Pastat { get; set; }
        public short PaprofitType { get; set; }
        public short Pabllngtype { get; set; }
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal PabaseProfitAmount { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal PaforecastBaseOvrhdAmt { get; set; }
        public DateTime PabbeginDate { get; set; }
        public DateTime PabendDate { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PabunitCost { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal Pabprofit { get; set; }
        public decimal PabprofitAmt { get; set; }
        public decimal PabprofitPcnt { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public decimal PaforecastBaseQty { get; set; }
        public decimal PaforecastBaseUnitCost { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PafunitCost { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal Pafprofit { get; set; }
        public decimal PafprofitAmt { get; set; }
        public decimal PafprofitPcnt { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal PauofMmult { get; set; }
        public short Decplqty { get; set; }
        public string PapayCodeHourly { get; set; } = null!;
        public string PapayCodeSalary { get; set; } = null!;
        public short Decplcur { get; set; }
        public string PalaborRateTableId { get; set; } = null!;
        public short PalaborRateTableType { get; set; }
        public byte PalaborRateTableAcc { get; set; }
        public string PaequipRateTableId { get; set; } = null!;
        public byte PaequipRateTableAcc { get; set; }
        public short TmWipSrc { get; set; }
        public short TmCogsSrc { get; set; }
        public short TmCostContraSrc { get; set; }
        public short TmUnbilledArSrc { get; set; }
        public short TmUnbilledRevSrc { get; set; }
        public short TmArSrc { get; set; }
        public short TmPrjRevSrc { get; set; }
        public short TmOvhdSrc { get; set; }
        public short FfWipSrc { get; set; }
        public short FfCostContraSrc { get; set; }
        public short FfArSrc { get; set; }
        public short FfPrjBillingsSrc { get; set; }
        public short FfPrjExpenseSrc { get; set; }
        public short FfPrjRevenueSrc { get; set; }
        public short FfPrjLossSrc { get; set; }
        public short FfBieeSrc { get; set; }
        public short FfEiebSrc { get; set; }
        public short FfOvhdSrc { get; set; }
        public string Pacostaxscheduleid { get; set; } = null!;
        public short PapurchaseTaxOptions { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public short PasalesTaxOptions { get; set; }
        public decimal PaprojectAmount { get; set; }
        public short PaoverheadRateMethod { get; set; }
        public decimal PabaselineOvhdAmtPerUnit { get; set; }
        public decimal PabaselineOvrhdPct { get; set; }
        public decimal PaforecastOvrhdAmtPerUnt { get; set; }
        public decimal PaforecastOvrhdPct { get; set; }
        public int Lnitmseq { get; set; }
        public int PalineItemSeq { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public int DexRowId { get; set; }
    }
}
