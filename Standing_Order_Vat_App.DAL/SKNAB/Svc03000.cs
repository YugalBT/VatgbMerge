using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc03000
    {
        public short SvcMasterDocumentType { get; set; }
        public string SvcMasterDocumentNumb { get; set; } = null!;
        public short SvcSourceDocumentId { get; set; }
        public short SvcSourceDocType { get; set; }
        public string Srcdocnum { get; set; } = null!;
        public short SvcDocumentId { get; set; }
        public string SvcModule { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public DateTime SvcModifiedTime { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
