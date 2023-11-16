using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pav43100
    {
        public short PatranType { get; set; }
        public short Dcstatus { get; set; }
        public DateTime Padocdt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Pacostowner { get; set; } = null!;
        public short Pabilltrxt { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
