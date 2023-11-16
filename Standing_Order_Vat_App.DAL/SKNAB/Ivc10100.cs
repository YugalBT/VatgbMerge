using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10100
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Pckslpno { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public DateTime Postdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Quotedat { get; set; }
        public DateTime Ordrdate { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public byte Holdnt { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string Taxexmt1 { get; set; } = null!;
        public string Taxexmt2 { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public short Frgttxbl { get; set; }
        public decimal Frttxamt { get; set; }
        public string Mscschid { get; set; } = null!;
        public short Misctxbl { get; set; }
        public decimal Msctxamt { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Txbtxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Bktslsam { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public decimal Discfrgt { get; set; }
        public decimal Discmisc { get; set; }
        public short Trdispct { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Acctamnt { get; set; }
        public decimal Pymtrcvd { get; set; }
        public decimal Codamnt { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Discrtnd { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavamt { get; set; }
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public decimal Mrkdnamt { get; set; }
        public string Prbtadcd { get; set; } = null!;
        public string Prstadcd { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
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
        public decimal Comdlram { get; set; }
        public decimal Ncomamnt { get; set; }
        public string Upszone { get; set; } = null!;
        public string Lstusred { get; set; } = null!;
        public DateTime Lstedtdt { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public string User2ent { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Timesprt { get; set; }
        public short Nocartns { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public short Voidstts { get; set; }
        public string Trxsorce { get; set; } = null!;
        public short Pstgstus { get; set; }
        public byte[] Ivchder1 { get; set; } = null!;
        public byte[] Ivchder2 { get; set; } = null!;
        public byte[] Ivclineerr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Comment3 { get; set; } = null!;
        public string Comment4 { get; set; } = null!;
        public byte Ectrx { get; set; }
        public string ShipToName { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public byte Aplywith { get; set; }
        public decimal Withhamt { get; set; }
        public decimal BackoutTradeDisc { get; set; }
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
