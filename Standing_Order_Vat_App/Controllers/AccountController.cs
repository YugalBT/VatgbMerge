using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.Services;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.Models;
using VATCustomServices;
using X.PagedList;
using static Standing_Order_Vat_App.MvcHelper.Enumration;

namespace Standing_Order_Vat_App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsers userRepo;
        private readonly IApplicationRolesRepo applicationRoleRepo;
        private readonly IApplicationUserRolesRepo applicationUserAccessRoles;
        private readonly IUserRole userRoleRepo;
        private readonly IApplication applicationRepo;
        private readonly INotyfService notyf;
        private readonly IApplicationUserRole applicationUserRoleRepo;
        private readonly IUserRole userRoleService;
        private readonly IAccountRepo accountRepo;
        private readonly IUserPermission _userPermission;
        List<UserRole_VM> userRolelist = new List<UserRole_VM>();
        const string Sessionuid = "uid";
        const string Sessionuname = "uname";
        const string Sessionurole = "urole";
        const string Sessionusercount = "ucount";

        public AccountController(IUserRole userRoleService, IAccountRepo accountRepo, IUsers userRepo, IApplicationRolesRepo applicationAccessRoleRepo, IApplicationUserRolesRepo applicationUserAccessRoles,
            IUserRole userRole, IApplication applicationRepo, IApplicationUserRole applicationUserRole, INotyfService notyf, IUserPermission userPermission)
        {
            this.applicationUserRoleRepo = applicationUserRole;
            this.userRepo = userRepo;
            this.applicationRoleRepo = applicationAccessRoleRepo;
            this.applicationUserAccessRoles = applicationUserAccessRoles;
            this.userRoleRepo = userRole;
            this.applicationRepo = applicationRepo;
            this.notyf = notyf;
            this.userRoleService = userRoleService;
            this.accountRepo = accountRepo;
            userPermission = _userPermission;
        }

        public IActionResult ManageUser(int? page, string search)
        {

            VATServices tes = new VATServices();
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(Environment.UserName);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()) || string.IsNullOrEmpty(accountRepo.Geturole()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }

            ViewBag.search = search;
            if (String.IsNullOrEmpty(search))
            {
                IPagedList<Users_VM> users = userRepo.GetAllUser().OrderByDescending(x => x.UserId).ToPagedList(page ?? 1, 10);
                return View(users);
            }
            else
            {
                IPagedList<Users_VM> users = userRepo.GetAllUser().Where(x => x.UserName.ToLower().Contains(search.ToLower())).ToPagedList(page ?? 1, 10);
                return View(users);
            }

        }


        [HttpGet]
        public IActionResult AddUser(int? userid)
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(Environment.UserName);

            if (string.IsNullOrEmpty(accountRepo.Geturole()) || accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }

            List<Role_VM> vm = new List<Role_VM>();
            vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
            {
                RoleID = s.RoleId,
                RoleName = s.RoleName
            }).ToList();
            var applicationAccessRoles = applicationRoleRepo.GetAll().Result.Where(x => x.IsActive == true).Select(y => new ApplicationAccessRoles
            {
                Id = y.RoleId,
                Name = y.RoleName
            }).ToList();

            AddUserVm model = new AddUserVm();
            model.ProcessDropDown = applicationAccessRoles;
            if (userid > 0)
            {
                var user = userRepo.GetUserById(userid ?? 0);
                var userApplicationAccessRoles = applicationUserAccessRoles.GetAll().Result.Where(x => x.UserId == user.userId).Select(x => x.RoleId);
                model.UserName = user.UserName.Remove(0, 7);
                model.DisplayName = user.DisplayName;
                model.RoleId = user.RoleId;
                model.UserPermissionIds = userApplicationAccessRoles;
            }
            model.UserRoles = vm;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddUser(AddUserVm model)
        {
            try
            {
                userRoleService.GetUserRole(Environment.UserName);

                if (string.IsNullOrEmpty(accountRepo.Geturole()) || accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
                {
                    return RedirectToAction("AccessDenied", "Home");
                }

                List<Role_VM> vm = new List<Role_VM>();
                vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
                {
                    RoleID = s.RoleId,
                    RoleName = s.RoleName
                }).ToList();
                var applicationAccessRoles = applicationRoleRepo.GetAll().Result.Where(x => x.IsActive == true).Select(y => new ApplicationAccessRoles
                {
                    Id = y.RoleId,
                    Name = y.RoleName
                }).ToList();
                model.UserRoles = vm;
                if (ModelState.IsValid)
                {

                    var result = userRepo.CheckDuplicateRecord(model);
                    if (!result.Successful)
                    {
                        var res = model.userId > 0 ? userRepo.UpdateUserData(model) : userRepo.AddUserData(model);
                        if (res.Successful)
                        {
                            if (model.userId > 0)
                            {
                                notyf.Success("User updated successfully");
                            }
                            else
                            {
                                notyf.Success("User created successfully");
                            };
                            return RedirectToAction("ManageUser");
                        }
                        else
                        {
                            notyf.Error("Something went wrong.");
                            model.UserRoles = vm;
                            return View(model);
                        }
                    }
                    else
                    {
                        notyf.Error("User is already exist");
                        model.UserRoles = vm;
                        return View(model);
                    }
                }
                else
                {
                    notyf.Error("Something went wrong.");
                    model.UserRoles = vm;
                    return View(model);
                }
                //}
            }
            catch (Exception ex)
            {
                notyf.Error(ex.Message);
                return View(model);
            }
        }


        public IActionResult DeleteUser(int userid)
        {
            userRoleService.GetUserRole(Environment.UserName);

            if (string.IsNullOrEmpty(accountRepo.Geturole()) || accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            else
            {
                IGeneralResult<int> result = new GeneralResult<int>();

                result = userRepo.DeleteUserData(userid);
                if (result.Successful == true)
                {
                    notyf.Success("User deleted successfully");
                }
                else
                {
                    notyf.Error("Internal server error");
                }
                return RedirectToAction("ManageUser");
            }
        }

    }
}
