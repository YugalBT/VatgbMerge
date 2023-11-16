using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10500
    {
        public short Paertrxtype { get; set; }
        public string Paerdocnumber { get; set; } = null!;
        public string PdkEeNo { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Pavenaddressid { get; set; } = null!;
        public DateTime PastartDate { get; set; }
        public DateTime PaenDate { get; set; }
        public string Pareptsuff { get; set; } = null!;
        public short Payr { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public DateTime Duedate { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Orddlrat { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Disamtav { get; set; }
        public decimal Odisamtav { get; set; }
        public short Prctdisc { get; set; }
        public string Pacomm { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Patqty { get; set; }
        public decimal Paextcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Paorigtotcosts { get; set; }
        public decimal Pareimburstaxamt { get; set; }
        public decimal Paorigreimtaxamt { get; set; }
        public decimal Bktpuram { get; set; }
        public decimal Patacrv { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Ortdisam { get; set; }
        public short PafreightTaxableP { get; set; }
        public string Frtschid { get; set; } = null!;
        public decimal Frtamnt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public short PamiscTaxableP { get; set; }
        public string Mscschid { get; set; } = null!;
        public decimal Mscchamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Ten99amnt { get; set; }
        public decimal Or1099am { get; set; }
        public decimal Un1099am { get; set; }
        public decimal Cashamnt { get; set; }
        public decimal Orcasamt { get; set; }
        public string Camcbkid { get; set; } = null!;
        public string Cdocnmbr { get; set; } = null!;
        public DateTime Camtdate { get; set; }
        public string Campmtnm { get; set; } = null!;
        public decimal Chrgamnt { get; set; }
        public decimal Ochgamt { get; set; }
        public decimal Chekamnt { get; set; }
        public decimal Orchkamt { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Campynbr { get; set; } = null!;
        public string Chamcbid { get; set; } = null!;
        public string Cardname { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public decimal Orccdamt { get; set; }
        public DateTime Crcarddt { get; set; }
        public string Ccampynm { get; set; } = null!;
        public string Ccrctnum { get; set; } = null!;
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordavfrt { get; set; }
        public decimal Odavpur { get; set; }
        public decimal Ordavmsc { get; set; }
        public string Taxschid { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal PareimbursableAmount { get; set; }
        public decimal PaorigReimbursableAmt { get; set; }
        public DateTime Papd { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public byte[] PaEeHdrErrors { get; set; } = null!;
        public byte[] PaEeDistErrors { get; set; } = null!;
        public byte[] PaMcEePostingErrors { get; set; } = null!;
        public byte PapostoDynPm { get; set; }
        public DateTime TaxDate { get; set; }
        public decimal Noteindx { get; set; }
        public byte TaxInvRecvd { get; set; }
        public byte TaxInvReqd { get; set; }
        public short CorrectingTrxType { get; set; }
        public string Paoriginldocnum { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
