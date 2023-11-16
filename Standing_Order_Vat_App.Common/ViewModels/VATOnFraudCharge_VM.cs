using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class VATOnFraudCharge_VM
    {
        public static explicit operator VATOnFraudCharge_VM(Vat_On_Fraoud_Charge item)
        {
            return new VATOnFraudCharge_VM
            {
                National_Fees = item.National_Fees,
                SubTotal = item.SubTotal,
                TranCode = item.TranCode,
                VAT = item.VAT,
            };
        }
        [Key]
        public string? TranCode { get; set; }
        public decimal? VAT { get; set; }
        public decimal? National_Fees { get; set; }
        public decimal? SubTotal { get; set; }
        public Vat_On_Fraoud_Charge ToSp_getFraudChargeDbModel()
        {
            return new Vat_On_Fraoud_Charge
            {
                National_Fees = National_Fees,
                VAT = VAT,
                SubTotal = SubTotal,
                TranCode = TranCode,
            };
        }
    }
}
