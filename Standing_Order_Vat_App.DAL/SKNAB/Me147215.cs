using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me147215
    {
        public string Chekbkid { get; set; } = null!;
        public string MeRmEftFile { get; set; } = null!;
        public string MeRmPrenoteFile { get; set; } = null!;
        public string MeCommunicationFileAn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
