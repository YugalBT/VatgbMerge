using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp400002
    {
        public short Wintype { get; set; }
        public string Userid { get; set; } = null!;
        public string Cmpnynam { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public byte Posting { get; set; }
        public string Trxsourc { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
