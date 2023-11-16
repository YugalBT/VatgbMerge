using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cam40001
    {
        public short Sgmtnumb { get; set; }
        public short CamSeries { get; set; }
        public byte Camactivated { get; set; }
        public byte CamDistributionCreated { get; set; }
        public byte CamPosted { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Trxsrcpx { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
