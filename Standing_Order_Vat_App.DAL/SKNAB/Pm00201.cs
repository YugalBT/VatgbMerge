using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00201
    {
        public string Vendorid { get; set; } = null!;
        public decimal Hiestbal { get; set; }
        public decimal Currblnc { get; set; }
        public int Noinvytd { get; set; }
        public int Noinvlif { get; set; }
        public int Noinvlyr { get; set; }
        public int Nopinytd { get; set; }
        public int Nopilife { get; set; }
        public decimal Ambldtyd { get; set; }
        public decimal Ambldlif { get; set; }
        public decimal Ambldlyr { get; set; }
        public decimal Amtpdytd { get; set; }
        public decimal Amtpdlif { get; set; }
        public decimal Amtpdlyr { get; set; }
        public decimal Ten99aytd { get; set; }
        public decimal Ten99alif { get; set; }
        public decimal Ten99alyr { get; set; }
        public decimal Disavytd { get; set; }
        public decimal Disavlif { get; set; }
        public decimal Disavlyr { get; set; }
        public decimal Distkytd { get; set; }
        public decimal Distknlf { get; set; }
        public decimal Distklyr { get; set; }
        public decimal Dislsytd { get; set; }
        public decimal Dislstlf { get; set; }
        public decimal Dislslyr { get; set; }
        public decimal Finchlif { get; set; }
        public decimal Finchlyr { get; set; }
        public decimal Finchytd { get; set; }
        public decimal Wrofsytd { get; set; }
        public decimal Wrofslif { get; set; }
        public decimal Wrofslyr { get; set; }
        public decimal Rtrnsytd { get; set; }
        public decimal Rtrnslif { get; set; }
        public decimal Rtrnslyr { get; set; }
        public decimal Trdtklif { get; set; }
        public decimal Trdtlyr { get; set; }
        public decimal Trdtytd { get; set; }
        public int Nfnchlif { get; set; }
        public int Nfnchlyr { get; set; }
        public int Nfnchytd { get; set; }
        public decimal Rtngowed { get; set; }
        public string Lstchnum { get; set; } = null!;
        public DateTime Lstchkdt { get; set; }
        public decimal Lstchamt { get; set; }
        public string Lstinnum { get; set; } = null!;
        public decimal Lstinvam { get; set; }
        public DateTime Lstpurdt { get; set; }
        public DateTime Fstpurdt { get; set; }
        public decimal Curunpbn { get; set; }
        public decimal Unpdfnch { get; set; }
        public short Dychtclr { get; set; }
        public short Avgdtpyr { get; set; }
        public short Avdtplif { get; set; }
        public decimal Accrdinv { get; set; }
        public decimal Onordamt { get; set; }
        public decimal Withytd { get; set; }
        public decimal Withlyr { get; set; }
        public decimal WithholdingLife { get; set; }
        public int DexRowId { get; set; }
    }
}
