using System.ComponentModel.DataAnnotations;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class onlineBankingVm
    {
        [DisplayFormat(DataFormatString = "{yyyy/MM/dd}")]
        [DataType(DataType.Date)]
        public DateTime Date  { get; set; }
        public bool IsChecked { get; set; }
    }
}
