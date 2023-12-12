using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.Services;
using static Standing_Order_Vat_App.MvcHelper.Enumration;

namespace Standing_Order_Vat_App.Controllers
{
    public class GBRegisterController : Controller
    {
        private readonly IAccountRepo accountRepo;
        private readonly IUserRole userRoleService;

        public GBRegisterController(IAccountRepo accountRepo,IUserRole userRoleService) {
            this.accountRepo = accountRepo;
            this.userRoleService = userRoleService;
        }
        public IActionResult Index()
        {
            userRoleService.GetUserRole(User.Identity.Name);

            if (!accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Foreign_Check.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            return View();
        }
    }
}
