using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07100
    {
        public int SvcIssueNumber { get; set; }
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public string SvcCbrNumber { get; set; } = null!;
        public short SvcAction { get; set; }
        public byte SvcTemplateCallNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
