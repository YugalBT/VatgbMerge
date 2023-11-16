using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IDormantRegister
    {
        VmDormantRegister AddDormantRegister(VmDormantRegister dormantRegister);
        VmDormantRegister GetDormantRegister(VmDormantRegister dormantRegister, string acctNumber);
        VmDormantRegister UpdateDormant(string acctNumber, int recordId);
        VmDormantRegister UpdateDormant(VmDormantRegister dormantRegister);
        List<VmDormantRegister> ViewDormant(string search, int? EntryStatusId, DateTime date, int pg = 1);
        VmDormantRegister DeleteDormant(int  recordId);
        public List<EntityStatusVM> GetEntityStatus();
    }
}
