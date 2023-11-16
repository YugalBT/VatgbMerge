using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc07550
    {
        public string Mapprloc { get; set; } = null!;
        public string SvcItemImageFolder { get; set; } = null!;
        public short SvcTimeOut { get; set; }
        public short SvcCycleTime { get; set; }
        public string SvcLicensedUser { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
