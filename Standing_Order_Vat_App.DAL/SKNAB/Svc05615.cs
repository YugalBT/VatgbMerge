using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05615
    {
        public string Userid { get; set; } = null!;
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public string RtvType { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public decimal Quantity { get; set; }
        public string Loccodeb { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string TrackingNumber { get; set; } = null!;
        public byte CbPackingSlip { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
