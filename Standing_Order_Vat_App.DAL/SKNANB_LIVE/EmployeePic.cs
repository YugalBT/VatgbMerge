using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class EmployeePic
    {
        public int ImageId { get; set; }
        public byte[] Image { get; set; } = null!;
        public DateTime? DateAdded { get; set; }
        public int? IdSocialSec { get; set; }
    }
}
