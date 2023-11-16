using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml006
    {
        public string Cheknmbr { get; set; } = null!;
        public short MlcLanguage { get; set; }
        public byte MlcEnableMlchecks { get; set; }
        public string Chamcbid { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
