using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk10500
    {
        public short PdkEeTrxType { get; set; }
        public string PdkEeNo { get; set; } = null!;
        public string PdkRefDocNo { get; set; } = null!;
        public short PdkDocumentStatus { get; set; }
        public short PdkTrxSource { get; set; }
        public byte PdkRemoteChange { get; set; }
        public DateTime Padocdt { get; set; }
        public short Payr { get; set; }
        public string Employid { get; set; } = null!;
        public DateTime PastartDate { get; set; }
        public DateTime PaenDate { get; set; }
        public string Pacomm { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal PdkTotalQuantity { get; set; }
        public decimal Paextcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Patacrv { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ten99amnt { get; set; }
        public string Pavenaddressid { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public DateTime Duedate { get; set; }
        public decimal Dscdlram { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Disamtav { get; set; }
        public decimal Distknam { get; set; }
        public decimal Bktpuram { get; set; }
        public string Shipmthd { get; set; } = null!;
        public short Prctdisc { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal Un1099am { get; set; }
        public DateTime Papd { get; set; }
        public string Cardname { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public DateTime Crcarddt { get; set; }
        public string Ccrctnum { get; set; } = null!;
        public decimal Taxamnt { get; set; }
        public string Taxschid { get; set; } = null!;
        public short PafreightTaxableP { get; set; }
        public string Frtschid { get; set; } = null!;
        public decimal Frttxamt { get; set; }
        public short PamiscTaxableP { get; set; }
        public string Mscschid { get; set; } = null!;
        public decimal Msctxamt { get; set; }
        public decimal Chrgamnt { get; set; }
        public string Noteid { get; set; } = null!;
        public string PdkReportingSuffix { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Manager { get; set; } = null!;
        public short ManagerApprovalStatus { get; set; }
        public string Supervisor { get; set; } = null!;
        public short SupApprovalStatus { get; set; }
        public string Administrator { get; set; } = null!;
        public short AdminApprovalStatus { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Or1099am { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Odisamtav { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordavfrt { get; set; }
        public decimal Odavpur { get; set; }
        public decimal Ordavmsc { get; set; }
        public decimal Obkpuramt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Paorigtotcosts { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal Orccdamt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Ochgamt { get; set; }
        public decimal PareimbursableAmount { get; set; }
        public decimal PaorigReimbursableAmt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal Pareimburstaxamt { get; set; }
        public decimal Paorigreimtaxamt { get; set; }
        public string Paerdocnumber { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string PdkProxyId { get; set; } = null!;
        public short PdkEeAppUpdate { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime ModifiedTime { get; set; }
        public DateTime TaxDate { get; set; }
        public byte TaxInvRecvd { get; set; }
        public byte TaxInvReqd { get; set; }
        public string Camcbkid { get; set; } = null!;
        public string Cdocnmbr { get; set; } = null!;
        public DateTime Camtdate { get; set; }
        public decimal Cashamnt { get; set; }
        public decimal Orcasamt { get; set; }
        public string Chamcbid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public decimal Chekamnt { get; set; }
        public decimal Orchkamt { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public int DexRowId { get; set; }
    }
}
