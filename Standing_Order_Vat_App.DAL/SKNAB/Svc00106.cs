using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00106
    {
        public string Vendorid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public byte RtvDefaultShipToLoca { get; set; }
        public int DexRowId { get; set; }
    }
}
