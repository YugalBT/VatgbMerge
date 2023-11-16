using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05625
    {
        public string Userid { get; set; } = null!;
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public string RtvType { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal Qtyshppd { get; set; }
        public decimal QtyToReceive { get; set; }
        public decimal Qtyrecvd { get; set; }
        public string Vnditnum { get; set; } = null!;
        public string ReturnItemNumber { get; set; } = null!;
        public string TransferReference { get; set; } = null!;
        public int Translineseq { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
