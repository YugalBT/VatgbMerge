using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc30001
    {
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int Actindx { get; set; }
        public short Hstyear { get; set; }
        public short Periodid { get; set; }
        public decimal Functamt { get; set; }
        public decimal Origamt { get; set; }
        public int DexRowId { get; set; }
    }
}
