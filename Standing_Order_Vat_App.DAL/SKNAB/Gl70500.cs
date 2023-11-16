using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl70500
    {
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public byte Askechtm { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Prnttype { get; set; }
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Reportid { get; set; }
        public string Finrptnm { get; set; } = null!;
        public short Stgenint1 { get; set; }
        public short Endgenint1 { get; set; }
        public short Stgenint2 { get; set; }
        public short Endgenint2 { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public short Sttcateg { get; set; }
        public string Sttudef1 { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public short Endcateg { get; set; }
        public string Sttcatnm { get; set; } = null!;
        public string Endcatnm { get; set; } = null!;
        public int Strtjrnl { get; set; }
        public int Endjrnal { get; set; }
        public string Strxsrc { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public string Strtcmtrxnum { get; set; } = null!;
        public string Endcmtrxnum { get; set; } = null!;
        public string Ssrcedoc { get; set; } = null!;
        public string Endsrcdc { get; set; } = null!;
        public string Sttacdsc { get; set; } = null!;
        public string Endacdsc { get; set; } = null!;
        public string Stbdbsid { get; set; } = null!;
        public string Enbdbsid { get; set; } = null!;
        public string Stbdbsds { get; set; } = null!;
        public string Enbdbsds { get; set; } = null!;
        public string Stchbkid { get; set; } = null!;
        public string Enchbkid { get; set; } = null!;
        public string Strtdscr { get; set; } = null!;
        public string Enddescr { get; set; } = null!;
        public string Sttsegid { get; set; } = null!;
        public string Endsegid { get; set; } = null!;
        public string Stctrnum { get; set; } = null!;
        public string Encntnum { get; set; } = null!;
        public string Stdocnum { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public string Stmastid { get; set; } = null!;
        public string Enmastid { get; set; } = null!;
        public string Stmastnm { get; set; } = null!;
        public string Enmastnm { get; set; } = null!;
        public short Sortby { get; set; }
        public byte Cbinacts { get; set; }
        public short Pstngact { get; set; }
        public short Unitacct { get; set; }
        public short Rprtshow { get; set; }
        public short Prrptfor { get; set; }
        public string Prvyrcmb { get; set; } = null!;
        public short Rptdetal { get; set; }
        public byte Indivdul1 { get; set; }
        public byte Indivdul2 { get; set; }
        public byte Indivdul3 { get; set; }
        public byte Indivdul4 { get; set; }
        public byte Indivdul5 { get; set; }
        public byte Indivdul6 { get; set; }
        public byte Indivdul7 { get; set; }
        public byte Indivdul8 { get; set; }
        public byte Indivdul9 { get; set; }
        public byte Indivdul10 { get; set; }
        public byte Indivdul11 { get; set; }
        public byte Indivdul12 { get; set; }
        public byte Indivdul13 { get; set; }
        public byte Indivdul14 { get; set; }
        public byte Indivdul15 { get; set; }
        public byte Indivdul16 { get; set; }
        public byte Indivdul17 { get; set; }
        public byte Indivdul18 { get; set; }
        public byte Indivdul19 { get; set; }
        public byte Indivdul20 { get; set; }
        public byte Indivdul21 { get; set; }
        public byte Indivdul22 { get; set; }
        public byte Indivdul23 { get; set; }
        public byte Indivdul24 { get; set; }
        public byte Indivdul25 { get; set; }
        public byte Indivdul26 { get; set; }
        public byte Indivdul27 { get; set; }
        public byte Indivdul28 { get; set; }
        public byte Indivdul29 { get; set; }
        public byte Indivdul30 { get; set; }
        public byte Indivdul31 { get; set; }
        public byte Indivdul32 { get; set; }
        public byte Indivdul33 { get; set; }
        public byte Indivdul34 { get; set; }
        public byte Indivdul35 { get; set; }
        public byte Indivdul36 { get; set; }
        public byte Indivdul37 { get; set; }
        public byte Indivdul38 { get; set; }
        public byte Indivdul39 { get; set; }
        public byte Indivdul40 { get; set; }
        public byte Indivdul41 { get; set; }
        public short Prntdscr { get; set; }
        public byte Przrobal { get; set; }
        public short Clcratio { get; set; }
        public byte Inclgnds { get; set; }
        public short Glsttkdt { get; set; }
        public short Glentkdt { get; set; }
        public byte Pruntact { get; set; }
        public string Staccnum1 { get; set; } = null!;
        public string Staccnum2 { get; set; } = null!;
        public string Staccnum3 { get; set; } = null!;
        public string Staccnum4 { get; set; } = null!;
        public string Staccnum5 { get; set; } = null!;
        public string Staccnum6 { get; set; } = null!;
        public string Staccnum7 { get; set; } = null!;
        public string Staccnum8 { get; set; } = null!;
        public string Staccnum9 { get; set; } = null!;
        public string Staccnum10 { get; set; } = null!;
        public string Edgacnum1 { get; set; } = null!;
        public string Edgacnum2 { get; set; } = null!;
        public string Edgacnum3 { get; set; } = null!;
        public string Edgacnum4 { get; set; } = null!;
        public string Edgacnum5 { get; set; } = null!;
        public string Edgacnum6 { get; set; } = null!;
        public string Edgacnum7 { get; set; } = null!;
        public string Edgacnum8 { get; set; } = null!;
        public string Edgacnum9 { get; set; } = null!;
        public string Edgacnum10 { get; set; } = null!;
        public short Segsrtby { get; set; }
        public short Rangeby { get; set; }
        public short Acclstat { get; set; }
        public byte Useaccel { get; set; }
        public byte Cbzbna { get; set; }
        public short AccountsIncluded { get; set; }
        public string StartPositionString { get; set; } = null!;
        public string EndPositionString { get; set; } = null!;
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public short Prtcurin { get; set; }
        public DateTime CheckbookDate { get; set; }
        public short EndMonth { get; set; }
        public short StartMonth { get; set; }
        public short Year1 { get; set; }
        public byte Incmcinf { get; set; }
        public string Stcurrid { get; set; } = null!;
        public string Endcurid { get; set; } = null!;
        public byte IncludeVoidedTrx { get; set; }
        public int DexRowId { get; set; }
    }
}
