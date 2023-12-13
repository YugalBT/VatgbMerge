//using Standing_Order_Vat_App.Common.Interfaces;
//using Standing_Order_Vat_App.Common.Services;
//using Standing_Order_Vat_App.Common.ViewModels;
//using Standing_Order_Vat_App.DAL.Directory_DB;
//using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Standing_Order_Vat_App.Common.Helper
//{
//    public class SetUserPermissions
//    {
//        private readonly IAccountRepo accountRepo;
//        private readonly IUserRole userRoleService;
//        GetCurrentUserInfoVm userInfo;
//        string result;

//        public SetUserPermissions(IAccountRepo accountRepo, IUserRole userRoleService)
//        {
//            this.accountRepo = accountRepo;
//            this.userRoleService = userRoleService;
//        }

//        public void SetPermissionsInSession(string userName)
//        {
//            accountRepo.GetUserinfo(ref result, ref userInfo);
//            userRoleService.GetUserRole(userName);
//        }

//        public void RemovePrmissionInCurrentSession()
//        {
//            accountRepo.RemoveSessionData();
//        }
//    }
//}
