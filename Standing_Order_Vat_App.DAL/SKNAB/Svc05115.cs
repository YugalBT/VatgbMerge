using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05115
    {
        public string Userid { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Rettype { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string ReturnItemNumber { get; set; } = null!;
        public decimal ReturnQty { get; set; }
        public decimal RepairCost { get; set; }
        public decimal RepairPrice { get; set; }
        public decimal OriginatingRepairCost { get; set; }
        public decimal OriginatingRepairPrice { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public byte Prntdtld { get; set; }
        public int DexRowId { get; set; }
    }
}
