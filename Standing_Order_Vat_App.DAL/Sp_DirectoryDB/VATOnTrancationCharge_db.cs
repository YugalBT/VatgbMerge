using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.DAL.Sp_DirectoryDB
{
    public class VATOnTrancationCharge_db
    {
        [Key]
        public string? TranCode { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Total { get; set; }
        public decimal? National_Fees { get; set; }
    }
}
