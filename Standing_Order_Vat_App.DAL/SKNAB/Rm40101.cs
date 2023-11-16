using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40101
    {
        public short Setupkey { get; set; }
        public short Ageby { get; set; }
        public short Agperend1 { get; set; }
        public short Agperend2 { get; set; }
        public short Agperend3 { get; set; }
        public short Agperend4 { get; set; }
        public short Agperend5 { get; set; }
        public short Agperend6 { get; set; }
        public short Agperend7 { get; set; }
        public short Agperusd { get; set; }
        public string Crlmpswd { get; set; } = null!;
        public string Custhpwd { get; set; } = null!;
        public string Wrtfpswd { get; set; } = null!;
        public string Wvfchpwd { get; set; } = null!;
        public byte Prthatrb { get; set; }
        public byte Cpdfinch { get; set; }
        public byte Rmtrkdav { get; set; }
        public byte Rmpcaipd { get; set; }
        public decimal Nsfchdef { get; set; }
        public short Aplbydef { get; set; }
        public DateTime Ldfnchgd { get; set; }
        public DateTime Ldstprtd { get; set; }
        public DateTime Ldblfagd { get; set; }
        public DateTime Ldoitagd { get; set; }
        public DateTime Ldptrrmv { get; set; }
        public DateTime Lstyecal { get; set; }
        public DateTime Lstyefsc { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Slschdid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public byte Salescb { get; set; }
        public byte Discntcb { get; set; }
        public byte Freight { get; set; }
        public byte Misc { get; set; }
        public byte Tax { get; set; }
        public byte[] Rmvdstty1 { get; set; } = null!;
        public byte[] Rmvdstty2 { get; set; } = null!;
        public byte[] Rmvdstty3 { get; set; } = null!;
        public byte[] Rmvdstty4 { get; set; } = null!;
        public byte[] Rmvdstty5 { get; set; } = null!;
        public byte[] Rmvdstty6 { get; set; } = null!;
        public byte[] Rmvdstty7 { get; set; } = null!;
        public byte[] Rmvdstty8 { get; set; } = null!;
        public byte[] Rmvdstty9 { get; set; } = null!;
        public DateTime Ldcmtrns { get; set; }
        public string Prclevel { get; set; } = null!;
        public short Rmdftyp { get; set; }
        public byte DelUpdoc { get; set; }
        public byte PrntTaxDetDoc { get; set; }
        public byte Rprntsttmnts { get; set; }
        public byte Atapplfnncchrgsfrst { get; set; }
        public string EmailStmtStatusRecipient { get; set; } = null!;
        public short DateSensitivitySumView { get; set; }
        public byte Prntdcur { get; set; }
        public byte Ageunappldcr { get; set; }
        public string WriteoffCreditMemoNumber { get; set; } = null!;
        public string WriteoffDebitMemoNumber { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
