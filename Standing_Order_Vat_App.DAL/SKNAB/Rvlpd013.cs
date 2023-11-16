using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd013
    {
        public short Remtype { get; set; }
        public string Remitid { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
