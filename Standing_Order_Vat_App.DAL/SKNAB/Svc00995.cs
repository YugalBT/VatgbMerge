using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00995
    {
        public string Offid { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public string Escstatus { get; set; } = null!;
        public decimal Trxqty { get; set; }
        public int Waittme { get; set; }
        public int DexRowId { get; set; }
    }
}
