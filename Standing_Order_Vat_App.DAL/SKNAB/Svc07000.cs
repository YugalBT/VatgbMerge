using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07000
    {
        public decimal MenuId { get; set; }
        public string Name { get; set; } = null!;
        public string KeyCode { get; set; } = null!;
        public string Path { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
