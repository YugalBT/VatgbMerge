using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00200
    {
        public int Actindx { get; set; }
        public int AaAcctClassId { get; set; }
        public DateTime AaChangeDate { get; set; }
        public DateTime AaChangeTime { get; set; }
        public int DexRowId { get; set; }
    }
}
