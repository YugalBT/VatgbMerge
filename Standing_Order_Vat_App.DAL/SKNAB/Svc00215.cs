using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00215
    {
        public string Userid { get; set; } = null!;
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public string Srvstat { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Offname { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string Svcdescr { get; set; } = null!;
        public decimal Pretaxtot { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
