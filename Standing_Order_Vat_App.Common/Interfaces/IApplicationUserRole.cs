using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IApplicationUserRole 
    {
        ApplicationUserRole CreateApplicationuserRole(ApplicationUserRole applicationUserRole);
        ApplicationUserRole GetApplicationUserRoleByUserId(int userId);
        void UpdateApplicationUserRole(ApplicationUserRole model);
        IGeneralResult<AddUserVm> updateuser(AddUserVm vm);
        IGeneralResult<int> deleteuser(int userId);

    }
}
