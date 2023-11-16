using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pavw31101
    {
        public string Pavidn { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public decimal Bnkrcamt { get; set; }
        public string Cardname { get; set; } = null!;
        public decimal Cashamnt { get; set; }
        public string Camcbkid { get; set; } = null!;
        public DateTime Camtdate { get; set; }
        public string Campmtnm { get; set; } = null!;
        public string Cdocnmbr { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Chamcbid { get; set; } = null!;
        public string Campynbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public string Ccampynm { get; set; } = null!;
        public DateTime Crcarddt { get; set; }
        public string Ccrctnum { get; set; } = null!;
        public decimal Distknam { get; set; }
        public byte DocPrinted { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Orcasamt { get; set; }
        public decimal Orchkamt { get; set; }
        public decimal Orccdamt { get; set; }
        public decimal Ordistkn { get; set; }
        public string Pacomm { get; set; } = null!;
        public short PafreightTaxableP { get; set; }
        public short PamiscTaxableP { get; set; }
        public byte[] PapoHdrErrors { get; set; } = null!;
        public byte[] PapoLineErrors { get; set; } = null!;
        public byte PapostoDynPm { get; set; }
        public short PaTradeDiscountPcnt { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string RegKey { get; set; } = null!;
        public short Trxtype { get; set; }
        public short Useadvtx { get; set; }
        public string Poprctnm { get; set; } = null!;
        public short Poptype { get; set; }
        public string Vnddocnm { get; set; } = null!;
        public DateTime Receiptdate { get; set; }
        public DateTime Actlship { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public decimal Subtotal { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Trdpctpr { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ten99amnt { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public short Dscpctam { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Disavamt { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public string Refrence { get; set; } = null!;
        public short Voidstts { get; set; }
        public decimal Rcptnote1 { get; set; }
        public decimal Rcptnote2 { get; set; }
        public decimal Rcptnote3 { get; set; }
        public decimal Rcptnote4 { get; set; }
        public decimal Rcptnote5 { get; set; }
        public decimal Rcptnote6 { get; set; }
        public decimal Rcptnote7 { get; set; }
        public decimal Rcptnote8 { get; set; }
        public byte[] Pophdr1 { get; set; } = null!;
        public byte[] Pophdr2 { get; set; } = null!;
        public byte[] Poplnerr { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public string User2ent { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Orsubtot { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Ormiscamt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Or1099am { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Ordavamt { get; set; }
        public byte Simplifd { get; set; }
        public decimal Withhamt { get; set; }
        public byte Ectrx { get; set; }
        public string Txrgnnum { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public byte Bsivcttl { get; set; }
        public short PurchaseFreightTaxable { get; set; }
        public short PurchaseMiscTaxable { get; set; }
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public byte TaxInvReqd { get; set; }
        public decimal BackoutFreightTaxAmt { get; set; }
        public decimal OrigBackoutFreightTaxAmt { get; set; }
        public decimal BackoutMiscTaxAmt { get; set; }
        public decimal OrigBackoutMiscTaxAmt { get; set; }
        public byte TaxInvRecvd { get; set; }
        public byte Aplywith { get; set; }
        public short Ppstaxrt { get; set; }
        public string Shipmthd { get; set; } = null!;
        public decimal TotalLandedCostAmount { get; set; }
        public byte Cbvat { get; set; }
    }
}
