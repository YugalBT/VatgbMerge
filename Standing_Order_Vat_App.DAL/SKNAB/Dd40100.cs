using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd40100
    {
        public string Ddsetpid { get; set; } = null!;
        public string Ddcompnm { get; set; } = null!;
        public string Ddcoiden { get; set; } = null!;
        public string Ddimdest { get; set; } = null!;
        public string Ddimdenm { get; set; } = null!;
        public string Ddimorig { get; set; } = null!;
        public string Ddimornm { get; set; } = null!;
        public string Ddorgdfi { get; set; } = null!;
        public string Ddtranum { get; set; } = null!;
        public string Ddactnum { get; set; } = null!;
        public string Ddindnam { get; set; } = null!;
        public string Ddtrans { get; set; } = null!;
        public string Dddisc20 { get; set; } = null!;
        public string Dddesc10 { get; set; } = null!;
        public short Ddempinf { get; set; }
        public string Dddestin { get; set; } = null!;
        public string Ddnxtach { get; set; } = null!;
        public byte Ddincach { get; set; }
        public short Ddhead { get; set; }
        public short Ddfoot { get; set; }
        public byte Ddautost { get; set; }
        public short Ddhanddep { get; set; }
        public short Dddayspay2post { get; set; }
        public string Ddnextdepno { get; set; } = null!;
        public byte Ddmaskdlr { get; set; }
        public byte Ddvoided { get; set; }
        public short Ddprecnt { get; set; }
        public string Ddexceptlist { get; set; } = null!;
        public short Ddpopset { get; set; }
        public short Ddactivi { get; set; }
        public short Ddbankre { get; set; }
        public short Ddservicecode { get; set; }
        public short EftpaymentMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
