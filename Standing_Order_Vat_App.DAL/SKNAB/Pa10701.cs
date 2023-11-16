using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10701
    {
        public string Pavidn { get; set; } = null!;
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
        public short Trxtype { get; set; }
        public short Useadvtx { get; set; }
        public int DexRowId { get; set; }
    }
}
