using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23302
    {
        public int Lnitmseq { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public DateTime Cutofdat { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public string Paprojname { get; set; } = null!;
        public byte PasegmentCb { get; set; }
        public short PaCombineMode { get; set; }
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public decimal PapercentCompleted { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PapostCost { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PaActualCostContract { get; set; }
        public decimal PaActualQtyContract { get; set; }
        public decimal ParevenueEarned { get; set; }
        public decimal Pareb { get; set; }
        public decimal Paref { get; set; }
        public decimal PaCostOfEarnings { get; set; }
        public decimal PabrecognizedProjAmt { get; set; }
        public decimal PabrecognizedBudgAmount { get; set; }
        public decimal ParecognizedFeeAmount { get; set; }
        public decimal Pabieeamount { get; set; }
        public decimal Paeiebamount { get; set; }
        public byte[] Parrlneerr { get; set; } = null!;
        public decimal PaActualCostLossTest { get; set; }
        public decimal PaProjAmtLossTest { get; set; }
        public decimal PaActualRecogRevLossT { get; set; }
        public decimal PaActualBlgsXcessTest { get; set; }
        public decimal PaEarningsXcessTest { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal PalossAmount { get; set; }
        public decimal PafqlaborOnly { get; set; }
        public decimal PaftclaborOnly { get; set; }
        public decimal PaaqlaborOnly { get; set; }
        public decimal PaaclaborOnly { get; set; }
        public int DexRowId { get; set; }
    }
}
