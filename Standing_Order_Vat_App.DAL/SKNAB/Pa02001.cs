using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02001
    {
        public short Pasetupkey { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime PalastBeginDate { get; set; }
        public DateTime PalastEndDate { get; set; }
        public int DexRowId { get; set; }
    }
}
