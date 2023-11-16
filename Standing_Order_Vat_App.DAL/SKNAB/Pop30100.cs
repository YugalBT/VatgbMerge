using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30100
    {
        public string Ponumber { get; set; } = null!;
        public short Postatus { get; set; }
        public short Statgrp { get; set; }
        public short Potype { get; set; }
        public string User2ent { get; set; } = null!;
        public string Confirm1 { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime Lstedtdt { get; set; }
        public DateTime Lstprtdt { get; set; }
        public DateTime Prmdate { get; set; }
        public DateTime Prmshpdte { get; set; }
        public DateTime Reqdate { get; set; }
        public DateTime Reqtndt { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public decimal Remsubto { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Trdpctpr { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal Taxamnt { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public decimal Minorder { get; set; }
        public string Vadcdpad { get; set; } = null!;
        public short Cmpanyid { get; set; }
        public string Prbtadcd { get; set; } = null!;
        public string Prstadcd { get; set; } = null!;
        public string Cmpnynam { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public decimal Disamtav { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public string Custnmbr { get; set; } = null!;
        public short Timesprt { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public decimal Ponotids1 { get; set; }
        public decimal Ponotids2 { get; set; }
        public decimal Ponotids3 { get; set; }
        public decimal Ponotids4 { get; set; }
        public decimal Ponotids5 { get; set; }
        public decimal Ponotids6 { get; set; }
        public decimal Ponotids7 { get; set; }
        public decimal Ponotids8 { get; set; }
        public decimal Ponotids9 { get; set; }
        public decimal Ponotids10 { get; set; }
        public decimal Ponotids11 { get; set; }
        public decimal Ponotids12 { get; set; }
        public decimal Ponotids13 { get; set; }
        public decimal Ponotids14 { get; set; }
        public decimal Ponotids15 { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public decimal Cancsub { get; set; }
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
        public decimal Oremsubt { get; set; }
        public decimal Orsubtot { get; set; }
        public decimal OriginatingCanceledSub { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Odisamtav { get; set; }
        public string Buyerid { get; set; } = null!;
        public byte Allowsocmts { get; set; }
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public short RevisionNumber { get; set; }
        public string Taxschid { get; set; } = null!;
        public short Txschsrc { get; set; }
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
        public decimal BackoutFreightTaxAmt { get; set; }
        public decimal OrigBackoutFreightTaxAmt { get; set; }
        public decimal BackoutMiscTaxAmt { get; set; }
        public decimal OrigBackoutMiscTaxAmt { get; set; }
        public short Flags { get; set; }
        public string Popcontnum { get; set; } = null!;
        public DateTime Contenddte { get; set; }
        public short Cntrlblktby { get; set; }
        public string Purchcmpnynam { get; set; } = null!;
        public string Purchcontact { get; set; } = null!;
        public string Purchaddress1 { get; set; } = null!;
        public string Purchaddress2 { get; set; } = null!;
        public string Purchaddress3 { get; set; } = null!;
        public string Purchcity { get; set; } = null!;
        public string Purchstate { get; set; } = null!;
        public string Purchzipcode { get; set; } = null!;
        public string Purchccode { get; set; } = null!;
        public string Purchcountry { get; set; } = null!;
        public string Purchphone1 { get; set; } = null!;
        public string Purchphone2 { get; set; } = null!;
        public string Purchphone3 { get; set; } = null!;
        public string Purchfax { get; set; } = null!;
        public decimal Blnktlineextqtysum { get; set; }
        public int DexRowId { get; set; }
    }
}
