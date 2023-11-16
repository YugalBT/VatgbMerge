using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41201
    {
        public string Emplclas { get; set; } = null!;
        public short Pyrlrtyp { get; set; }
        public string Payrolcd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
