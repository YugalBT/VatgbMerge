using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GbRegister.Core.ViewModel
{
    public class ForeignCheckVm
    {

        public long RecordId { get; set; }
        [Required,RegularExpression("^[0-9]+$")]
        [Display(Name ="Check Number")]
        public int? CheckNumber { get; set; } 
        [Required]
        [Display(Name = "Payer Account Number")]
        public int? PayerAcctNumber { get; set; }
        [Required()]
        [Display(Name = "Payer Name")]
        public string PayerAcctName { get; set; } 
        [Required]
        [Display(Name = "Deposite Account Number")]
        public int? DepositAcctNumber { get; set; } 
        [Display(Name = "Depositer Name")]
        public string DepositAcctName { get; set; }
        [Required]
        [Display(Name = "Check Amount")]
        public decimal? CheckAmount { get; set; }
        [Display(Name = "Total Amount")]
        public decimal? TotalAmount { get; set; }
        public int BatchId { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public DateTime? DateRecived { get; set; }
        [Required(ErrorMessage ="This field is required.")]
        public int BankId { get; set; }
        public List<BankListVm> BanksList { get; set; }
        public List<FrgnCheckListVm> checksList { get; set; }

    }
}
