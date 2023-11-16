using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40201
    {
        public short Soptype { get; set; }
        public string Docid { get; set; } = null!;
        public string Prchldid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
