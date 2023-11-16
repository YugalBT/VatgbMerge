using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00403
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeBoolId { get; set; }
        public byte AaTrxDimCodeBool { get; set; }
        public int DexRowId { get; set; }
    }
}
