using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm20000
    {
        public string Vendorid { get; set; } = null!;
        public int Doctype { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Curtrxam { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Docamnt { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
