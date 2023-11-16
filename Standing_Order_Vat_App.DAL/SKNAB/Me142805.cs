using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142805
    {
        public string Bachnumb { get; set; } = null!;
        public string Pmntnmbr { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
