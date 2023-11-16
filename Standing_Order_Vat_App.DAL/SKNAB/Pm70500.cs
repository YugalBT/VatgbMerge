using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm70500
    {
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public byte Askechtm { get; set; }
        public short Expttype { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Iffilxst { get; set; }
        public string Finrptnm { get; set; } = null!;
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Sortby { get; set; }
        public short Sortby2 { get; set; }
        public short Histtype { get; set; }
        public DateTime Pymntdat { get; set; }
        public byte Voidonly { get; set; }
        public byte Exclvoid { get; set; }
        public byte IncludeCanceled { get; set; }
        public DateTime Dateoverdue { get; set; }
        public byte DaysOverdue { get; set; }
        public short PopDateSelection { get; set; }
        public byte IncludeClosed { get; set; }
        public byte IncludeReleased { get; set; }
        public short Ageby { get; set; }
        public short Comptype { get; set; }
        public string Stvndrid { get; set; } = null!;
        public string Stvndnam { get; set; } = null!;
        public string Stvndcls { get; set; } = null!;
        public string Sttstate { get; set; } = null!;
        public string Strtzpcd { get; set; } = null!;
        public string Strtphon { get; set; } = null!;
        public string Strtudef { get; set; } = null!;
        public string Sttcntct { get; set; } = null!;
        public DateTime StartPoDate { get; set; }
        public string Sttshnam { get; set; } = null!;
        public string Sttlocid { get; set; } = null!;
        public DateTime StartPromisedDate { get; set; }
        public DateTime StartRequiredDate { get; set; }
        public short Stvnstus { get; set; }
        public short Stt1099t { get; set; }
        public short Stperiod { get; set; }
        public short Strtyear { get; set; }
        public decimal Sttabytd { get; set; }
        public string Strtprty { get; set; } = null!;
        public DateTime Sttduedt { get; set; }
        public DateTime Stdiscdt { get; set; }
        public short Alorange { get; set; }
        public string Sttacncd { get; set; } = null!;
        public string Stdocnum { get; set; } = null!;
        public DateTime Sttdocdt { get; set; }
        public short Stdoctyp { get; set; }
        public string Stvchnum { get; set; } = null!;
        public string Sttitnum { get; set; } = null!;
        public string Stchknum { get; set; } = null!;
        public DateTime Sttchkdt { get; set; }
        public string Stchbkid { get; set; } = null!;
        public string Stbchsrc { get; set; } = null!;
        public string Stbchnum { get; set; } = null!;
        public DateTime Stpstddt { get; set; }
        public string Stclsdsc { get; set; } = null!;
        public string Endvndid { get; set; } = null!;
        public string Endvndnm { get; set; } = null!;
        public string Endvncls { get; set; } = null!;
        public string Endstate { get; set; } = null!;
        public string Endzipcd { get; set; } = null!;
        public string Enphonbr { get; set; } = null!;
        public DateTime EndPoDate { get; set; }
        public string Enusrdef { get; set; } = null!;
        public string Endlocid { get; set; } = null!;
        public string Enitmnbr { get; set; } = null!;
        public DateTime EndRequiredDate { get; set; }
        public DateTime EndPromisedDate { get; set; }
        public string Endvndct { get; set; } = null!;
        public string Endshnam { get; set; } = null!;
        public short Envnstts { get; set; }
        public short E1099typ { get; set; }
        public short Endperod { get; set; }
        public short Endyear { get; set; }
        public decimal Enambytd { get; set; }
        public string Enpryrty { get; set; } = null!;
        public DateTime Endduedt { get; set; }
        public DateTime Endiscdt { get; set; }
        public short Alornge2 { get; set; }
        public string Enaucncd { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public DateTime Enddocdt { get; set; }
        public short Endoctyp { get; set; }
        public string Envchnum { get; set; } = null!;
        public string Enchknum { get; set; } = null!;
        public DateTime Endchkdt { get; set; }
        public string Enchbkid { get; set; } = null!;
        public string Enbchsrc { get; set; } = null!;
        public string Endbnmbr { get; set; } = null!;
        public DateTime Enpstddt { get; set; }
        public string Encldscr { get; set; } = null!;
        public DateTime Agngdate { get; set; }
        public short Pbsdcdtk { get; set; }
        public short Pbsdudtk { get; set; }
        public short Pbsdsdtk { get; set; }
        public short Pbschdtk { get; set; }
        public short Pbsptdtk { get; set; }
        public short Pbedcdtk { get; set; }
        public short Pbedudtk { get; set; }
        public short Pbedsdtk { get; set; }
        public short Pbechdtk { get; set; }
        public short Pbepdtkn { get; set; }
        public short Pbcdttkn { get; set; }
        public byte Detldrpt { get; set; }
        public byte Singact { get; set; }
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
        public string Strponum { get; set; } = null!;
        public string Endponum { get; set; } = null!;
        public string EndPoprcptNum { get; set; } = null!;
        public string StartPoprcptNum { get; set; } = null!;
        public string Strcreat { get; set; } = null!;
        public DateTime Strctdt { get; set; }
        public DateTime Enrctdt { get; set; }
        public string Strctnum { get; set; } = null!;
        public string Enrctnbr { get; set; } = null!;
        public string Endcreate { get; set; } = null!;
        public short Strposta { get; set; }
        public short Endposta { get; set; }
        public byte Incrcpts { get; set; }
        public byte Dissrlot { get; set; }
        public string Strxsrc { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public byte Crblnccb { get; set; }
        public byte Fllypdcb { get; set; }
        public byte Zrobalcb { get; set; }
        public byte Exclzbal { get; set; }
        public byte Noactvcb { get; set; }
        public byte UnpostedAppliedCrDocs { get; set; }
        public byte MulticurrencyInformation { get; set; }
        public byte[] IncludeDistributionTyp { get; set; } = null!;
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public short Prtcurin { get; set; }
        public byte Inclfunc { get; set; }
        public short Startlineorigin { get; set; }
        public short Endlineorigin { get; set; }
        public string Startbuyerid { get; set; } = null!;
        public string Endbuyerid { get; set; } = null!;
        public byte Includeholdpo { get; set; }
        public byte Includeholdpoonly { get; set; }
        public DateTime Startreleasebydate { get; set; }
        public DateTime Endreleasebydate { get; set; }
        public byte IncludeNew { get; set; }
        public byte IncludeChangeOrder { get; set; }
        public byte IncludeReceived { get; set; }
        public short SummaryYear { get; set; }
        public short DateSensitivitySumSelect { get; set; }
        public string StartProjNum { get; set; } = null!;
        public string EndProjNum { get; set; } = null!;
        public string StartCostCatId { get; set; } = null!;
        public string EndCostCatId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
