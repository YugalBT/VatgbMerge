using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01251
    {
        public string Paprojnumber { get; set; } = null!;
        public decimal Agperamt1 { get; set; }
        public decimal Agperamt2 { get; set; }
        public decimal Agperamt3 { get; set; }
        public decimal Agperamt4 { get; set; }
        public decimal Agperamt5 { get; set; }
        public decimal Agperamt6 { get; set; }
        public decimal Agperamt7 { get; set; }
        public decimal Paacrev { get; set; }
        public DateTime Lastaged { get; set; }
        public int DexRowId { get; set; }
    }
}
