using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05020
    {
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Lnitmseq { get; set; }
        public string Svcfrmstat { get; set; } = null!;
        public string Svctostat { get; set; } = null!;
        public string Dscrption { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
