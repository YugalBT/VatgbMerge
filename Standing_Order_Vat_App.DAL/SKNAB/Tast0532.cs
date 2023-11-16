using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tast0532
    {
        public short Year1 { get; set; }
        public short Payperod { get; set; }
        public short IsequencenumberI { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Accrued { get; set; }
        public int DexRowId { get; set; }
    }
}
