using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpben05
    {
        public string CompanycodeI { get; set; } = null!;
        public short Set12monthI { get; set; }
        public DateTime O12monthstartI { get; set; }
        public short ScopeofperiodI { get; set; }
        public short DaysI { get; set; }
        public decimal HoursworkedperdayI { get; set; }
        public int DexRowId { get; set; }
    }
}
