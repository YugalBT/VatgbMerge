using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben05
    {
        public string BenefittypeI { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
