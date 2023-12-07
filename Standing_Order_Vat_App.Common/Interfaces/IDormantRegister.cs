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
        Task<IGeneralResult<string>> AddDormantRegister(VmDormantRegister dormantRegister);
        IGeneralResult<DataTable> GetDormRegRecsByAcctNum(ref DataTable dtable, string acct, string coreBranch, int entry, string jobTitle);
        IGeneralResult<DataTable> GetDormRegRecsByDate(ref DataTable dtable, DateTime? dtFrom, DateTime? dtTo, string coreBranch, int entry, string jobTitle);
        IGeneralResult<DataTable> GetDormRegRecsByStatus(ref DataTable dtable, int status, string coreBranch, string jobTitle);

        
        
    }
}
