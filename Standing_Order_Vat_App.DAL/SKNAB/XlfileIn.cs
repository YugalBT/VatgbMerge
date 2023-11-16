using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class XlfileIn
    {
        public int Fileidx { get; set; }
        public string Budgetid { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string Worksht { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
