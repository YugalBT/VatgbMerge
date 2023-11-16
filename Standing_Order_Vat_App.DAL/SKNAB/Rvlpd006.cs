using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd006
    {
        public string Chekbkid { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string NextPmntDocNum { get; set; } = null!;
        public int Rcvdpmntdocglacct { get; set; }
        public int Assesspmntdocglacctidx { get; set; }
        public int Discpmntdocglacctidx { get; set; }
        public int Collectpmntdocglacct { get; set; }
        public int Nsfpmntdocglacct { get; set; }
        public int Settlepmntdocglacct { get; set; }
        public string RcvdPmntDocCheckbook { get; set; } = null!;
        public string AssessPmntDocCheckbook { get; set; } = null!;
        public string Discpmntdoccheckbook { get; set; } = null!;
        public string CollectPmntDocCheckbook { get; set; } = null!;
        public string NsfpmntDocCheckbook { get; set; } = null!;
        public string SettlePmntDocCheckbook { get; set; } = null!;
        public decimal MaxPmntDocAmt { get; set; }
        public string ExceedPmntDocPassword { get; set; } = null!;
        public byte DuplicatePmntDocNum { get; set; }
        public byte OverridePmntDocNum { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
