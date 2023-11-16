using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40401
    {
        public string PtEnquiryId { get; set; } = null!;
        public string Fieldnam { get; set; } = null!;
        public string Winname { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
