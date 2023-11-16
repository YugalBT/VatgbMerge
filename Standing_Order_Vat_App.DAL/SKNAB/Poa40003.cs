using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Poa40003
    {
        public string Ponumber { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short Statgrp { get; set; }
        public DateTime Docdate { get; set; }
        public string PoaCreatedBy { get; set; } = null!;
        public short PoaPoApprovalStatus { get; set; }
        public decimal Remsubto { get; set; }
        public string PoaApprovedBy { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public DateTime PoaApprovalTime { get; set; }
        public int DexRowId { get; set; }
    }
}
