using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd10400
    {
        public short Index1 { get; set; }
        public byte Ddautost { get; set; }
        public byte Inclpymt { get; set; }
        public byte Printed { get; set; }
        public string Bldchdid { get; set; } = null!;
        public DateTime Bldchkdt { get; set; }
        public DateTime Bldchtim { get; set; }
        public string Auctrlcd { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Paydate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Chekbkid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
