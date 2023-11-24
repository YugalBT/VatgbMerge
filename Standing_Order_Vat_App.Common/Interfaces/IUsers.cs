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
    public interface IUsers 
    {
        List<Users_VM> GetAllUser();
        User CreateUser(User model);
        AddUserVm GetUserById(int id);
        User GetUserByIds(int id);
        void UPdateUser(User model);
        IGeneralResult<AddUserVm> AddUserData(AddUserVm vm);
        IGeneralResult<AddUserVm> UpdateUserData(AddUserVm vm);
        IGeneralResult<int> DeleteUserData(int userId);
        IGeneralResult<AddUserVm> CheckDuplicateRecord(AddUserVm dt);
    }
}
