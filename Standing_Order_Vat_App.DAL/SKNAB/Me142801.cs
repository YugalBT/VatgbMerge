using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142801
    {
        public string Arnum { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
