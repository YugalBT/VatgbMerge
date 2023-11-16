using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00625
    {
        public string Userid { get; set; } = null!;
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public string Cnttype { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal OrigTransactionAmount { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
