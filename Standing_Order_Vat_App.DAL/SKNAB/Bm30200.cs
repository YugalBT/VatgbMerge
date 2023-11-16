using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm30200
    {
        public string TrxId { get; set; } = null!;
        public short BmTrxStatus { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public decimal BatchIdNoteIndex { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime BmStartDate { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Refrence { get; set; } = null!;
        public byte[] BmTrxErrors { get; set; } = null!;
        public byte[] BmComponentErrors { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public string User2ent { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
