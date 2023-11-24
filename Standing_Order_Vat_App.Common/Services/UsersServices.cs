using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Data;
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
                      where (Ausrs.ApplicationId == 53 && usr.IsDelete == false)
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

        public IGeneralResult<AddUserVm> CheckDuplicateRecord(AddUserVm dt)
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
                      where (Ausrs.ApplicationId == 53 && usr.UserName == @"SKNANB\" + dt.UserName && usr.IsDelete == false)
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
                      where (Ausrs.ApplicationId == 53 && usr.UserName == @"SKNANB\" + dt.UserName && usr.UserId != dt.userId && usr.IsDelete == false)
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


        public IGeneralResult<AddUserVm> AddUserData(AddUserVm vm)
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
                IsDelete = false,
            };

            dirdbcontext.Users.Add(user);
            int add = dirdbcontext.SaveChanges();

            if (add == 1)
            {
                ApplicationUserRole applicationUserRole = new ApplicationUserRole()
                {
                    ApplicationId = 53,
                    RoleId = vm.RoleId,
                    UserId = user.UserId
                };
                dirdbcontext.ApplicationUserRoles.Add(applicationUserRole);
                int addrole = dirdbcontext.SaveChanges();
                if (addrole > 0)
                {
                    res.Successful = true;
                    if (vm.UserPermissionId != null)
                    {
                        foreach (var item in vm.UserPermissionId)
                        {
                            ApplicationUserRolesNew appVm = new ApplicationUserRolesNew
                            {
                                RoleId = item,
                                UserId = user.UserId
                            };
                            dirdbcontext.ApplicationUserRolesNews.Add(appVm);
                            dirdbcontext.SaveChanges();
                        }
                    }
                }
                else
                {
                    res.Successful = false;
                }
            }
            return res;
        }

        public IGeneralResult<AddUserVm> UpdateUserData(AddUserVm vm)
        {

            IGeneralResult<AddUserVm> res = new GeneralResult<AddUserVm>();
            User user = new User();
            user = dirdbcontext.Users.Where(x => x.UserId == vm.userId).FirstOrDefault();
            if (user == null)
            {
                res.Successful = false;
            }
            else
            {
                user.UserName = @"SKNANB\" + vm.UserName.Trim();
                user.DisplayName = vm.DisplayName.Trim();

                dirdbcontext.Users.Update(user);
                ApplicationUserRole obj = new ApplicationUserRole();
                obj = dirdbcontext.ApplicationUserRoles.Where(w => w.UserId == user.UserId && w.ApplicationId == 53).Select(s => new ApplicationUserRole
                {
                    RoleId = s.RoleId,
                    UserId = s.UserId,
                    UserApplicationId = s.UserApplicationId
                }).FirstOrDefault();

                obj.UserId = vm.userId;
                obj.RoleId = vm.RoleId;
                dirdbcontext.ApplicationUserRoles.Update(obj);
                int update = dirdbcontext.SaveChanges();
                if (update > 0)
                {
                    var userapplicationRoles = dirdbcontext.ApplicationUserRolesNews.Where(x => x.UserId == user.UserId);
                    dirdbcontext.ApplicationUserRolesNews.RemoveRange(userapplicationRoles);
                    dirdbcontext.SaveChanges();
                    if (vm.UserPermissionId != null)
                    {
                        foreach (var item in vm.UserPermissionId)
                        {
                            ApplicationUserRolesNew appVm = new ApplicationUserRolesNew
                            {
                                RoleId = item,
                                UserId = user.UserId
                            };
                            dirdbcontext.ApplicationUserRolesNews.Add(appVm);
                            dirdbcontext.SaveChanges();
                        }
                    }
                    res.Successful = true;
                }
                else
                {
                    res.Successful = false;
                }
            }
            return res;
        }

        public IGeneralResult<int> DeleteUserData(int userId)
        {
            IGeneralResult<int> res = new GeneralResult<int>();
            User user = new User();
            user = dirdbcontext.Users.Where(w => w.UserId == userId).FirstOrDefault();
            if (user != null)
            {
                user.IsDelete = true;
                dirdbcontext.Users.Update(user);
                int delete = dirdbcontext.SaveChanges();
                if (delete > 0)
                {
                    res.Successful = true;
                }
                else
                {
                    res.Successful = false;
                }
            }
            return res;
        }

        //public class AppliactionUserAccessRole
        //{
        //    public List<int> RoleId { get; set; }
        //}

        //public int AddUser(AddUserVm vm)
        //{
        //    SqlConnection conn = new SqlConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("RoleId");
        //    dt.Rows.Add(vm.UserPermissionId.ToString());
        //    conn.ConnectionString = "Server=SYS82\\SYS82G,1433;Database=Directory;user id=sa;password=bt123;Trusted_Connection=true;Integrated Security=false;";
        //    cmd.Connection = conn;
        //    cmd.CommandText = "usp_AddUser";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@UserId", vm.userId);
        //    cmd.Parameters.AddWithValue("@UserName", vm.UserName);
        //    cmd.Parameters.AddWithValue("@DisplayName", vm.DisplayName);
        //    cmd.Parameters.AddWithValue("@RoleId", vm.RoleId);
        //    cmd.Parameters.AddWithValue("@ApplicationId", 53);
        //    cmd.Parameters.AddWithValue("@AccessCode", "");
        //    cmd.Parameters.AddWithValue("@Path", "");
        //    cmd.Parameters.AddWithValue("@EmployeeID", 820);
        //    cmd.Parameters.AddWithValue("@ApplicationRoleIds", dt);
        //    cmd.Parameters.Add("@res", SqlDbType.Int,100);
        //    cmd.Parameters["@res"].Direction = ParameterDirection.Output;
        //    conn.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    var res = cmd.Parameters["@res"].Value;
        //    conn.Close();
        //    return (int)res;
        //}

    }
}
