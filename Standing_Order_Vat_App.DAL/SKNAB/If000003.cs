using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class If000003
    {
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public int Jrnentry { get; set; }
        public int Actindx { get; set; }
        public decimal Trxamnt { get; set; }
        public decimal Origamt { get; set; }
        public decimal Xchgrate { get; set; }
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
