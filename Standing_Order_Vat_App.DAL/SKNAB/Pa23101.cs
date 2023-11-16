using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23101
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public decimal Cashamnt { get; set; }
        public decimal Crcrdamt { get; set; }
        public decimal Chekamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
