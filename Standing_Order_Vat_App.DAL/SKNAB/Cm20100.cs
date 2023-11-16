using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20100
    {
        public decimal Cmdnumwk { get; set; }
        public decimal RecNumControl { get; set; }
        public byte Voided { get; set; }
        public short Cntrltyp { get; set; }
        public string Audittrail { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short CmtrxType { get; set; }
        public string CmtrxNum { get; set; } = null!;
        public byte[] Cmerrmsg { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
