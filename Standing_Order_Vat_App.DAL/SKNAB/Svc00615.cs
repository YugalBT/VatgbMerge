using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00615
    {
        public string Userid { get; set; } = null!;
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public string Cnttype { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Lstbldte { get; set; }
        public DateTime Nxtbldte { get; set; }
        public decimal Totbil { get; set; }
        public decimal LastAmountBilled { get; set; }
        public decimal InvoicedAmount { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public decimal Origtotbil { get; set; }
        public decimal OriglastamountBilled { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
