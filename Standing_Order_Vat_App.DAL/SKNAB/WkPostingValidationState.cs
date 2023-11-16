using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class WkPostingValidationState
    {
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public byte[] Glbchval { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
