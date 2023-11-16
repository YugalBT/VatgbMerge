using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm90000
    {
        public string Filename { get; set; } = null!;
        public short EftfileStatus { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Time1 { get; set; }
        public string FilePath { get; set; } = null!;
        public short EftfileType { get; set; }
        public short EfttransmissionType { get; set; }
        public DateTime EftfileGeneratedDate { get; set; }
        public string EftfileGeneratedUserId { get; set; } = null!;
        public DateTime EftfileSentDate { get; set; }
        public string EftfileSentUserId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
