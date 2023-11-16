using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa42100
    {
        public DateTime Periodstartdate { get; set; }
        public DateTime Periodenddate { get; set; }
        public short Periodid { get; set; }
        public short Fiscalyear { get; set; }
        public int DexRowId { get; set; }
    }
}
