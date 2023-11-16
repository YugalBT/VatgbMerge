using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy00900
    {
        public string Sourcdoc { get; set; } = null!;
        public string Sdocdscr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Lstusred { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
