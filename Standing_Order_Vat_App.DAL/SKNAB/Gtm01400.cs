using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm01400
    {
        public int Uniquegrantstatus { get; set; }
        public string Grantstatusdesc { get; set; } = null!;
        public byte Preventtrxdim { get; set; }
        public byte Prevententry { get; set; }
        public byte Preventposting { get; set; }
        public int DexRowId { get; set; }
    }
}
