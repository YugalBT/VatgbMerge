using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00106
    {
        public string Custnmbr { get; set; } = null!;
        public short EmailType { get; set; }
        public string EmailRecipient { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
