using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv41001
    {
        public DateTime Exceptiondate { get; set; }
        public short Datetype { get; set; }
        public int DexRowId { get; set; }
    }
}
