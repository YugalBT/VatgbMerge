using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23100
    {
        public short Pabilltrxt { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Padocdt { get; set; }
        public DateTime Papd { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Pauserid { get; set; } = null!;
        public DateTime Lstedtdt { get; set; }
        public string Lstusred { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public string Prbtadcd { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public string Pabillformat { get; set; } = null!;
        public string Pacomm { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal Cashamnt { get; set; }
        public string Cbkidcsh { get; set; } = null!;
        public DateTime Cashdate { get; set; }
        public string Dcnumcsh { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Cbkidchk { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Dcnumchk { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public string Crcrdnam { get; set; } = null!;
        public string Rctnccrd { get; set; } = null!;
        public DateTime Crcarddt { get; set; }
        public string Dcnumcrd { get; set; } = null!;
        public short Dscpctam { get; set; }
        public decimal Dscdlram { get; set; }
        public decimal Disavamt { get; set; }
        public decimal Discamnt { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Distknam { get; set; }
        public decimal Discrtnd { get; set; }
        public decimal PabillingAmount { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal PaFreightAmount { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal PaMiscAmount { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Patottax { get; set; }
        public decimal Pabackbill { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public decimal Docamnt { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Appldamt { get; set; }
        public DateTime PalastDateApplied { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public decimal Comdlram { get; set; }
        public short Comappto { get; set; }
        public int Lnitmseq { get; set; }
        public DateTime Cutofdat { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public short Misctxbl { get; set; }
        public string Frtschid { get; set; } = null!;
        public short Frgttxbl { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal Patotbillings { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public byte PaapplyTax { get; set; }
        public decimal PaAppliedFreightMisc { get; set; }
        public short Agngbukt { get; set; }
        public string Palastprtby { get; set; } = null!;
        public DateTime Palastprtdate { get; set; }
        public decimal Orcasamt { get; set; }
        public decimal Orchkamt { get; set; }
        public decimal Orccdamt { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Ordavamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Orbktfrt { get; set; }
        public decimal Orbktmsc { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal PaorigBillAmount { get; set; }
        public decimal PaorigFreightAmt { get; set; }
        public decimal PaorigMiscAmt { get; set; }
        public decimal PaorigTotalTaxAmt { get; set; }
        public decimal PaorigBackoutBillAmt { get; set; }
        public decimal PaorigRetentionFeeAmt { get; set; }
        public decimal PaorigTotalBilings { get; set; }
        public decimal PaorigRetainerFeeAmt { get; set; }
        public decimal PaorigDiscTakenAmt { get; set; }
        public decimal PaorigDiscRetAmt { get; set; }
        public decimal PaorigAppliedFreightMisc { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public byte PapostoDynRm { get; set; }
        public DateTime TaxDate { get; set; }
        public byte PaThirdPartyCb { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal BackoutTradeDiscTax { get; set; }
        public decimal OrigBackoutTradeDiscTax { get; set; }
        public decimal PaBackoutRetentionTax { get; set; }
        public decimal PaOrigBackRetentionTax { get; set; }
        public int DexRowId { get; set; }
    }
}
