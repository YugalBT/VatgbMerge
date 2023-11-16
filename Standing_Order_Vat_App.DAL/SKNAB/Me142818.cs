using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142818
    {
        public string MeReconcileId { get; set; } = null!;
        public int MeReconcileUpdateSeqNu { get; set; }
        public string Meardlid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public DateTime MeAttemptedDate { get; set; }
        public DateTime MeAttemptedTime { get; set; }
        public string MeReconcileTrxUpdateE { get; set; } = null!;
        public short MeRecordTypeCreated { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
