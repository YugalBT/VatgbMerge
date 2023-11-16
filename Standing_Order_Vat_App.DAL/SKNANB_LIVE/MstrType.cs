using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class MstrType
    {
        public MstrType()
        {
            SubTypes = new HashSet<SubType>();
        }

        public int IdMstrTyp { get; set; }
        public string NmMstrTyp { get; set; } = null!;
        public string? TxDesc { get; set; }
        public int? IdMstrTypMngr { get; set; }

        public virtual ICollection<SubType> SubTypes { get; set; }
    }
}
