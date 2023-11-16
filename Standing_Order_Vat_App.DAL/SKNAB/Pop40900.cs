using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop40900
    {
        public short Setupkey { get; set; }
        public string DocDelivTempPath { get; set; } = null!;
        public string DocDelivEmailSubj { get; set; } = null!;
        public string DocDelivFaxSubj { get; set; } = null!;
        public string DocDelivStatusRecipient { get; set; } = null!;
        public int DexRowId { get; set; }
        public string DocDelivEmailBodyText { get; set; } = null!;
        public string DocDelivFaxCoverPgText { get; set; } = null!;
    }
}
