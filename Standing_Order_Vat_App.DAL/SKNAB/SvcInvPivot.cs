using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class SvcInvPivot
    {
        public string Techid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public short? Itemtype { get; set; }
        public string? Itemdesc { get; set; }
        public string? Itmshnam { get; set; }
        public decimal? Listprce { get; set; }
        public short? Itmtrkop { get; set; }
        public byte? Rtrnable { get; set; }
        public byte? Metered { get; set; }
        public short? Rcrdtype { get; set; }
        public decimal? Goodqty { get; set; }
        public decimal? Badqty { get; set; }
        public decimal? Goodatyalloc { get; set; }
        public decimal? Badatyalloc { get; set; }
    }
}
