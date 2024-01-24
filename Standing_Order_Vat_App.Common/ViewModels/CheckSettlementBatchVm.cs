using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class CheckSettlementBatchVm
    {
        public long SettlementId { get; set; }
        [Display(Name ="Check Number")]
        public string CheckNumber{ get; set; }
        [Display(Name = "Settlement Amount")]
        public decimal? SettlementAmount { get; set; }
        public long BatchId { get; set; }
        [Display(Name = "Date Settled")]
        public DateTime? DateSettled { get; set; }
        [Display(Name = "Settle By Wire")]
        public string SettledByWire { get; set; }
        [Display(Name = "Bank")]
        public string BankName { get; set; }
        
        //public List<BankListVm> BanksList { get; set; }

        

       
    }
}
