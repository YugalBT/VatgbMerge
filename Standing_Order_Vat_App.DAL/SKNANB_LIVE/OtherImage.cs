using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class OtherImage
    {
        public int ImageId { get; set; }
        public byte[]? Image { get; set; }
        public int? ImageSize { get; set; }
        public DateTime? DateAded { get; set; }
        public string? Description { get; set; }
    }
}
