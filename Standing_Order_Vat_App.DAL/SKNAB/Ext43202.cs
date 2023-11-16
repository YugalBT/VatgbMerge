using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext43202
    {
        public string PtEnquiryId { get; set; } = null!;
        public string PtWindowDescription { get; set; } = null!;
        public string PtWindowId { get; set; } = null!;
        public short Prodid { get; set; }
        public string Formname { get; set; } = null!;
        public string Winname { get; set; } = null!;
        public string HotKey { get; set; } = null!;
        public byte UseAlternateKeyCb { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
