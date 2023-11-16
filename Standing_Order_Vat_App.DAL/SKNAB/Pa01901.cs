using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01901
    {
        public short PatranType { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Pacostowner { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public short Dcstatus { get; set; }
        public int DexRowId { get; set; }
    }
}
