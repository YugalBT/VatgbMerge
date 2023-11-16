using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dta00700
    {
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public string Sttacnum1 { get; set; } = null!;
        public string Sttacnum2 { get; set; } = null!;
        public string Sttacnum3 { get; set; } = null!;
        public string Sttacnum4 { get; set; } = null!;
        public string Sttacnum5 { get; set; } = null!;
        public string Sttacnum6 { get; set; } = null!;
        public string Sttacnum7 { get; set; } = null!;
        public string Sttacnum8 { get; set; } = null!;
        public string Sttacnum9 { get; set; } = null!;
        public string Sttacnum10 { get; set; } = null!;
        public string Eaccnbr1 { get; set; } = null!;
        public string Eaccnbr2 { get; set; } = null!;
        public string Eaccnbr3 { get; set; } = null!;
        public string Eaccnbr4 { get; set; } = null!;
        public string Eaccnbr5 { get; set; } = null!;
        public string Eaccnbr6 { get; set; } = null!;
        public string Eaccnbr7 { get; set; } = null!;
        public string Eaccnbr8 { get; set; } = null!;
        public string Eaccnbr9 { get; set; } = null!;
        public string Eaccnbr10 { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Startgrp { get; set; } = null!;
        public string Endgroup { get; set; } = null!;
        public string Strtcode { get; set; } = null!;
        public string Endcode { get; set; } = null!;
        public byte Prntdtld { get; set; }
        public byte Unpsttrx { get; set; }
        public byte Open1 { get; set; }
        public byte History { get; set; }
        public DateTime Sttpstdt { get; set; }
        public DateTime Endpstdt { get; set; }
        public int DexRowId { get; set; }
    }
}
