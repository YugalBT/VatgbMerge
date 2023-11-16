using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext45000
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short Rcrdtype { get; set; }
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public byte SortListCb { get; set; }
        public int DexRowId { get; set; }
    }
}
