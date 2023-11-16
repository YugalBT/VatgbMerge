using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat00300
    {
        public short Ecrectype { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Tcc { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public byte Ecflag { get; set; }
        public string Txrgnnum { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
