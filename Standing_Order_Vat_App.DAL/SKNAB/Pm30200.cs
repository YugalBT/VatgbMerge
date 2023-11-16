using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm30200
    {
        public string Vchrnmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short Doctype { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Docamnt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Distknam { get; set; }
        public decimal Discamnt { get; set; }
        public decimal Dscdlram { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public string Pordnmbr { get; set; } = null!;
        public decimal Ten99amnt { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Disamtav { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public decimal Un1099am { get; set; }
        public decimal Bktpuram { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public byte Voided { get; set; }
        public byte Hold { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Dinvpdof { get; set; }
        public decimal Ppsamded { get; set; }
        public short Ppstaxrt { get; set; }
        public short Pgramsbj { get; set; }
        public decimal Gstdsamt { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public short Pyenttyp { get; set; }
        public string Cardname { get; set; } = null!;
        public decimal Prchamnt { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ttlpymts { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Pchschid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public DateTime Pstgdate { get; set; }
        public decimal Disavtkn { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Noteindx { get; set; }
        public short Prctdisc { get; set; }
        public decimal Retnagam { get; set; }
        public DateTime Voidpdate { get; set; }
        public byte Ictrx { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime Prchdate { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Aplywith { get; set; }
        public byte Electronic { get; set; }
        public byte Ectrx { get; set; }
        public byte DocPrinted { get; set; }
        public byte TaxInvReqd { get; set; }
        public string Vndchknm { get; set; } = null!;
        public decimal BackoutTradeDisc { get; set; }
        public byte Cbvat { get; set; }
        public string Vadcdtro { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
