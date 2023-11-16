using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml007
    {
        public string Vendorid { get; set; } = null!;
        public string Vadcdtro { get; set; } = null!;
        public short MlcLanguage { get; set; }
        public byte MlcEnableMlchecks { get; set; }
        public int DexRowId { get; set; }
    }
}
