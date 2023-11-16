using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy90000
    {
        public string ObjectType { get; set; } = null!;
        public string ObjectId { get; set; } = null!;
        public string PropertyName { get; set; } = null!;
        public string PropertyValue { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
