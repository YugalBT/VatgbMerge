using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd005
    {
        public string Custnmbr { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short CheckbookFrom { get; set; }
        public int Rcvdpmntdocglacct { get; set; }
        public int Assesspmntdocglacctidx { get; set; }
        public int Discpmntdocglacctidx { get; set; }
        public int Collectpmntdocglacct { get; set; }
        public int Nsfpmntdocglacct { get; set; }
        public int Settlepmntdocglacct { get; set; }
        public short PmntDocGlacctFrom { get; set; }
        public decimal MaxPmntDocAmt { get; set; }
        public short MaxPmntDocAmtFrom { get; set; }
        public string ExceedPmntDocPassword { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
