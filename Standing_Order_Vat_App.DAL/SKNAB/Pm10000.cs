using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm10000
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Vchnumwk { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Vaddcdpr { get; set; } = null!;
        public string Vadcdtro { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public DateTime Duedate { get; set; }
        public decimal Dscdlram { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Prchamnt { get; set; }
        public decimal Chrgamnt { get; set; }
        public decimal Cashamnt { get; set; }
        public string Camcbkid { get; set; } = null!;
        public string Cdocnmbr { get; set; } = null!;
        public DateTime Camtdate { get; set; }
        public string Campmtnm { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Chamcbid { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Campynbr { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public string Ccampynm { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public string Cardname { get; set; } = null!;
        public string Ccrctnum { get; set; } = null!;
        public DateTime Crcarddt { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Trxdscrn { get; set; } = null!;
        public decimal Un1099am { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Ten99amnt { get; set; }
        public decimal Mscchamt { get; set; }
        public string Pordnmbr { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public decimal Disamtav { get; set; }
        public decimal Distknam { get; set; }
        public decimal Apdstkam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Curtrxam { get; set; }
        public byte Txengcld { get; set; }
        public byte[] Pmwrkmsg { get; set; } = null!;
        public byte[] Pmdstmsg { get; set; } = null!;
        public decimal Gstdsamt { get; set; }
        public short Pgramsbj { get; set; }
        public decimal Ppsamded { get; set; }
        public short Ppstaxrt { get; set; }
        public short Pstgstus { get; set; }
        public byte Posted { get; set; }
        public decimal Appldamt { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public decimal Bktpuram { get; set; }
        public string Pchschid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public byte Printed { get; set; }
        public short Prctdisc { get; set; }
        public decimal Retnagam { get; set; }
        public byte Ictrx { get; set; }
        public byte Icdists { get; set; }
        public byte[] Pmicmsgs { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public DateTime Prchdate { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Corrnxst { get; set; }
        public string Vchrncor { get; set; } = null!;
        public byte[] Pmwrkms2 { get; set; } = null!;
        public decimal Bnkrcamt { get; set; }
        public byte Aplywith { get; set; }
        public byte Electronic { get; set; }
        public byte Ectrx { get; set; }
        public byte DocPrinted { get; set; }
        public byte TaxInvReqd { get; set; }
        public decimal BackoutTradeDisc { get; set; }
        public byte Cbvat { get; set; }
        public int DexRowId { get; set; }
    }
}
