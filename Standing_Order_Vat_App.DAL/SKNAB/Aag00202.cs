using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00202
    {
        public int AaAcctClassId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeIddflt { get; set; }
        public short AaDataEntry { get; set; }
        public byte AaShow { get; set; }
        public int DexRowId { get; set; }
    }
}
