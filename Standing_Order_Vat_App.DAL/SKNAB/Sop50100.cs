using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop50100
    {
        public short Procorig { get; set; }
        public string Userid { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public DateTime Docdate { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Docid { get; set; } = null!;
        public short Error { get; set; }
        public int DexRowId { get; set; }
    }
}
