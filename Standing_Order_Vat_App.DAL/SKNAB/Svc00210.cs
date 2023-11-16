using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00210
    {
        public string Callnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public int Lnitmseq { get; set; }
        public string Frmstat { get; set; } = null!;
        public string Tostat { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
