using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class SettleForeignCheckVm
    {
        public List< int> bIdList { get; set; }
        public string branch { get; set; }
        public int empId { get; set; }
        public  int entryStatus { get; set; }
        public List <int> cntSettled { get; set; }

       
    }
}
