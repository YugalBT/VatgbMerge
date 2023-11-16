using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00922
    {
        public string Srvtype { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public short Esctype { get; set; }
        public string Frmstat { get; set; } = null!;
        public string Tostat { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public short PriorityLevel { get; set; }
        public int Waittme { get; set; }
        public int DexRowId { get; set; }
    }
}
