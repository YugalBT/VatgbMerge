using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11800
    {
        public short Patu { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public short Patrxtype { get; set; }
        public DateTime Padocdt { get; set; }
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Pacostowner { get; set; } = null!;
        public short Parepd { get; set; }
        public DateTime Parepdt { get; set; }
        public string Pareptsuff { get; set; } = null!;
        public short Payr { get; set; }
        public string Paveninvno { get; set; } = null!;
        public string Pavenaddressid { get; set; } = null!;
        public string Pacomm { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public DateTime Duedate { get; set; }
        public decimal Dscdlram { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Disamtav { get; set; }
        public short Prctdisc { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public decimal Patqty { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Bktpuram { get; set; }
        public decimal Patacrv { get; set; }
        public decimal Trdisamt { get; set; }
        public short PafreightTaxableP { get; set; }
        public string Frtschid { get; set; } = null!;
        public decimal Frtamnt { get; set; }
        public decimal Frttxamt { get; set; }
        public short PamiscTaxableP { get; set; }
        public string Mscschid { get; set; } = null!;
        public decimal Mscchamt { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ten99amnt { get; set; }
        public decimal Un1099am { get; set; }
        public decimal Cashamnt { get; set; }
        public string Camcbkid { get; set; } = null!;
        public string Cdocnmbr { get; set; } = null!;
        public DateTime Camtdate { get; set; }
        public string Campmtnm { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Campynbr { get; set; } = null!;
        public string Chamcbid { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public string Cardname { get; set; } = null!;
        public DateTime Crcarddt { get; set; }
        public string Ccampynm { get; set; } = null!;
        public string Ccrctnum { get; set; } = null!;
        public decimal Distknam { get; set; }
        public decimal Chrgamnt { get; set; }
        public int Lnitmseq { get; set; }
        public DateTime Papd { get; set; }
        public short Voidstts { get; set; }
        public DateTime Voiddate { get; set; }
        public decimal Noteindx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public decimal Paorigtotcosts { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal Disavamt { get; set; }
        public string Taxschid { get; set; } = null!;
        public string Pymnttrm { get; set; } = null!;
        public short Poptype { get; set; }
        public string Vnddocnm { get; set; } = null!;
        public DateTime Actlship { get; set; }
        public DateTime Glpostdt { get; set; }
        public short Dscpctam { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
