using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd002
    {
        public short Keynumbr { get; set; }
        public int Rcvdpmntdocglacct { get; set; }
        public int Assesspmntdocglacctidx { get; set; }
        public int Discpmntdocglacctidx { get; set; }
        public int Collectpmntdocglacct { get; set; }
        public int Nsfpmntdocglacct { get; set; }
        public int Settlepmntdocglacct { get; set; }
        public short AssessGlentryLevel { get; set; }
        public short DiscGlentryLevel { get; set; }
        public short CollectGlentryLevel { get; set; }
        public short SettleGlentryLevel { get; set; }
        public int DexRowId { get; set; }
    }
}
