using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20500
    {
        public string Chekbkid { get; set; } = null!;
        public decimal Reconum { get; set; }
        public byte Recond { get; set; }
        public DateTime StmntDate { get; set; }
        public decimal StmntBal { get; set; }
        public decimal Cutoffbal { get; set; }
        public short ClrdPay { get; set; }
        public short ClrdDep { get; set; }
        public decimal ClrePayAmt { get; set; }
        public decimal ClrdDepAmt { get; set; }
        public decimal ClearedDifference { get; set; }
        public decimal Outpaytot { get; set; }
        public decimal Outdeptot { get; set; }
        public decimal Iinadjtot { get; set; }
        public decimal Decadjtot { get; set; }
        public decimal Asofbal { get; set; }
        public DateTime Cutofdat { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Rcrdstts { get; set; }
        public byte[] ReconcileMessages { get; set; } = null!;
        public string Audittrail { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
