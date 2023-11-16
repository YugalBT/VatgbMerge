using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01408
    {
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public byte ContractEntry { get; set; }
        public byte ContractInquire { get; set; }
        public byte ContractReport { get; set; }
        public byte ContractReview { get; set; }
        public byte ProjectEntry { get; set; }
        public byte ProjectInquire { get; set; }
        public byte ProjectReport { get; set; }
        public byte ProjectReview { get; set; }
        public byte Alentry { get; set; }
        public byte Alinquire { get; set; }
        public byte Alreport { get; set; }
        public byte Alreview { get; set; }
        public byte Eeentry { get; set; }
        public byte Eeinquire { get; set; }
        public byte Eereport { get; set; }
        public byte Eereview { get; set; }
        public byte Elentry { get; set; }
        public byte Elinquire { get; set; }
        public byte Elreport { get; set; }
        public byte Elreview { get; set; }
        public byte Ffentry { get; set; }
        public byte Ffinquire { get; set; }
        public byte Ffreport { get; set; }
        public byte Ffreview { get; set; }
        public byte Poentry { get; set; }
        public byte Poinquire { get; set; }
        public byte Poreport { get; set; }
        public byte Rqentry { get; set; }
        public byte Rqinquire { get; set; }
        public byte Rqreport { get; set; }
        public byte Rqreview { get; set; }
        public byte Tsentry { get; set; }
        public byte Tsinquire { get; set; }
        public byte Tsreport { get; set; }
        public byte Tsreview { get; set; }
        public byte Vientry { get; set; }
        public byte Viinquire { get; set; }
        public byte Vireport { get; set; }
        public byte Vireview { get; set; }
        public int DexRowId { get; set; }
    }
}
