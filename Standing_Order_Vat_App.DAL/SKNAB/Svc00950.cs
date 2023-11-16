using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00950
    {
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public byte Workdys1 { get; set; }
        public byte Workdys2 { get; set; }
        public byte Workdys3 { get; set; }
        public byte Workdys4 { get; set; }
        public byte Workdys5 { get; set; }
        public byte Workdys6 { get; set; }
        public byte Workdys7 { get; set; }
        public DateTime Workstrt1 { get; set; }
        public DateTime Workstrt2 { get; set; }
        public DateTime Workstrt3 { get; set; }
        public DateTime Workstrt4 { get; set; }
        public DateTime Workstrt5 { get; set; }
        public DateTime Workstrt6 { get; set; }
        public DateTime Workstrt7 { get; set; }
        public DateTime Workend1 { get; set; }
        public DateTime Workend2 { get; set; }
        public DateTime Workend3 { get; set; }
        public DateTime Workend4 { get; set; }
        public DateTime Workend5 { get; set; }
        public DateTime Workend6 { get; set; }
        public DateTime Workend7 { get; set; }
        public DateTime Lstsrvdte { get; set; }
        public string Svcarea { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Timezone { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string BillToCustomer { get; set; } = null!;
        public short SvcAddressOption { get; set; }
        public string SvcMiscAddressCode { get; set; } = null!;
        public short SvcPmDate { get; set; }
        public short SvcPmDay { get; set; }
        public byte SvcPmAllowed { get; set; }
        public byte SvcAllowContract0Sop { get; set; }
        public int DexRowId { get; set; }
    }
}
