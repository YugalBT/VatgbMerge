using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Faindex
    {
        public short Indxname { get; set; }
        public short Indxfilename { get; set; }
        public int Indxvalue { get; set; }
        public int DexRowId { get; set; }
    }
}
