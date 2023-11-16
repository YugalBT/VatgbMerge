using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me147207
    {
        public string Bachnumb { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
