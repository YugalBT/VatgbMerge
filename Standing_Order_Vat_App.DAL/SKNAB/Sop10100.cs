using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10100
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public short Origtype { get; set; }
        public string Orignumb { get; set; } = null!;
        public string Docid { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public DateTime Quotedat { get; set; }
        public DateTime Quoexpda { get; set; }
        public DateTime Ordrdate { get; set; }
        public DateTime Invodate { get; set; }
        public DateTime Backdate { get; set; }
        public DateTime Retudate { get; set; }
        public DateTime ReqShipDate { get; set; }
        public DateTime Fufildat { get; set; }
        public DateTime Actlship { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public byte Repting { get; set; }
        public short Trxfrequ { get; set; }
        public short Timerepd { get; set; }
        public short Timetrep { get; set; }
        public short Dystincr { get; set; }
        public DateTime Dtlstrep { get; set; }
        public string Dstbtch1 { get; set; } = null!;
        public string Dstbtch2 { get; set; } = null!;
        public string Usdocid1 { get; set; } = null!;
        public string Usdocid2 { get; set; } = null!;
        public decimal Discfrgt { get; set; }
        public decimal Ordavfrt { get; set; }
        public decimal Discmisc { get; set; }
        public decimal Ordavmsc { get; set; }
        public decimal Disavamt { get; set; }
        public decimal Ordavamt { get; set; }
        public decimal Discrtnd { get; set; }
        public decimal Ordisrtd { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public short Dscpctam { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ordatkn { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public short Prospect { get; set; }
        public int Mstrnumb { get; set; }
        public string Pckslpno { get; set; } = null!;
        public string Picticnu { get; set; } = null!;
        public decimal Mrkdnamt { get; set; }
        public decimal Ormrkdam { get; set; }
        public string Prbtadcd { get; set; } = null!;
        public string Prstadcd { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string ShipToName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phnumbr1 { get; set; } = null!;
        public string Phnumbr2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public short Comappto { get; set; }
        public decimal Commamnt { get; set; }
        public decimal Ocommamt { get; set; }
        public decimal Cmmslamt { get; set; }
        public decimal Orcosamt { get; set; }
        public decimal Ncomamnt { get; set; }
        public decimal Orncmamt { get; set; }
        public string Shipmthd { get; set; } = null!;
        public decimal Trdisamt { get; set; }
        public decimal Ortdisam { get; set; }
        public short Trdispct { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Orsubtot { get; set; }
        public decimal Remsubto { get; set; }
        public decimal Oremsubt { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Ormiscamt { get; set; }
        public byte Txengcld { get; set; }
        public string Taxexmt1 { get; set; } = null!;
        public string Taxexmt2 { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public short Txschsrc { get; set; }
        public byte Bsivcttl { get; set; }
        public string Frtschid { get; set; } = null!;
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public short Frgttxbl { get; set; }
        public string Mscschid { get; set; } = null!;
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public short Misctxbl { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Orbktfrt { get; set; }
        public decimal Bktmscam { get; set; }
        public decimal Orbktmsc { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal Txbtxamt { get; set; }
        public decimal Otaxtamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public byte Ectrx { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Pymtrcvd { get; set; }
        public decimal Orpmtrvd { get; set; }
        public decimal Deprecvd { get; set; }
        public decimal Ordeprvd { get; set; }
        public decimal Codamnt { get; set; }
        public decimal Orcodamt { get; set; }
        public decimal Acctamnt { get; set; }
        public decimal Oractamt { get; set; }
        public string Salsterr { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Upszone { get; set; } = null!;
        public short Timesprt { get; set; }
        public short Pstgstus { get; set; }
        public short Voidstts { get; set; }
        public short Allocaby { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public short Mctrxstt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte[] Sophdre1 { get; set; } = null!;
        public byte[] Sophdre2 { get; set; } = null!;
        public byte[] Soplnerr { get; set; } = null!;
        public byte[] Sophdrfl { get; set; } = null!;
        public byte[] Sopmcerr { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public string User2ent { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime TaxDate { get; set; }
        public byte Aplywith { get; set; }
        public decimal Withhamt { get; set; }
        public byte Shppgdoc { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Corrnxst { get; set; }
        public string Docncorr { get; set; } = null!;
        public short Seqncorr { get; set; }
        public DateTime Saledate { get; set; }
        public byte[] Sophdre3 { get; set; } = null!;
        public byte Exceptionaldemand { get; set; }
        public short Flags { get; set; }
        public decimal BackoutTradeDisc { get; set; }
        public decimal OrigBackoutTradeDisc { get; set; }
        public string Gpsfointegrationid { get; set; } = null!;
        public short Integrationsource { get; set; }
        public string Integrationid { get; set; } = null!;
        public short Sopstatus { get; set; }
        public byte Shipcomplete { get; set; }
        public byte Directdebit { get; set; }
        public int DexRowId { get; set; }
    }
}
