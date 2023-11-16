using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00302
    {
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public int Oldequipid { get; set; }
        public string Oldsernbr { get; set; } = null!;
        public string Olditemnbr { get; set; } = null!;
        public string Oldrefid { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
