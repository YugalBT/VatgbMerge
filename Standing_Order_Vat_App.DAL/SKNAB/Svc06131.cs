﻿using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06131
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public int Seqnumbr { get; set; }
        public short SvcDistributionType { get; set; }
        public string DistRef { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public int DexRowId { get; set; }
    }
}