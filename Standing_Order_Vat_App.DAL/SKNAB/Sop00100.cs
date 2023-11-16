using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop00100
    {
        public string Prchldid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte Xferphol { get; set; }
        public byte Postphol { get; set; }
        public byte Fufiphol { get; set; }
        public byte Prinphol { get; set; }
        public byte Workflowhold { get; set; }
        public decimal Noteindx { get; set; }
        public string User2ent { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
