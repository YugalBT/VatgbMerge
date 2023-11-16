using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40300
    {
        public short Soptype { get; set; }
        public string Doctyabr { get; set; } = null!;
        public string Doctynam { get; set; } = null!;
        public string Sopnumbe { get; set; } = null!;
        public short Docuform { get; set; }
        public short Setupkey { get; set; }
        public int DexRowId { get; set; }
    }
}
