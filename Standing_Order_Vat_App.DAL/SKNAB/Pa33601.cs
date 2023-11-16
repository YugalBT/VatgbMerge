using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33601
    {
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public short Pabilltrxt { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public decimal Paccaa { get; set; }
        public decimal Pafaa { get; set; }
        public decimal Patta { get; set; }
        public decimal Pawa { get; set; }
        public decimal PaTaxAppliedAmount { get; set; }
        public DateTime Docdate { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
