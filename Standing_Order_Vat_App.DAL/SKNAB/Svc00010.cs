using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00010
    {
        public string Interid { get; set; } = null!;
        public short SvcMajorRelease { get; set; }
        public short SvcMinorRelease { get; set; }
        public string SvcBuildRelease { get; set; } = null!;
        public DateTime SvcInstallDate { get; set; }
        public DateTime SvcUpdateDate { get; set; }
        public string SvcServerUpd { get; set; } = null!;
        public string SvcClientUpd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
