using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpppc01
    {
        public string PositioncodeI { get; set; } = null!;
        public string Payrcord { get; set; } = null!;
        public short TableI { get; set; }
        public short RowI { get; set; }
        public short ColI { get; set; }
        public short RowmedI { get; set; }
        public short ColmedI { get; set; }
        public short RowhighI { get; set; }
        public short ColhighI { get; set; }
        public short CompensationperiodI { get; set; }
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
