using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VisaCard
    {
        public int IdCard { get; set; }
        public int IdCif { get; set; }
        public string IdCardNum { get; set; } = null!;
        public int IdCardholder { get; set; }
        public string NmNameoncard { get; set; } = null!;
        public string TxIfLost { get; set; } = null!;
        public DateTime? DtReceived { get; set; }
        public DateTime? DtIssued { get; set; }
        public decimal? MnyCreditline { get; set; }
        public decimal? MnyWdLimit { get; set; }
        public DateTime? DtValidThru { get; set; }
        public DateTime? DtActivated { get; set; }
        public string? NmByWhom { get; set; }
        public string? TxTelecodeNo { get; set; }
        public string? TxC { get; set; }
        public string? TxCvv { get; set; }
        public string InPayMthd { get; set; } = null!;
        public bool InActive { get; set; }
        public string InDelFlg { get; set; } = null!;
        public int IdBin { get; set; }
        public string IdCheckDigit { get; set; } = null!;
        public short IdMemberNum { get; set; }
        public short IdType { get; set; }
        public string? AcUser { get; set; }
        public int IdPrimCard { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; } = null!;

        public virtual Profile IdCardholderNavigation { get; set; } = null!;
    }
}
