using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af50000
    {
        public string Userid { get; set; } = null!;
        public short Reportid { get; set; }
        public short Amntfrom { get; set; }
        public string Budgetid { get; set; } = null!;
        public short Hstyear { get; set; }
        public int Staccndx { get; set; }
        public int Edaccndx { get; set; }
        public short Periodid { get; set; }
        public decimal Ntprfamt { get; set; }
        public decimal Acbegbal { get; set; }
        public decimal Actnpram { get; set; }
        public short Prcssqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
