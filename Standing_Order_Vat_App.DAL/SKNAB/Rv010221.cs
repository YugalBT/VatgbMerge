using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rv010221
    {
        public string EmpidI { get; set; } = null!;
        public DateTime DateoflastreviewI { get; set; }
        public short SeqorderI { get; set; }
        public string ReviewcategoryI { get; set; } = null!;
        public short ReviewweightfactorI { get; set; }
        public decimal NotesindexI { get; set; }
        public string ReviewratingwordI { get; set; } = null!;
        public int ReviewwordsetindexI { get; set; }
        public decimal ReviewscoredollarI { get; set; }
        public int DexRowId { get; set; }
    }
}
