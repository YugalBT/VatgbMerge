using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00303
    {
        public int AaDistrQueryId { get; set; }
        public short AaColumn { get; set; }
        public int AaOrder { get; set; }
        public short AaSortOrder { get; set; }
        public int DexRowId { get; set; }
    }
}
