using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11901
    {
        public string Paprojnumber { get; set; } = null!;
        public DateTime Paactualbegdate { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public byte PasegmentCb { get; set; }
        public int Lnitmseq { get; set; }
        public int PaProjClosingSequence { get; set; }
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal Acctamnt { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PaReceiptsAmount { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public byte PachecklistComplete { get; set; }
        public byte PacloseCb { get; set; }
        public int DexRowId { get; set; }
    }
}
