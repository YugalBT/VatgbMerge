using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00901
    {
        public int Jrnentry { get; set; }
        public DateTime Glinttrxdate { get; set; }
        public string Glintbtchnum { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public int Bookindx { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public int Numoftrx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
