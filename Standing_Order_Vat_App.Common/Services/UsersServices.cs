using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Standing_Order_Vat_App.Common.Services
{
    public class UsersServices : IUsers
    {
        private readonly DirectoryContext dirdbcontext;
        public UsersServices(DirectoryContext dirdbcontext)
        {
            this.dirdbcontext = dirdbcontext;
        }
        public List<Users_VM> GetAllUser()
        {
            List<Users_VM> result = new List<Users_VM>();

            result = (from usr in dirdbcontext.Users
                      join Ausrs in dirdbcontext.ApplicationUserRoles
                      on usr.UserId equals Ausrs.UserId
                      join Rls in dirdbcontext.Roles
                      on Ausrs.RoleId equals Rls.RoleId
                      where (Ausrs.ApplicationId == 53 && usr.IsDelete==false)
                      select new Users_VM
                      {
                          UserId = usr.UserId,
                          UserName = usr.UserName,
                          DisplayName = usr.DisplayName,
                          RoleName = Rls.RoleName
                      }).ToList();
            return result;
        }
        public User CreateUser(User model)
        {
            dirdbcontext.Users.Add(model);
            dirdbcontext.SaveChanges();
            return model;
        }
        public AddUserVm GetUserById(int id)
        {
            AddUserVm user = new AddUserVm();
            user = (from usr in dirdbcontext.Users
                    join Ausrs in dirdbcontext.ApplicationUserRoles
                    on usr.UserId equals Ausrs.UserId

                    join roles in dirdbcontext.Roles
                     on Ausrs.RoleId equals roles.RoleId
                    where (Ausrs.ApplicationId == 53 && usr.UserId == id)
                    select new AddUserVm
                    {
                        userId = usr.UserId,
                        UserName = usr.UserName,
                        DisplayName = usr.DisplayName,
                        //RoleName=roles.RoleName,
                        RoleId = roles.RoleId
                    }).FirstOrDefault();
            return user;
        }

        public User GetUserByIds(int id)
        {
            User user = dirdbcontext.Users.Where(x => x.UserId == id).FirstOrDefault();

            return user;
        }

        public void UPdateUser(User model)
        {
            dirdbcontext.Users.Update(model);
            dirdbcontext.SaveChanges();
        }

        public IGeneralResult<AddUserVm> checkduplicaterecord(AddUserVm dt)
        {
            IGeneralResult<AddUserVm> dplcate = new GeneralResult<AddUserVm>();
            User us = new User();
            if (dt.userId == 0)
            {
                us = (from usr in dirdbcontext.Users
                      join Ausrs in dirdbcontext.ApplicationUserRoles
                      on usr.UserId equals Ausrs.UserId

                      join roles in dirdbcontext.Roles
                       on Ausrs.RoleId equals roles.RoleId
                      where (Ausrs.ApplicationId == 53 && usr.UserName == @"SKNANB\" + dt.UserName && usr.IsDelete==false)
                      select new User
                      {
                          UserName = usr.UserName,
                          DisplayName = usr.DisplayName,
                      }).FirstOrDefault();


                if (us == null)
                {
                    dplcate.Successful = false;
                }
                else
                {
                    dplcate.Successful = true;
                }
            }
            else
            {
                us = (from usr in dirdbcontext.Users
                      join Ausrs in dirdbcontext.ApplicationUserRoles
                      on usr.UserId equals Ausrs.UserId

                      join roles in dirdbcontext.Roles
                       on Ausrs.RoleId equals roles.RoleId
                      where (Ausrs.ApplicationId == 53 && usr.UserName == @"SKNANB\" + dt.UserName && usr.UserId !=dt.userId && usr.IsDelete==false)
                      select new User
                      {
                          UserName = usr.UserName,
                          DisplayName = usr.DisplayName,
                      }).FirstOrDefault();

                if (us == null)
                {
                    dplcate.Successful = false;
                }
                else
                {
                    dplcate.Successful = true;
                }
            }
            return dplcate;


        }

        public IGeneralResult<AddUserVm> adduser(AddUserVm vm)
        {
            IGeneralResult<AddUserVm> res = new GeneralResult<AddUserVm>();
            User user = new User()
            {
                DisplayName = vm.DisplayName.Trim(),
                UserName = @"SKNANB\" + vm.UserName.Trim(),
                Path = "",
                Online = false,
                AccessCode = "",
                EmployeeId = 820,
                IsDelete=false,
            };

            dirdbcontext.Users.Add(user);
           int add= dirdbcontext.SaveChanges();

            if (add == 1)
            {
                ApplicationUserRole applicationUserRole = new ApplicationUserRole()
                {
                    ApplicationId = 53,
                    RoleId = vm.RoleId,
                    UserId = user.UserId
                };
                dirdbcontext.ApplicationUserRoles.Add(applicationUserRole);
             int addrole= dirdbcontext.SaveChanges();
                if (addrole > 0)
                {
                    res.Successful = true;
                }
                else
                {
                    res.Successful = true;
                }
            }
            return res;
        }
    }
}
