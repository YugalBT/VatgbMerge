using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahrem602
    {
        public string EmpidI { get; set; } = null!;
        public int DexRowId { get; set; }
        public byte[] PictureI { get; set; } = null!;
    }
}
