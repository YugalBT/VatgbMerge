using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc3020v
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Docid { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Locncode { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
