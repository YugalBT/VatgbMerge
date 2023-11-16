using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07500
    {
        public string Techid { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Accessidlst { get; set; } = null!;
        public DateTime SvcLastConnDate { get; set; }
        public DateTime SvcLastConnTime { get; set; }
        public DateTime SvcLastDisConnDate { get; set; }
        public DateTime SvcLastDisConnTime { get; set; }
        public short SvcETechStatus { get; set; }
        public string SvcMapLocation1 { get; set; } = null!;
        public string SvcMapLocation2 { get; set; } = null!;
        public byte Active { get; set; }
        public DateTime SvcLastAccessDate { get; set; }
        public DateTime SvcLastAccessTime { get; set; }
        public int DexRowId { get; set; }
    }
}
