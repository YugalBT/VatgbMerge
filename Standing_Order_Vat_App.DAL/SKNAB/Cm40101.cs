using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm40101
    {
        public short CmsortType { get; set; }
        public short CmtrxType { get; set; }
        public string Doctynam { get; set; } = null!;
        public string Docabrev { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
