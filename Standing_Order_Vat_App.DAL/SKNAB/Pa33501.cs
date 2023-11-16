using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33501
    {
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PaReceiptsAmount { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public int PaProjClosingSequence { get; set; }
        public int Lnitmseq { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public int Jrnentry { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public DateTime Paactualbegdate { get; set; }
        public DateTime PaActualEndDate { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
