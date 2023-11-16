using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me147218
    {
        public string MeEftNumber { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public int MeNumberOfEfts { get; set; }
        public decimal MeEftTotal { get; set; }
        public string MeCommunicationFileAn { get; set; } = null!;
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
