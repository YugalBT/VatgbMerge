using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Models;
using System.Diagnostics;

namespace Standing_Order_Vat_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRole userRoleService;
        private readonly IAccountRepo accountRepo;

        public HomeController(ILogger<HomeController> logger,IUserRole userRoleService, IAccountRepo accountRepo)
        {
            _logger = logger;
            this.userRoleService = userRoleService;
            this.accountRepo = accountRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AccessDenied()
        {
            userRoleService.GetUserRole(User.Identity.Name);

            return View("AccessDenied");
        }
    }
}