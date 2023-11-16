using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc10301
    {
        public string Bachnumb { get; set; } = null!;
        public short LineNumber { get; set; }
        public string Userid { get; set; } = null!;
        public int Equipid { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public int Meters1 { get; set; }
        public int Meters2 { get; set; }
        public int Meters3 { get; set; }
        public int Meters4 { get; set; }
        public int Meters5 { get; set; }
        public decimal Dailys1 { get; set; }
        public decimal Dailys2 { get; set; }
        public decimal Dailys3 { get; set; }
        public decimal Dailys4 { get; set; }
        public decimal Dailys5 { get; set; }
        public int DexRowId { get; set; }
    }
}
