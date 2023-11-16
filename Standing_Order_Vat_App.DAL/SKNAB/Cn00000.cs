using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00000
    {
        public string Uniqkey { get; set; } = null!;
        public short VersionMajor { get; set; }
        public short VersionMinor { get; set; }
        public short VersionBuild { get; set; }
        public DateTime CnInstallationDate { get; set; }
        public int DexRowId { get; set; }
    }
}
