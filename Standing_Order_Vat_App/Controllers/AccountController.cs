using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.Models;
using VATCustomServices;
using X.PagedList;

namespace Standing_Order_Vat_App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsers userRepo;
        private readonly IUserRole userRoleRepo;
        private readonly IApplication applicationRepo;
        private readonly INotyfService notyf;
        private readonly IApplicationUserRole applicationUserRoleRepo;
        private readonly IUserRole userRoleService;
        private readonly IUserPermission _userPermission;
        List<UserRole_VM> userRolelist = new List<UserRole_VM>();
        const string Sessionuid = "uid";
        const string Sessionuname = "uname";
        const string Sessionurole = "urole";
        const string Sessionusercount = "ucount";
        public AccountController(IUserRole userRoleService,IUsers userRepo, IUserRole userRole, IApplication applicationRepo, IApplicationUserRole applicationUserRole, INotyfService notyf,IUserPermission userPermission)
        {
            this.applicationUserRoleRepo = applicationUserRole;
            this.userRepo = userRepo;
            this.userRoleRepo = userRole;
            this.applicationRepo = applicationRepo;
            this.notyf = notyf;
            this.userRoleService = userRoleService;
            userPermission = _userPermission;
        }
        public IActionResult ManageUser(int? page, string search)
        {

            VATServices tes = new VATServices();

            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
               return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                ViewBag.search = search;
                if (String.IsNullOrEmpty(search))
                {
                    IPagedList<Users_VM> users = userRepo.GetAllUser().ToPagedList(page ?? 1, 10);
                    return View(users);
                }
                else
                {
                    IPagedList<Users_VM> users = userRepo.GetAllUser().Where(x => x.UserName.ToLower().Contains(search.ToLower())).ToPagedList(page ?? 1, 10);
                    return View(users);
                }
            }
        }




        [HttpGet]
        public IActionResult AddUser()
        {
            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
                return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                List<Role_VM> vm = new List<Role_VM>();
                vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
                {
                    RoleID = s.RoleId,
                    RoleName = s.RoleName
                }).ToList();
                var students = new List<Student>() {
                new Student(){ Id = 1, Name="Vat"},
                new Student(){ Id = 2, Name="Check"},
               
            };

                AddUserVm model = new AddUserVm();
                model.ProcessDropDown = students;
              
                model.UserRoles = vm;
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult AddUser(AddUserVm model)
        {
            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
                return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                List<Role_VM> vm = new List<Role_VM>();
                vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
                {
                    RoleID = s.RoleId,
                    RoleName = s.RoleName
                }).ToList();
                model.UserRoles = vm;
                if (ModelState.IsValid)
                {
                    IGeneralResult<AddUserVm> result = new GeneralResult<AddUserVm>();
                    IGeneralResult<AddUserVm> adduser = new GeneralResult<AddUserVm>();


                    result = userRepo.checkduplicaterecord(model);
                    if (result.Successful == false)
                    {
                        adduser = userRepo.adduser(model);

                       
                        if (adduser.Successful == true)
                        {
                            notyf.Success("User created successfully");
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
            }
        }
       
        [HttpGet]
        public IActionResult UpdateUser(int userid)
        {
            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
                return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                List<Role_VM> vm = new List<Role_VM>();
                vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
                {
                    RoleID = s.RoleId,
                    RoleName = s.RoleName
                }).ToList();

                AddUserVm model = new AddUserVm();
                var user = userRepo.GetUserById(userid);
                model.UserName = user.UserName.Remove(0, 7);
                model.DisplayName = user.DisplayName;
                model.RoleId = user.RoleId;
                model.UserRoles = vm;
                return View(model);
            }
        }
        [HttpPost]
        public IActionResult UpdateUser(AddUserVm model)
        {
            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
                return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                List<Role_VM> vm = new List<Role_VM>();
                vm = userRoleRepo.GetAllUserRole().Select(s => new Role_VM
                {
                    RoleID = s.RoleId,
                    RoleName = s.RoleName
                }).ToList();
                if (ModelState.IsValid)
                {
                    IGeneralResult<AddUserVm> result = new GeneralResult<AddUserVm>();
                    IGeneralResult<AddUserVm> updateuser = new GeneralResult<AddUserVm>();

                    result = userRepo.checkduplicaterecord(model);
                    if (result.Successful == false)
                    {
                        updateuser = applicationUserRoleRepo.updateuser(model);

                        if (updateuser.Successful == true)
                        {
                            notyf.Success("User updated successfully");
                            return RedirectToAction("ManageUser");
                        }
                        else
                        {
                            notyf.Success("User not updated due to some error");
                            model.UserRoles = vm;
                            return View(model);
                        }
                    }
                    else
                    {
                        notyf.Error("This user is already exist");
                        model.UserRoles = vm;
                        return View(model);
                    }
                }
                else
                {
                    notyf.Error("Something went wrong");
                    model.UserRoles = vm;
                    return View(model);
                }
            }
        }

        public IActionResult DeleteUser(int userid)
        {
            if (HttpContext.Session.GetString("urole").ToString().ToLower() != "admin")
            {
                return RedirectToAction("TotalSummaryReport", "StandingOrderVat");
            }
            else
            {
                IGeneralResult<int> result = new GeneralResult<int>();

                result = applicationUserRoleRepo.deleteuser(userid);
                if (result.Successful == true)
                {
                    notyf.Success("User deleted successfully");
                    return RedirectToAction("ManageUser");
                }
                else
                {
                    notyf.Error("Internal server error");
                    return View();
                }
            }
        }
        //[HttpPost]
        //public IActionResult Multiselect(UserPermissionVm userPermission)
        //{
        //    var id = userPermission.Ids;
        //    var model = _userPermission.Getuserpermission().Result.Where(p => id.Contains(p.Id));
        //    return Ok();
        //}
    }
}
