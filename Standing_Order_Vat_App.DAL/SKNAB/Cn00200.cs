using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00200
    {
        public string ActionPromised { get; set; } = null!;
        public string ActionPromisedDescripti { get; set; } = null!;
        public byte ActionCompleted { get; set; }
        public short ActionType { get; set; }
        public short FollowupActionDays { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
