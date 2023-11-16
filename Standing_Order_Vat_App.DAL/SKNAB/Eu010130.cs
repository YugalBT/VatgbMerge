using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Eu010130
    {
        public short MsequenceI { get; set; }
        public string EmpidI { get; set; } = null!;
        public string MstringI1 { get; set; } = null!;
        public string MstringI2 { get; set; } = null!;
        public string MstringI3 { get; set; } = null!;
        public string MstringI4 { get; set; } = null!;
        public string MstringI5 { get; set; } = null!;
        public int MlintI1 { get; set; }
        public int MlintI2 { get; set; }
        public int MlintI3 { get; set; }
        public int MlintI4 { get; set; }
        public int MlintI5 { get; set; }
        public decimal MdlrI1 { get; set; }
        public decimal MdlrI2 { get; set; }
        public decimal MdlrI3 { get; set; }
        public decimal MdlrI4 { get; set; }
        public decimal MdlrI5 { get; set; }
        public byte McheckI1 { get; set; }
        public byte McheckI2 { get; set; }
        public byte McheckI3 { get; set; }
        public byte McheckI4 { get; set; }
        public byte McheckI5 { get; set; }
        public byte McheckI6 { get; set; }
        public byte McheckI7 { get; set; }
        public byte McheckI8 { get; set; }
        public byte McheckI9 { get; set; }
        public byte McheckI10 { get; set; }
        public DateTime Mdate1I { get; set; }
        public DateTime Mdate2I { get; set; }
        public DateTime Mdate3I { get; set; }
        public DateTime Mdate4I { get; set; }
        public DateTime Mdate5I { get; set; }
        public string MtimeI1 { get; set; } = null!;
        public string MtimeI2 { get; set; } = null!;
        public string MtimeI3 { get; set; } = null!;
        public string MtimeI4 { get; set; } = null!;
        public string MtimeI5 { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
