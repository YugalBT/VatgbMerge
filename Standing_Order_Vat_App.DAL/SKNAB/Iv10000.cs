using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv10000
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Ivdocnbr { get; set; } = null!;
        public string Rcdocnum { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public short Pstgstus { get; set; }
        public decimal Trxqtytl { get; set; }
        public byte[] Ivwhrmsg { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Srcrfrncnmbr { get; set; } = null!;
        public short Sourceindicator { get; set; }
        public int DexRowId { get; set; }
    }
}
