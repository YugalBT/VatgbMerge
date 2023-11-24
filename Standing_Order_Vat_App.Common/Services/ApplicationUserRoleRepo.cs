using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class ApplicationUserRoleRepo : IApplicationUserRole
    {
        private readonly DirectoryContext dirdbcontext;
        public ApplicationUserRoleRepo(DirectoryContext dirdbcontext)
        {
            this.dirdbcontext = dirdbcontext;
        }
        public ApplicationUserRole CreateApplicationuserRole(ApplicationUserRole applicationUserRole)
        {
            dirdbcontext.ApplicationUserRoles.Add(applicationUserRole);
            dirdbcontext.SaveChanges();
            return applicationUserRole;
        }



        public ApplicationUserRole GetApplicationUserRoleByUserId(int userId)
        {
            //var  applicationUserRole = dirdbcontext.ApplicationUserRoles.Where(x => x.UserId == userId && x.UserApplicationId==53).FirstOrDefault();
            //dirdbcontext.SaveChanges();
            ApplicationUserRole obj = new ApplicationUserRole();
            obj = dirdbcontext.ApplicationUserRoles.Where(w => w.UserId == userId && w.ApplicationId == 53).Select(s => new ApplicationUserRole
            {
                RoleId = s.RoleId,
                UserId = s.UserId,
                UserApplicationId = s.UserApplicationId
            }).FirstOrDefault();

            return obj;
        }
        public void UpdateApplicationUserRole(ApplicationUserRole model)
        {
            dirdbcontext.ApplicationUserRoles.Update(model);
            dirdbcontext.SaveChanges();
        }

        //public IGeneralResult<AddUserVm> updateuser(AddUserVm vm)
        //{

        //    IGeneralResult<AddUserVm> res = new GeneralResult<AddUserVm>();
        //    User user = new User();
        //    user = dirdbcontext.Users.Where(x => x.UserId == vm.userId).FirstOrDefault();
        //    if (user == null)
        //    {
        //        res.Successful = false;
        //    }
        //    else
        //    {
        //        user.UserName = @"SKNANB\" + vm.UserName.Trim();
        //        user.DisplayName = vm.DisplayName.Trim();

        //        dirdbcontext.Users.Update(user);
        //        ApplicationUserRole obj = new ApplicationUserRole();
        //        obj = dirdbcontext.ApplicationUserRoles.Where(w => w.UserId == user.UserId && w.ApplicationId == 53).Select(s => new ApplicationUserRole
        //        {
        //            RoleId = s.RoleId,
        //            UserId = s.UserId,
        //            UserApplicationId = s.UserApplicationId
        //        }).FirstOrDefault();

        //        obj.UserId = vm.userId;
        //        obj.RoleId = vm.RoleId;
        //        dirdbcontext.ApplicationUserRoles.Update(obj);
        //        int update = dirdbcontext.SaveChanges();
        //        if (update > 0)
        //        {
        //            res.Successful = true;
        //        }
        //        else
        //        {
        //            res.Successful = false;
        //        }
        //    }
        //    return res;
        //}

        //public IGeneralResult<int> deleteuser(int userId)
        //{
        //    IGeneralResult<int> res = new GeneralResult<int>();
        //    User user=new User ();
        //     user = dirdbcontext.Users.Where(w => w.UserId == userId).FirstOrDefault();
        //    if(user != null)
        //    {
        //        user.IsDelete = true;
        //        dirdbcontext.Users.Update(user);
        //        int delete = dirdbcontext.SaveChanges();
        //        if (delete > 0)
        //        {
        //            res.Successful = true;
        //        }
        //        else
        //        {
        //            res.Successful = false;
        //        }
        //    }
        //    return res;
        //}
    }
}
