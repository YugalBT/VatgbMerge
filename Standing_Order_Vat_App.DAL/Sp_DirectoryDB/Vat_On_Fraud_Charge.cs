using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.DAL.Sp_DirectoryDB
{
    public class Vat_On_Fraoud_Charge
    {
        [Key]
        public string? TranCode { get; set; }
        public decimal? VAT { get; set; }
        public decimal? National_Fees { get; set; }
        public decimal? SubTotal { get; set; }
    }
}
