using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc70500
    {
        public short Prtbysit { get; set; }
        public short Prntoptn { get; set; }
        public string Sttgndsc { get; set; } = null!;
        public string Engendsc { get; set; } = null!;
        public string Enusrcat1 { get; set; } = null!;
        public string Enusrcat2 { get; set; } = null!;
        public string Enusrcat3 { get; set; } = null!;
        public string Enusrcat4 { get; set; } = null!;
        public string Enusrcat5 { get; set; } = null!;
        public string Enusrcat6 { get; set; } = null!;
        public string Strtucat1 { get; set; } = null!;
        public string Strtucat2 { get; set; } = null!;
        public string Strtucat3 { get; set; } = null!;
        public string Strtucat4 { get; set; } = null!;
        public string Strtucat5 { get; set; } = null!;
        public string Strtucat6 { get; set; } = null!;
        public string Callnbst { get; set; } = null!;
        public string Callnmen { get; set; } = null!;
        public string Contnbrs { get; set; } = null!;
        public string Contnbre { get; set; } = null!;
        public string Srlnbrst { get; set; } = null!;
        public string Srlnbren { get; set; } = null!;
        public string Pmdtlids { get; set; } = null!;
        public string Pmdtlide { get; set; } = null!;
        public string Stcustid { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Sttechid { get; set; } = null!;
        public string Entechid { get; set; } = null!;
        public string Stoffid { get; set; } = null!;
        public string Enoffid { get; set; } = null!;
        public string Svcopt1 { get; set; } = null!;
        public string Endsvco1 { get; set; } = null!;
        public string Stsvcop1 { get; set; } = null!;
        public string Ensvcop2 { get; set; } = null!;
        public string Stsvcopt3 { get; set; } = null!;
        public string Ensvcop3 { get; set; } = null!;
        public string Stsvcop4 { get; set; } = null!;
        public string Ensvcop4 { get; set; } = null!;
        public byte Stsvcop5 { get; set; }
        public byte Ensvcop5 { get; set; }
        public string Stsvcop6 { get; set; } = null!;
        public string Ensvcop6 { get; set; } = null!;
        public string Stsvcop7 { get; set; } = null!;
        public string Ensvcop7 { get; set; } = null!;
        public string Stsvcop8 { get; set; } = null!;
        public string Ensvcop8 { get; set; } = null!;
        public short Stsvcop9 { get; set; }
        public short Ensvcop9 { get; set; }
        public short Stsvco10 { get; set; }
        public short Ensvco10 { get; set; }
        public string Sttitnum { get; set; } = null!;
        public string Enitmnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public short Consts { get; set; }
        public short Prvdrinf { get; set; }
        public byte Prtdscnt { get; set; }
        public byte Prtsvchs { get; set; }
        public string Svcrptnm { get; set; } = null!;
        public byte Prntnots { get; set; }
        public short Prnttype { get; set; }
        public byte Askechtm { get; set; }
        public byte Inclgnds { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public short Rptgrind { get; set; }
        public string Sttclass { get; set; } = null!;
        public string Endclass { get; set; } = null!;
        public string Strtdscr { get; set; } = null!;
        public string Enddescr { get; set; } = null!;
        public string Sttsched { get; set; } = null!;
        public string Enschdul { get; set; } = null!;
        public string Sttloccd { get; set; } = null!;
        public string Enlocncd { get; set; } = null!;
        public string Sttlotty { get; set; } = null!;
        public string Enlottyp { get; set; } = null!;
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public short Endtkndt { get; set; }
        public short Sttokndt { get; set; }
        public string Strctnum { get; set; } = null!;
        public string Enrctnbr { get; set; } = null!;
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Sortby { get; set; }
        public byte Prtsrlot { get; set; }
        public byte Inzroqty { get; set; }
        public byte Prtitqty { get; set; }
        public string Sttbinum { get; set; } = null!;
        public string Enbinnbr { get; set; } = null!;
        public string Stdocnum { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public short Stdoctyp { get; set; }
        public short Endoctyp { get; set; }
        public string Sttmodul { get; set; } = null!;
        public string Endmodul { get; set; } = null!;
        public string Strxsrc { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public string Stbchsrc { get; set; } = null!;
        public string Enbchsrc { get; set; } = null!;
        public string Stbchnum { get; set; } = null!;
        public string Endbnmbr { get; set; } = null!;
        public string Stvndrid { get; set; } = null!;
        public string Endvndid { get; set; } = null!;
        public byte Inqtyreq { get; set; }
        public byte Inzrorlv { get; set; }
        public short Calsgqty { get; set; }
        public short Rcptopts { get; set; }
        public short Vendropt { get; set; }
        public short Segsrtby { get; set; }
        public short Segmntrg { get; set; }
        public string StartPriceLevel { get; set; } = null!;
        public string EndPriceLevel { get; set; } = null!;
        public string StartRmaNumber { get; set; } = null!;
        public string EndRmaNumber { get; set; } = null!;
        public DateTime StartRequiredDate { get; set; }
        public DateTime EndRequiredDate { get; set; }
        public byte SvcPrintOpen { get; set; }
        public byte Incmcinf { get; set; }
        public short Prtcurin { get; set; }
        public int DexRowId { get; set; }
    }
}
