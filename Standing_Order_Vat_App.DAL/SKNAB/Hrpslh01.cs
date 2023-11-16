using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrpslh01
    {
        public string Employid { get; set; } = null!;
        public string Payrcord { get; set; } = null!;
        public DateTime EffectivedateI { get; set; }
        public int Seqnumbr { get; set; }
        public decimal Payrtamt { get; set; }
        public string Payunit { get; set; } = null!;
        public short Payunper { get; set; }
        public short Payperod { get; set; }
        public decimal Payprprd { get; set; }
        public decimal AnnualsalaryI { get; set; }
        public string ChangereasonI { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
