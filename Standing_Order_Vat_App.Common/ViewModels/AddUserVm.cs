using Microsoft.AspNetCore.Mvc.Rendering;
using Standing_Order_Vat_App.Common.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Web.Mvc;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;

namespace Standing_Order_Vat_App.Common.ViewModels
{
    public class AddUserVm
    {
        public int userId { get; set; }
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        [Required(ErrorMessage ="User name is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? DisplayName { get; set; } = "";
        public string? RoleName { get; set; } = "";

        [Required(ErrorMessage = "Role name is required")]
        public int RoleId { get; set; }

        public int[]? UserPermissionId { get; set; }
        public IEnumerable<int?>? UserPermissionIds { get; set; }
        public IEnumerable<Student> ProcessDropDown { get; set; } = Enumerable.Empty<Student>();
        public List<Role_VM> ?UserRoles  { get; set; } 


    }
}
