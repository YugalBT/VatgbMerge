using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class AddCheckSettlementDetailVm
    {
        [Required]
        public int batchId { get; set; }
        [Required(ErrorMessage = "DateSettled is required")]
        public DateTime? dateSettled { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public decimal? amt { get; set; }
        
        public bool wire { get; set; }
        [Required(ErrorMessage = "Bank Id is required")]
        public int? bankId { get; set; }
        [Required(ErrorMessage = "Check Number is required")]
        public string? chkNumber { get; set; }

    }
}
