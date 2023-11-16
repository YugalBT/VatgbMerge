using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class VATOnTransactionCharge_VM
    {
        public static explicit operator VATOnTransactionCharge_VM(VATOnTrancationCharge_db item)
        {
            return new VATOnTransactionCharge_VM
            {
                National_Fees = item.National_Fees,
                Total = item.Total,
                TranCode = item.TranCode,
                VAT = item.VAT,
            };
        }
        [Key]
        public string? TranCode { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Total { get; set; }
        public decimal? National_Fees { get; set; }

        public VATOnTrancationCharge_db ToSp_VATOnTrancationChargeModel()
        {
            return new VATOnTrancationCharge_db
            {
                National_Fees = National_Fees,
                VAT = VAT,
                Total = Total,
                TranCode = TranCode,
            };
        }
    }
}
