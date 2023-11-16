using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33302
    {
        public string Padocnumber20 { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Custnmbr { get; set; } = null!;
        public DateTime Cutofdat { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Paprojname { get; set; } = null!;
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public byte PacbrecogRev { get; set; }
        public short Patu { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PapostCost { get; set; }
        public decimal PapostedQtyStdn { get; set; }
        public decimal PapercentCompleted { get; set; }
        public decimal Pareb { get; set; }
        public decimal PaCostOfEarnings { get; set; }
        public decimal PabrecognizedBudgAmount { get; set; }
        public decimal Pabieeamount { get; set; }
        public decimal Paeiebamount { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PaTradeDiscountAmount { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PabbillingsIdx { get; set; }
        public int PabexpenseIdx { get; set; }
        public int PablossIdx { get; set; }
        public int ParevIdx { get; set; }
        public int Pabeiebidx { get; set; }
        public int Pabbieeidx { get; set; }
        public byte[] PacgbrrsublineErrorsB { get; set; } = null!;
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
        public decimal PaprevLossAmount { get; set; }
        public decimal PaprevBillings { get; set; }
        public decimal PaprevCost { get; set; }
        public int DexRowId { get; set; }
    }
}
