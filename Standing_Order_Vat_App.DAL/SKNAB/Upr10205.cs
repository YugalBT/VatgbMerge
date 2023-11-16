using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10205
    {
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public short Pyrntype { get; set; }
        public string Employid { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public byte Taxable { get; set; }
        public byte Varbenft { get; set; }
        public decimal Vardbamt { get; set; }
        public int Vardbpct { get; set; }
        public short Bnftfreq { get; set; }
        public decimal Totlbnft { get; set; }
        public decimal Amtbotip { get; set; }
        public string Bchsourc { get; set; } = null!;
        public int Prtrxsrc { get; set; }
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public byte[] Bldchwrg { get; set; } = null!;
        public byte[] Bldcherr { get; set; } = null!;
        public short Bnftmthd { get; set; }
        public short Prcssqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
