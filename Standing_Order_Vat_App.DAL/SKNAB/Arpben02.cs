using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Arpben02
    {
        public string EmpidI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public short IindexI { get; set; }
        public short Relationship { get; set; }
        public string Commentstr20 { get; set; } = null!;
        public byte PrimaryI { get; set; }
        public string FfirstnameI { get; set; } = null!;
        public short BeneficiarypercentI { get; set; }
        public string MiI { get; set; } = null!;
        public string LlastnameI { get; set; } = null!;
        public string DepssnI { get; set; } = null!;
        public short Gender { get; set; }
        public DateTime DateofbirthI { get; set; }
        public int DexRowId { get; set; }
    }
}
