using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Unit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public int UnitTypeId { get; set; }
        public int CompanyId { get; set; }
        public int? ManagerId { get; set; }

        public virtual UnitType UnitType { get; set; } = null!;
    }
}
