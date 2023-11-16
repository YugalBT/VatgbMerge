using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00900
    {
        public string Timezone { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Timezonevalue { get; set; }
        public short TimeZoneMinute { get; set; }
        public int DexRowId { get; set; }
    }
}
