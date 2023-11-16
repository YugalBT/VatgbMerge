using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv70500
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
        public short Kitsrtby { get; set; }
        public string Strtucat1 { get; set; } = null!;
        public string Strtucat2 { get; set; } = null!;
        public string Strtucat3 { get; set; } = null!;
        public string Strtucat4 { get; set; } = null!;
        public string Strtucat5 { get; set; } = null!;
        public string Strtucat6 { get; set; } = null!;
        public string Sttitnum { get; set; } = null!;
        public string Enitmnbr { get; set; } = null!;
        public short Prvdrinf { get; set; }
        public byte Prtdscnt { get; set; }
        public string Finrptnm { get; set; } = null!;
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
        public string StartPriceLevel { get; set; } = null!;
        public string EndPriceLevel { get; set; } = null!;
        public short StartQtyType { get; set; }
        public short EndQtyType { get; set; }
        public string StartComponentItemNum { get; set; } = null!;
        public string EndComponentItemNumbe { get; set; } = null!;
        public byte BmAssemblyJournal { get; set; }
        public byte BmDistributionDetail { get; set; }
        public byte BmBillStatusActive { get; set; }
        public byte BmBillStatusPending { get; set; }
        public byte BmBillStatusObsolete { get; set; }
        public byte BmCompStatusActive { get; set; }
        public byte BmCompStatusPending { get; set; }
        public byte BmCompStatusObsolete { get; set; }
        public byte BmCompTypeMiscCharge { get; set; }
        public byte BmCompTypeServices { get; set; }
        public byte BmCompTypeFlatFee { get; set; }
        public byte BmPrintNotesBill { get; set; }
        public byte BmPrintNotesComp { get; set; }
        public short BmPrintCostOptions { get; set; }
        public short MaxLevels { get; set; }
        public DateTime Date1 { get; set; }
        public byte Bmtrxstatnotrel { get; set; }
        public byte Bmtrxstatrel { get; set; }
        public short Options { get; set; }
        public string StartTrxId { get; set; } = null!;
        public string EndTrxId { get; set; } = null!;
        public DateTime StartingTrxDate { get; set; }
        public DateTime EndingTrxDate { get; set; }
        public string Strtsrlt { get; set; } = null!;
        public string Endserlt { get; set; } = null!;
        public string StartPriceGroup { get; set; } = null!;
        public string EndPriceGroup { get; set; } = null!;
        public string Stcurrid { get; set; } = null!;
        public string Endcurid { get; set; } = null!;
        public short Strtabccd { get; set; }
        public short Endabccd { get; set; }
        public string Strtstckcntid { get; set; } = null!;
        public string Endstckcntid { get; set; } = null!;
        public string StartLandedCostId { get; set; } = null!;
        public string EndLandedCostId { get; set; } = null!;
        public string StartLandedCostGroupId { get; set; } = null!;
        public string EndLandedCostGroupId { get; set; } = null!;
        public DateTime Asofdate { get; set; }
        public byte Inzrqtyi { get; set; }
        public string Startbin { get; set; } = null!;
        public string Endbin { get; set; } = null!;
        public string Lngstrtdesc { get; set; } = null!;
        public string Lngenddesc { get; set; } = null!;
        public byte Useglpostingdate { get; set; }
        public byte Inngvqty { get; set; }
        public short Costavgperiodic { get; set; }
        public int DexRowId { get; set; }
    }
}
