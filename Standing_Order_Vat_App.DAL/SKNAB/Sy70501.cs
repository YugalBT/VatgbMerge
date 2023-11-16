using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy70501
    {
        public short Origingb { get; set; }
        public short Strtyear { get; set; }
        public short Endyear { get; set; }
        public string Sticid { get; set; } = null!;
        public string Endicid { get; set; } = null!;
        public string Finrptnm { get; set; } = null!;
        public byte Sjrntprt { get; set; }
        public byte Prntnots { get; set; }
        public short Prnttype { get; set; }
        public byte Askechtm { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public byte Inclgnds { get; set; }
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Sortby { get; set; }
        public string Sttlocid { get; set; } = null!;
        public string Sttlocnm { get; set; } = null!;
        public string Staddctt { get; set; } = null!;
        public string Ssrcedoc { get; set; } = null!;
        public string Ssdocdsc { get; set; } = null!;
        public string Sttstate { get; set; } = null!;
        public string Strtzpcd { get; set; } = null!;
        public short Sttflsrs { get; set; }
        public short Startsrs { get; set; }
        public string Sttrxsrc { get; set; } = null!;
        public string Sttnotnm { get; set; } = null!;
        public string Srptgrnm { get; set; } = null!;
        public string Sttpalnm { get; set; } = null!;
        public string Sttusrid { get; set; } = null!;
        public short Stendtyp { get; set; }
        public string Sttcrdnm { get; set; } = null!;
        public string Sttpytid { get; set; } = null!;
        public string Sttshmth { get; set; } = null!;
        public short Srtcomsr { get; set; }
        public string Srtcomid { get; set; } = null!;
        public string Endlocid { get; set; } = null!;
        public string Endlocnm { get; set; } = null!;
        public string Endaddct { get; set; } = null!;
        public string Endsrcdc { get; set; } = null!;
        public string Endsddsc { get; set; } = null!;
        public string Endstate { get; set; } = null!;
        public string Endzipcd { get; set; } = null!;
        public short Endflsrs { get; set; }
        public short Endseris { get; set; }
        public string Endtrxsr { get; set; } = null!;
        public string Endnotnm { get; set; } = null!;
        public string Endrpgnm { get; set; } = null!;
        public string Endpalnm { get; set; } = null!;
        public string Endusrid { get; set; } = null!;
        public short Endendty { get; set; }
        public string Endcrdnm { get; set; } = null!;
        public string Endpytid { get; set; } = null!;
        public string Endshmth { get; set; } = null!;
        public string Endcomid { get; set; } = null!;
        public short Endcomsr { get; set; }
        public string Endname { get; set; } = null!;
        public string Endid { get; set; } = null!;
        public string Startid { get; set; } = null!;
        public string Strtname { get; set; } = null!;
        public string Strtcity { get; set; } = null!;
        public string Endcity { get; set; } = null!;
        public string Endcntry { get; set; } = null!;
        public string Sttcntry { get; set; } = null!;
        public short Lblfrmat { get; set; }
        public short Numocpis { get; set; }
        public short Numacros { get; set; }
        public byte Incadadr { get; set; }
        public byte Inccntct { get; set; }
        public byte Frceupcs { get; set; }
        public short Year1 { get; set; }
        public byte Prntdtld { get; set; }
        public string Entxddsc { get; set; } = null!;
        public string Etxdtlid { get; set; } = null!;
        public string Etxschds { get; set; } = null!;
        public string Etxschid { get; set; } = null!;
        public string Sttxddsc { get; set; } = null!;
        public string Sttxdtid { get; set; } = null!;
        public string Stxscdsc { get; set; } = null!;
        public string Stxschid { get; set; } = null!;
        public short Endperod { get; set; }
        public short Stperiod { get; set; }
        public short Stdtltyp { get; set; }
        public short Endettyp { get; set; }
        public string Stxidnum { get; set; } = null!;
        public string Etxidnbr { get; set; } = null!;
        public short Histtype { get; set; }
        public string Stbchnum { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public string Stdocnum { get; set; } = null!;
        public string Endbnmbr { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public DateTime Enddate { get; set; }
        public byte Prnshpto { get; set; }
        public byte Prtbllto { get; set; }
        public short Arvldepart { get; set; }
        public string Stcustid { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public short Stsoptyp { get; set; }
        public short Edsoptyp { get; set; }
        public string Upsidnbr { get; set; } = null!;
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public short Stdoctyp { get; set; }
        public short Endoctyp { get; set; }
        public string Stvndrid { get; set; } = null!;
        public string Endvndid { get; set; } = null!;
        public short Strmtkdt { get; set; }
        public short Enrmtkdt { get; set; }
        public string Sttxusr1 { get; set; } = null!;
        public string Entxusr1 { get; set; } = null!;
        public short Sttokndt { get; set; }
        public short Endtkndt { get; set; }
        public DateTime Sttxpydt { get; set; }
        public DateTime Entxpydt { get; set; }
        public DateTime Sttpstdt { get; set; }
        public DateTime Endpstdt { get; set; }
        public short Stgenint1 { get; set; }
        public string Stdeclid { get; set; } = null!;
        public string Enddeclid { get; set; } = null!;
        public string Stintrsttrtrnid { get; set; } = null!;
        public string Endintrsttrtrnid { get; set; } = null!;
        public string Sttcc { get; set; } = null!;
        public string Endtcc { get; set; } = null!;
        public string Sttxrgnnum { get; set; } = null!;
        public string Endtxrgnnum { get; set; } = null!;
        public decimal Strtamnt { get; set; }
        public decimal Endamnt { get; set; }
        public short Groupbox { get; set; }
        public short Groupbx2 { get; set; }
        public byte Exclvoid { get; set; }
        public byte Prntcsv { get; set; }
        public int DexRowId { get; set; }
    }
}
