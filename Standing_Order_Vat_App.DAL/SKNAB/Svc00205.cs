using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00205
    {
        public short Srvrectype { get; set; }
        public int Lnitmseq { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public short SvcDocumentType { get; set; }
        public string SvcDocumentNumber { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
