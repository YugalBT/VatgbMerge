using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23303
    {
        public string Padocnumber20 { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Custnmbr { get; set; } = null!;
        public DateTime Cutofdat { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public string PafeeId { get; set; } = null!;
        public short PafeeType { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PapercentCompleted { get; set; }
        public decimal Paref { get; set; }
        public decimal PaCostOfEarnings { get; set; }
        public decimal ParecognizedFeeAmount { get; set; }
        public byte PacbrecogRev { get; set; }
        public decimal Pabieeamount { get; set; }
        public decimal Paeiebamount { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PaTradeDiscountAmount { get; set; }
        public int PaSalesIdx { get; set; }
        public int PaarIdx { get; set; }
        public int PaDeferredRevIdx { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PabbillingsIdx { get; set; }
        public int ParevIdx { get; set; }
        public int PaRetentionAr { get; set; }
        public int Pabbieeidx { get; set; }
        public int Pabeiebidx { get; set; }
        public byte[] PaRrSublineErrorsFee { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public decimal PaActualCostLossTest { get; set; }
        public decimal PaProjAmtLossTest { get; set; }
        public decimal PaActualRecogRevLossT { get; set; }
        public decimal PaActualBlgsXcessTest { get; set; }
        public decimal PaEarningsXcessTest { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal PalossAmount { get; set; }
        public decimal PaprevRecognizedRev { get; set; }
        public decimal PaprevBieeamount { get; set; }
        public decimal PaprevEiebamount { get; set; }
        public decimal PaprevEarnings { get; set; }
        public decimal PaprevBillings { get; set; }
        public int DexRowId { get; set; }
    }
}
