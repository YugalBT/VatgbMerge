using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm40000
    {
        public string Vendorid { get; set; } = null!;
        public string Ponumber { get; set; } = null!;
        public short Postatus { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Amount { get; set; }
        public int DexRowId { get; set; }
    }
}
