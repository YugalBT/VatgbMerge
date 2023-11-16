using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00315
    {
        public string Userid { get; set; } = null!;
        public short Year1 { get; set; }
        public string AaYearFld { get; set; } = null!;
        public short FromPeriod { get; set; }
        public short ToPeriod { get; set; }
        public string AaPerFld { get; set; } = null!;
        public string AaPerStr { get; set; } = null!;
        public string AaEmptyCodeStr { get; set; } = null!;
        public byte AaTimeSpreadUsed { get; set; }
        public byte AaCodeSpreadUsed { get; set; }
        public short AaCodeSpreadCol { get; set; }
        public string Thssprtr { get; set; } = null!;
        public string Decsprtr { get; set; } = null!;
        public string AaNegSignLeft { get; set; } = null!;
        public string AaNegSignRight { get; set; } = null!;
        public short AaTruncateTo { get; set; }
        public byte AaClearEmptyCells { get; set; }
        public int DexRowId { get; set; }
        public string AaSqlcreate { get; set; } = null!;
        public string AaSqlinsert { get; set; } = null!;
        public string AaSqlselect { get; set; } = null!;
        public string AaSqlfrom { get; set; } = null!;
        public string AaSqlwhere { get; set; } = null!;
        public string AaSqlgroupBy { get; set; } = null!;
        public string AaSqlcols { get; set; } = null!;
    }
}
