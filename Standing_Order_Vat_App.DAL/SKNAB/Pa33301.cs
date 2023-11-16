using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa33301
    {
        public string Padocnumber20 { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public DateTime Cutofdat { get; set; }
        public DateTime Papd { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public decimal ParecognizedProjRev { get; set; }
        public decimal ParecognizedBudgRev { get; set; }
        public decimal ParecognizedFeeRev { get; set; }
        public decimal Pabieeamount { get; set; }
        public decimal Paeiebamount { get; set; }
        public int Lnitmseq { get; set; }
        public int Dstsqnum { get; set; }
        public byte[] Parrdisterr { get; set; } = null!;
        public byte[] Parrhdrerr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
