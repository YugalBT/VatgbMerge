using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0300v
    {
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
