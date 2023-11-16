using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40600
    {
        public string Uscatval { get; set; } = null!;
        public short Uscatnum { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string UserCatLongDescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
