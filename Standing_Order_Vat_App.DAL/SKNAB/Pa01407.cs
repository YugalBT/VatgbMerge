using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01407
    {
        public string ParateTableId { get; set; } = null!;
        public string Paequiptid { get; set; } = null!;
        public string PaunitOfMeasure { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public short PaprofitType { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal PaprofitPercent { get; set; }
        public string PaoverheadGroupId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
