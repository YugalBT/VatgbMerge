using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me234603
    {
        public string Chekbkid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public string Userid { get; set; } = null!;
        public string MeEftGenerationTimest { get; set; } = null!;
        public short MeEftStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
