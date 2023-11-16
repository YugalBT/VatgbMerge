using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class EntryStatus
    {
        public EntryStatus()
        {
            DormantRegisters = new HashSet<DormantRegister>();
            ForeignChecksBatches = new HashSet<ForeignChecksBatch>();
        }

        public int EntryStatusId { get; set; }
        public string EntryStatusDescription { get; set; } = null!;

        public virtual ICollection<DormantRegister> DormantRegisters { get; set; }
        public virtual ICollection<ForeignChecksBatch> ForeignChecksBatches { get; set; }
    }
}
