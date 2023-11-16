using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv50300
    {
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public short Itemtype { get; set; }
        public short Abccode { get; set; }
        public short Sggstdabccd { get; set; }
        public byte Includeitem { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Prcntofttl { get; set; }
        public decimal Cmltvprcntofttl { get; set; }
        public decimal Cmltvprcntofitms { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Rankingvalue { get; set; }
        public decimal Smmrydpndntusgqty { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public byte Updated { get; set; }
        public int DexRowId { get; set; }
    }
}
