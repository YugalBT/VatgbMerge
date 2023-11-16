using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm10301
    {
        public string Custnmbr { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Acctamnt { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
