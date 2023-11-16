using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class UserPermissionVm
    {
        public int? UserId { get; set; }
        public int Id { get; set; }
        public string RoleId { get; set; }
        public List<SelectListItem> Permissions { get; set; }
        public int[] Ids { get; set; }
    }
}
