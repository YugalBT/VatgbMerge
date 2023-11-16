using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06110
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Frmwostat { get; set; } = null!;
        public string Towostat { get; set; } = null!;
        public string Stationid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string SvcAuditDescription { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
