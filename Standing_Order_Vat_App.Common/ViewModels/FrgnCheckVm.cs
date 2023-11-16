using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class FrgnCheckVm
    {
      public DateTime dtRecvd { get; set; }
      public     DateTime dtProcessed{ get; set; }
      public int batchStat{ get; set; }
      public string branch{ get; set; }
      public int empId{ get; set; }
      public    string bankId { get; set; }
    }
}
