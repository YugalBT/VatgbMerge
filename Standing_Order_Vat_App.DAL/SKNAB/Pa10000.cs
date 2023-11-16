using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10000
    {
        public short Patstyp { get; set; }
        public string Patsno { get; set; } = null!;
        public string PdkTsNo { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public short Payr { get; set; }
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public short PaEmployedBy { get; set; }
        public short Parepd { get; set; }
        public DateTime Parepdt { get; set; }
        public DateTime PaperiodEndDate { get; set; }
        public string Pacomm { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal Patqty { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Patacrv { get; set; }
        public decimal Noteindx { get; set; }
        public string Pareptsuff { get; set; } = null!;
        public DateTime Papd { get; set; }
        public int Lnitmseq { get; set; }
        public byte[] PatsHdrErrors { get; set; } = null!;
        public byte[] PatsDistErrors { get; set; } = null!;
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
        public decimal Paorigtotcosts { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public string PdkProxyId { get; set; } = null!;
        public short CorrectingTrxType { get; set; }
        public string Paoriginldocnum { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
