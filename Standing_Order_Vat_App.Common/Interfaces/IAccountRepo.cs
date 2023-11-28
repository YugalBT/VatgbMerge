using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public  interface IAccountRepo
    {
        public int GetEmpId(ref string result, ref int userId);
    }
}
