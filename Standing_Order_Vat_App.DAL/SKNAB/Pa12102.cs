using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa12102
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public int PalineItemSeq { get; set; }
        public string PafeeId { get; set; } = null!;
        public short PafeeType { get; set; }
        public decimal Paprevfeeamt { get; set; }
        public decimal Pavarfeesamt { get; set; }
        public decimal PafeeAmount { get; set; }
        public decimal PaPrevFeePercent { get; set; }
        public decimal Pavarfeeprcnt { get; set; }
        public decimal PafeePercent { get; set; }
        public short PafeeToUse { get; set; }
        public short PasalesTaxOptions { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public string Paprevbilltxsched { get; set; } = null!;
        public DateTime Pabegindate { get; set; }
        public DateTime Paprevbegindt { get; set; }
        public DateTime PaenDate { get; set; }
        public DateTime Paprevenddt { get; set; }
        public short Pafrequency { get; set; }
        public short Paprevfreq { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Parenew { get; set; }
        public DateTime ParenewalDate { get; set; }
        public decimal PatotAmt { get; set; }
        public decimal Paprevtotamt { get; set; }
        public short PaRenewDay { get; set; }
        public short PaRenewMonth { get; set; }
        public short Pasequencenumber { get; set; }
        public short TmArFeeSrc { get; set; }
        public short TmPrjDeferredRevFee { get; set; }
        public short TmPrjRevFeeSrc { get; set; }
        public short TmBieeFeeSrc { get; set; }
        public short TmEiebFeeSrc { get; set; }
        public short PaffArFeeSrc { get; set; }
        public short FfPrjBillingsFeeSrc { get; set; }
        public short FfPrjRevFeeSrc { get; set; }
        public short FfRetentionFeeSrc { get; set; }
        public short FfWipFeeSrc { get; set; }
        public short FfPrjDeferredRevFee { get; set; }
        public short FfBieeFeeSrc { get; set; }
        public short FfEiebFeeSrc { get; set; }
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal PapostedProjectFee { get; set; }
        public decimal PapostedRetainerFee { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal PapostedServiceFee { get; set; }
        public int DexRowId { get; set; }
    }
}
