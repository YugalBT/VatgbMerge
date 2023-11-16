using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Lk4000
    {
        public string Finrptnm { get; set; } = null!;
        public string Stacnmst { get; set; } = null!;
        public string EndAccountNumberString { get; set; } = null!;
        public short Iffilxst { get; set; }
        public byte Askechtm { get; set; }
        public short LkStartTokenDate { get; set; }
        public short LkendTokenDate { get; set; }
        public short Prrptfor { get; set; }
        public string Prvyrcmb { get; set; } = null!;
        public byte Prtoscrn { get; set; }
        public byte Prtoprtr { get; set; }
        public short Expttype { get; set; }
        public byte Prntofil { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Reportid { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
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
        public int Strtjrnl { get; set; }
        public int Endjrnal { get; set; }
        public string Ssrcedoc { get; set; } = null!;
        public string Endsrcdc { get; set; } = null!;
        public string Strxsrc { get; set; } = null!;
        public string LkStartGroup { get; set; } = null!;
        public string LkEndGroup { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public int StartLkLinkNo { get; set; }
        public int EndLkLinkNo { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Sttusrid { get; set; } = null!;
        public string Endusrid { get; set; } = null!;
        public short Sortby { get; set; }
        public decimal LkLinkBalance { get; set; }
        public byte MulticurrencyInformation { get; set; }
        public int DexRowId { get; set; }
    }
}
