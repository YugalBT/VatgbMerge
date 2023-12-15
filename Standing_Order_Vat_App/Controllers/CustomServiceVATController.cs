using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.Models;
using VATCustomServices;
using static Standing_Order_Vat_App.MvcHelper.Enumration;

namespace Standing_Order_Vat_App.Controllers
{
    public class CustomServiceVATController : Controller
    {
        private readonly INotyfService notyf;
        private readonly IAccountRepo accountRepo;
        private readonly IUserRole userRoleService;
        const string Sessionuid = "uid";
        const string Sessionuname = "uname";
        const string Sessionurole = "urole";
        const string Sessionusercount = "ucount";
        Enumes enm = new Enumes();

        public CustomServiceVATController(INotyfService notyf, IUserRole userRoleService, IAccountRepo accountRepo)
        {
            this.notyf = notyf;
            this.userRoleService = userRoleService;
            this.accountRepo = accountRepo;
        }
        Prop prop = new Prop();
        public IActionResult Index()
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (accountRepo.Geturole() != null && accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            return View();
        }

        public IActionResult InsertRecord()
        {
            accountRepo.SetUserinfoInSession();
            userRoleService.GetUserRole(User.Identity.Name);

            if (accountRepo.Geturole() != null && accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertRecord(CustomService customService)
        {
            userRoleService.GetUserRole(User.Identity.Name);

            if (accountRepo.Geturole() != null && accountRepo.Geturole() != "Admin" || !accountRepo.GetAppAccessRoles().Contains(ApplicationAccess.Vat.GetEnumDisplayName()))
            {
                return RedirectToAction("AccessDenied", "Home");
            }
            string connectioString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ServiceDbConnection"];
            string ServiceFilePathdda = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ServiceFilePath"]+"DDA\\";
            string ServiceFilePathlon = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ServiceFilePath"] + "LON\\";
            string ServiceFilePathsav = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ServiceFilePath"] + "SAV\\";
            string ServiceFilePathmisc = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ServiceFilePath"] + "MISC\\";
            string printLog = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["IsPrintLog"];
            string ErrorLogPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ErrorLogPath"];

            VATServices vat = new VATServices();
            IGeneralResult<string> result = new GeneralResult<string>();
            result =await vat.ProcessNewFiles(customService.month, connectioString,ServiceFilePathdda,Convert.ToInt32(printLog), ErrorLogPath,(int)Enumes.dda);
            result =await vat.ProcessNewFiles(customService.month, connectioString,ServiceFilePathlon,Convert.ToInt32(printLog), ErrorLogPath,(int)Enumes.lon);
            result =await vat.ProcessNewFiles(customService.month, connectioString,ServiceFilePathsav,Convert.ToInt32(printLog), ErrorLogPath, (int)Enumes.sav);
            result =await vat.ProcessNewFiles(customService.month, connectioString,ServiceFilePathmisc,Convert.ToInt32(printLog), ErrorLogPath, (int)Enumes.misc);

            if (result.Successful == true)
            {
                notyf.Success("Record Insert Successfully");
                customService.month = 1;
            }
            else
            {
                notyf.Error(result.Message);
            }

            return View(customService);
        }

    }
}
