using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class CheckSettlementBatchVm
    {
        public long SettlementId { get; set; }
        public string CheckNumber{ get; set; }
        public decimal? SettlementAmount { get; set; }
        public long BatchId { get; set; }
        public DateTime? DateSettled { get; set; }
        public string SettledByWire { get; set; }
        public string BankName { get; set; }
        
        //public List<BankListVm> BanksList { get; set; }

        

       
    }
}
