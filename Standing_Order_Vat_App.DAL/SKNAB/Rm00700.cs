using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00700
    {
        public short Agngdtkn { get; set; }
        public short Rangeby { get; set; }
        public byte Prtdbrcd { get; set; }
        public byte Prpstjcb { get; set; }
        public byte Prsbdrcb { get; set; }
        public DateTime Enddocdt { get; set; }
        public string Filexpnm { get; set; } = null!;
        public string Finrptnm { get; set; } = null!;
        public byte Askechtm { get; set; }
        public byte Inclgnds { get; set; }
        public short Iffilxst { get; set; }
        public short Expttype { get; set; }
        public byte Prntnots { get; set; }
        public short Cstsrtby { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Prnttype { get; set; }
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Sortby { get; set; }
        public string Enfulnam { get; set; } = null!;
        public string Endaddct { get; set; } = null!;
        public string Endclsid { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Encstnam { get; set; } = null!;
        public string Endphon1 { get; set; } = null!;
        public string Enslster { get; set; } = null!;
        public string Enspsnid { get; set; } = null!;
        public string Endshnam { get; set; } = null!;
        public string Endstate { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public string Endzipcd { get; set; } = null!;
        public DateTime Endingdt { get; set; }
        public string Encldscr { get; set; } = null!;
        public string Enlstnam { get; set; } = null!;
        public string Endvendr { get; set; } = null!;
        public string Endemply { get; set; } = null!;
        public string Endcity { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public short Endoctyp { get; set; }
        public short Endperod { get; set; }
        public DateTime Endpstdt { get; set; }
        public string Endbnmbr { get; set; } = null!;
        public string Enbchsrc { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public short Enrmtkdt { get; set; }
        public decimal Enslsamt { get; set; }
        public decimal Enprmrgn { get; set; }
        public string Strtflnm { get; set; } = null!;
        public short Strmtkdt { get; set; }
        public string Staddctt { get; set; } = null!;
        public string Sttclsid { get; set; } = null!;
        public string Stcustid { get; set; } = null!;
        public string Stcustnm { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Strtngdt { get; set; }
        public string Sttphon1 { get; set; } = null!;
        public string Stslster { get; set; } = null!;
        public string Stsprsid { get; set; } = null!;
        public string Sttshnam { get; set; } = null!;
        public string Sttstate { get; set; } = null!;
        public string Sttudef1 { get; set; } = null!;
        public string Strtzpcd { get; set; } = null!;
        public string Stclsdsc { get; set; } = null!;
        public string Sttlstnm { get; set; } = null!;
        public string Strtvndr { get; set; } = null!;
        public string Strtempl { get; set; } = null!;
        public string Strtcity { get; set; } = null!;
        public short Stmtcycl { get; set; }
        public short Enstcycl { get; set; }
        public string Stdocnum { get; set; } = null!;
        public short Sttdoctp { get; set; }
        public DateTime Sttdocdt { get; set; }
        public short Stperiod { get; set; }
        public DateTime Sttpstdt { get; set; }
        public string Stbchnum { get; set; } = null!;
        public string Stbchsrc { get; set; } = null!;
        public string Strxsrc { get; set; } = null!;
        public decimal Stprmrgn { get; set; }
        public decimal Stslsamt { get; set; }
        public byte Inactive { get; set; }
        public short Balnctyp { get; set; }
        public byte Active { get; set; }
        public short Histtype { get; set; }
        public byte Trantopr { get; set; }
        public byte Prntdtld { get; set; }
        public DateTime Cutofdat { get; set; }
        public byte Crblnccb { get; set; }
        public byte Fllypdcb { get; set; }
        public byte Noactvcb { get; set; }
        public byte Zrobalcb { get; set; }
        public byte Pastducb { get; set; }
        public short Whichrpt { get; set; }
        public short Pertypgb { get; set; }
        public short Year1 { get; set; }
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
        public short Segmntrg { get; set; }
        public string Enitmnbr { get; set; } = null!;
        public string Endserlt { get; set; } = null!;
        public string Sttitnum { get; set; } = null!;
        public string Strtsrlt { get; set; } = null!;
        public short Trxtype { get; set; }
        public byte Incltxdt { get; set; }
        public byte Inclpymt { get; set; }
        public DateTime Stquoexd { get; set; }
        public DateTime Edquoexd { get; set; }
        public DateTime Streqdat { get; set; }
        public DateTime Endreqdt { get; set; }
        public string Sttloccd { get; set; } = null!;
        public string Enlocncd { get; set; } = null!;
        public int Stmstnmb { get; set; }
        public int Edmasnmb { get; set; }
        public string Stprhdid { get; set; } = null!;
        public string Enprhdid { get; set; } = null!;
        public string Sttdocid { get; set; } = null!;
        public string Enddocid { get; set; } = null!;
        public short Stsoptyp { get; set; }
        public short Edsoptyp { get; set; }
        public byte Discomp { get; set; }
        public byte Disprchd { get; set; }
        public byte Dissrlot { get; set; }
        public byte Disusrdf { get; set; }
        public byte Exccomp { get; set; }
        public byte Excfulfil { get; set; }
        public byte Incmcinf { get; set; }
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public short Prtcurin { get; set; }
        public byte Connaact { get; set; }
        public short DateSensitivitySumSelect { get; set; }
        public short SummaryYear { get; set; }
        public int DexRowId { get; set; }
    }
}
