using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41500
    {
        public string Shftcode { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Shfttype { get; set; }
        public decimal Shftamt { get; set; }
        public decimal Shftpct { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
