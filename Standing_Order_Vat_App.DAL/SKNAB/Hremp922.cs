using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hremp922
    {
        public string Userid { get; set; } = null!;
        public short OrganizationlevelI { get; set; }
        public string CodeI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
