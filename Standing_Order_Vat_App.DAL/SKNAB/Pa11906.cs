using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11906
    {
        public int PaProjClosingSequence { get; set; }
        public int PalineItemSeq { get; set; }
        public int Jrnentry { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string PafeeId { get; set; } = null!;
        public short PafeeType { get; set; }
        public decimal PafeeAmount { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PabbillingsIdx { get; set; }
        public int ParevIdx { get; set; }
        public int Pabbieeidx { get; set; }
        public int Pabeiebidx { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal PaprevBillings { get; set; }
        public decimal PaprevBieeamount { get; set; }
        public decimal PaprevEiebamount { get; set; }
        public decimal PaprevRecognizedRev { get; set; }
        public decimal PaprevEarnings { get; set; }
        public decimal PapostedEarnings { get; set; }
        public int DexRowId { get; set; }
    }
}
