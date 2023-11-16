using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me123504
    {
        public string Meupldid { get; set; } = null!;
        public string PpNumber { get; set; } = null!;
        public DateTime Meupdt { get; set; }
        public DateTime Meuptim { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public string CmtrxNum { get; set; } = null!;
        public short CmtrxType { get; set; }
        public decimal Trxamnt { get; set; }
        public string Paidtorcvdfrom { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public byte MeDummyFileConvertDe { get; set; }
        public int DexRowId { get; set; }
    }
}
