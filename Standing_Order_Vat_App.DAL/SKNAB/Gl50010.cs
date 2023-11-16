using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl50010
    {
        public string Userid { get; set; } = null!;
        public string Yearid { get; set; } = null!;
        public short Amntfrom { get; set; }
        public int Actindx { get; set; }
        public int Sqlsesid { get; set; }
        public int DexRowId { get; set; }
    }
}
