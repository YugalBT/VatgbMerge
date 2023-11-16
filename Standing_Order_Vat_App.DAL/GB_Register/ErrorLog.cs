using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class ErrorLog
    {
        public string? ErrDesc { get; set; }
        public DateTime? Datereported { get; set; }
        public int ErrId { get; set; }
    }
}
