using Microsoft.AspNetCore.Http;
using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IAccountRepo
    {
        public int GetUserinfo(ref string result, ref GetCurrentUserInfoVm userinfo);
        public string GetCurrentUserPersonalInfo(ref GetCurrentUserInfoVm userInfo);
        public string GetSocSecNum(int empId);
        public string GetUserId();

        public string GetLastName();

        public string GetFirstName();

        public string GetDepartment();

        public string JobTitle();

        public string GetEmpCode();

        public string GetEmpId();

        public string GetBranchID();

        public string GetBranchName();

        public string GetCoreId();

        public string GetSSnum();
        public string GetAppAccessRoles();

        public string Geturole();
        public string Getucount();

    }
}
