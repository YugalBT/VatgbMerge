using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aempnote
    {
        public string EmpidI { get; set; } = null!;
        public string SsnI { get; set; } = null!;
        public string LlastnameI { get; set; } = null!;
        public string FfirstnameI { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Comments32000I { get; set; } = null!;
    }
}
