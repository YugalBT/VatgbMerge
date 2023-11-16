using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.CoreData_DB;
using VATCustomServices;

namespace Standing_Order_Vat_App.Controllers
{
    public class OnlineBankingController : Controller
    {
        private readonly INotyfService notyf;
        public OnlineBankingController(INotyfService notyf)
        {
            this.notyf = notyf;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult onlineBanking()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> onlineBanking(onlineBankingVm customService)
        {
            string connectioString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["DefaultConnectionCore"];
            string printLog = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["IsPrintLog"];
            string FileLogPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["FileLogPath"];
            string SoucPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["soucPath"];
            string DesPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["desPath"];
            string ftp = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ftp"];
            string UserName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["UserName"];
            string password = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["password"];

            CoreDataContext context = new CoreDataContext();
            IGeneralResult<string> result = new GeneralResult<string>();
            OnlineBankingSerices onlineBankingSerices = new OnlineBankingSerices(context);
            result=await onlineBankingSerices.UploadFiles(customService.Date,customService.IsChecked, connectioString, Convert.ToInt32(printLog), FileLogPath, SoucPath, DesPath,ftp, UserName, password);
            if (result.Successful == true)
            {
                notyf.Success(result.Message);
            }
            else
            {
               notyf.Error(result.Message);
            }
            return View("Index", new onlineBankingVm());
        }
    }
}
