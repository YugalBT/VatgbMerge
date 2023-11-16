using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mposhist
    {
        public string EmpidI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public DateTime ChangetimeI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public string PositionI { get; set; } = null!;
        public string CompanyI { get; set; } = null!;
        public string DivisionI { get; set; } = null!;
        public string DepartmentnameI { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public string Supervisor { get; set; } = null!;
        public string LocationI { get; set; } = null!;
        public decimal Fte { get; set; }
        public string RevisionlevelI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
