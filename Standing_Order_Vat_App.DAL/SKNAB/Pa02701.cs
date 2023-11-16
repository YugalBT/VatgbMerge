using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02701
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public short Pacostatus { get; set; }
        public short Pacotype { get; set; }
        public short Dcstatus { get; set; }
        public int DexRowId { get; set; }
    }
}
