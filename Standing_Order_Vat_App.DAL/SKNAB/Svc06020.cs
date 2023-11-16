using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06020
    {
        public string Wotype { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Wostat { get; set; } = null!;
        public string Routeid { get; set; } = null!;
        public int Wipinv { get; set; }
        public int Wiplabor { get; set; }
        public byte SvcDoExpense { get; set; }
        public int SvcExpenseIndex { get; set; }
        public int DexRowId { get; set; }
    }
}
