using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa05100a
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public short Dcstatus { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public decimal PabillingAmount { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Curtrxam { get; set; }
        public int DexRowId { get; set; }
    }
}
