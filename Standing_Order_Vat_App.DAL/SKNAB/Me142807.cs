using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142807
    {
        public string Meardlid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Arnum { get; set; } = null!;
        public string MeTransactionCode { get; set; } = null!;
        public string Metrxstatcode { get; set; } = null!;
        public byte MeUpdatedCmtrxTable { get; set; }
        public DateTime MeUpdatedDate { get; set; }
        public DateTime MeDownloadDate { get; set; }
        public DateTime MeDownloadTime { get; set; }
        public string MeUpdatedUserId { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string MeAccountHolder { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public string CmtrxNum { get; set; } = null!;
        public byte MeIsAClear { get; set; }
        public short CmtrxType { get; set; }
        public string Paidtorcvdfrom { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int Dstindx { get; set; }
        public string Actnumbr1 { get; set; } = null!;
        public string Actnumbr2 { get; set; } = null!;
        public string Actnumbr3 { get; set; } = null!;
        public string Actnumbr4 { get; set; } = null!;
        public string Actnumbr5 { get; set; } = null!;
        public string Actnumbr6 { get; set; } = null!;
        public string Actnumbr7 { get; set; } = null!;
        public string Actnumbr8 { get; set; } = null!;
        public string Actnumbr9 { get; set; } = null!;
        public string Actnumbr10 { get; set; } = null!;
        public short Doctype { get; set; }
        public string DistRef { get; set; } = null!;
        public short MeTransactionType { get; set; }
        public decimal Trxamnt { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public byte MeDummyFileConvertDe { get; set; }
        public int DexRowId { get; set; }
    }
}
