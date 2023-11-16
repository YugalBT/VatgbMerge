using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00999
    {
        public decimal Sequence1 { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Equipid { get; set; }
        public string Orddocid { get; set; } = null!;
        public string Contnbr { get; set; } = null!;
        public string QuoteContractNumber { get; set; } = null!;
        public string TemplateContractNumber { get; set; } = null!;
        public string Invdocid { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public string RtvNumber { get; set; } = null!;
        public string Workordnum { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
