using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml005
    {
        public string Bachnumb { get; set; } = null!;
        public short MlcLanguage { get; set; }
        public byte MlcEnableMlchecks { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
