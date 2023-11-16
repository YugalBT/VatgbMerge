using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl11000
    {
        public string Bachnumb { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Trxamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
