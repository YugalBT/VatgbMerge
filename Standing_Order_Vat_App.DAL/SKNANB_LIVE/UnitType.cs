using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class UnitType
    {
        public UnitType()
        {
            Units = new HashSet<Unit>();
        }

        public int UnitTypeId { get; set; }
        public string UnitTypeName { get; set; } = null!;

        public virtual ICollection<Unit> Units { get; set; }
    }
}
