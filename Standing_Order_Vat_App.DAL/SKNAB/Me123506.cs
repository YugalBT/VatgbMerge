using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123506
    {
        public string Chekbkid { get; set; } = null!;
        public string CmtrxNum { get; set; } = null!;
        public string Paidtorcvdfrom { get; set; } = null!;
        public short CmtrxType { get; set; }
        public decimal Trxamnt { get; set; }
        public DateTime Voiddate { get; set; }
        public byte MeDummyFileConvertDe { get; set; }
        public string Cntrlnum { get; set; } = null!;
        public short Mevdtxtp { get; set; }
        public int DexRowId { get; set; }
    }
}
