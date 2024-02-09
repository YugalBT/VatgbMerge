using Microsoft.AspNetCore.Http;
using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
   public  interface IAccountRepo
    {
        int GetUserinfo(string UserName, ref string result, ref GetCurrentUserInfoVm userinfo);
        void SetUserinfoInSession(string UserName);
        string GetCurrentUserPersonalInfo(ref GetCurrentUserInfoVm userInfo);
        string GetSocSecNum(int empId);
        string GetUserId();
        string GetLastName();
        string GetFirstName();
        string GetDepartment();
        string GetJobTitle();
        string GetEmpCode();
        string GetEmpId();
        string GetBranchID();
        string GetBranchName();
        string GetCoreId();
        string GetSSnum();
        string GetAppAccessRoles();
        string Geturole();
        string Getucount();
        string Getuname();
        string Getuid();
        void RemoveSessionData();

    }
}
