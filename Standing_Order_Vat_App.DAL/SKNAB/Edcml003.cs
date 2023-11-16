using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml003
    {
        public string Curncyid { get; set; } = null!;
        public short MlcLanguage { get; set; }
        public string Curtext1 { get; set; } = null!;
        public string Curtext2 { get; set; } = null!;
        public string Curtext3 { get; set; } = null!;
        public string MlcLocalTermn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
