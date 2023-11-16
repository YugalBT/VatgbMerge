using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10107
    {
        public short Rptngyr { get; set; }
        public string Employid { get; set; } = null!;
        public string Othrcode { get; set; } = null!;
        public short Othbxnum { get; set; }
        public decimal Othramnt { get; set; }
        public byte W2printd { get; set; }
        public int DexRowId { get; set; }
    }
}
