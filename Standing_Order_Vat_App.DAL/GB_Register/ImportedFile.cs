using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class ImportedFile
    {
        public string? FileName { get; set; }
        public string? FileId { get; set; }
        public DateTime? DateImported { get; set; }
        public int RowId { get; set; }
    }
}
