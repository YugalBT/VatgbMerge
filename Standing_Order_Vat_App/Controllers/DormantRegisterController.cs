using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
namespace Standing_Order_Vat_App.Controllers
{
    public class DormantRegisterController : Controller
    {
        private readonly IDormantRegister _dormantRegister;
        private readonly IFrgnChks _frgnchks;
        private readonly IAccountRepo _accountrepo;

        public DormantRegisterController(Common.Interfaces.IDormantRegister dormantRegister, IFrgnChks frgnchks,IAccountRepo accountRepo)
        {
            _dormantRegister = dormantRegister;
            _frgnchks = frgnchks;
            _accountrepo = accountRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddDormantRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDormantRegister(VmDormantRegister dormantRegister)
        {
            if (ModelState.IsValid)
            {
                var result = _dormantRegister.AddDormantRegister(dormantRegister);
                ViewBag.record = result;
            }
            return View("AddDormantRegister");
        }
        public void GetAccountInfo(string AccNo)
        {
            Accountinfo vm = new Accountinfo();
            var res = _dormantRegister.GetAcctCoreInfo(ref vm, AccNo);
        }

        [HttpPost]
        public async Task<IActionResult>UpdateDormant(DormantUpdateVmm res)
        {
            res.entryStatusVM = await _frgnchks.GetEntryStatus();
            res.status = 1;
            if (res.status == 1)
            {
                res.DormantListIncompletes = ListIncomplete(res);
            }
            else
            {
                res.DormantCheckListRecVms = ListComplete(res);

            }
            return View(res);
            
        }
        private List<DormantListRecVm> ListComplete(DormantUpdateVmm res)
        {
           
            List<DormantListRecVm> result1 = new List<DormantListRecVm>();
            res.coreBranch = _accountrepo.GetCoreId();
            res.jobTitle = _accountrepo.JobTitle();
            res.Department = _accountrepo.GetDepartment();
            
            switch (res.Options)
            {
                case 1:

                    var a = _dormantRegister.GetDormRegRecsByAcctNum(res.AccountNumber.ToString(), res.coreBranch, res.status, res.jobTitle,res.Department);
                    if (a.Value != null)
                    {
                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(a.Value);

                    }
                    break;
                case 2:

                    var b = _dormantRegister.GetDormRegRecsByDate(res.dtFrom, res.dtTo, res.coreBranch, res.status, res.jobTitle);
                    if (b.Value != null)
                    {

                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(b.Value);
                    }

                    break;



                case 3:

                    var c = _dormantRegister.GetDormRegRecsByStatus(res.status, res.coreBranch, res.jobTitle);
                    if (c.Value != null)
                    {
                        result1 = DataTableToModelConvert.ConvertToList<DormantListRecVm>(c.Value);

                    }
                    break;
            }
            res.DormantCheckListRecVms = result1;
            return result1;
           

        }
        private List<DormantListIncomplete> ListIncomplete(DormantUpdateVmm res)
        {
            List<DormantListIncomplete> result1 = new List<DormantListIncomplete>();
            res.coreBranch = _accountrepo.GetCoreId();
            res.jobTitle = _accountrepo.JobTitle();
            res.Department = _accountrepo.GetDepartment();

            switch (res.Options)
            {
                case 1:
                    var a = _dormantRegister.GetDormRegRecsByAcctNum(res.acct, res.coreBranch, res.status, res.jobTitle, res.Department);
                    if (a.Value != null)
                    {
                        if (res.status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(a.Value);
                        }
                    }
                    break;

                    
                case 2:

                    var b = _dormantRegister.GetDormRegRecsByDate(res.dtFrom, res.dtTo, res.coreBranch, res.status, res.jobTitle);
                    if (b.Value != null)
                    {

                        result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(b.Value);
                    }

                    break;
                case 3:
                    var c = _dormantRegister.GetDormRegRecsByStatus(res.status, res.coreBranch, res.jobTitle);
                    if (c.Value != null)
                    {
                        if (res.status == 1)
                        {
                            result1 = DataTableToModelConvert.ConvertToList<DormantListIncomplete>(c.Value);
                        }

                    }
                    break;
            }
            res.DormantListIncompletes = result1;
            return result1;
        }
        [HttpPost]
        public async Task<IGeneralResult<string>> DeleteDormant(int id)
        {
            IGeneralResult<string> res = new GeneralResult<string>();
            if (id > 0)
            {
                var result = await _dormantRegister.DeleteDormant(id);
                return result;
            }
            else
            {
                res.Message = "Batch Not Found!";
            }
            return res;
        }

    }
}
