using GbRegister.Core.ViewModel;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IDormantRegister
    {
        IGeneralResult<string> AddDormantRegister(VmDormantRegister dormantRegister);
        IGeneralResult<DataTable> GetDormRegRecsByAcctNum(string acct, string coreBranch, int entry, string jobTitle,string dept);
        IGeneralResult<DataTable> GetDormRegRecsByDate( DateTime? dtFrom, DateTime? dtTo, string coreBranch, int entry, string jobTitle);
        IGeneralResult<DataTable> GetDormRegRecsByStatus(int status, string coreBranch, string jobTitle);
        IGeneralResult<Accountinfo> GetAcctCoreInfo(ref Accountinfo vm, string acct);
        Task<IGeneralResult<string>> DeleteDormant(int id);
        IGeneralResult<DataTable> GetDepartmentsList();
        IGeneralResult<string> UpdateDormRegRecs(UpdateDormantEntryVm vm);
    }
}
