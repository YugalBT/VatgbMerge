using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Server.HttpSys;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.Services;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System.Collections.Generic;
using System.Security.Claims;

namespace Standing_Order_Vat_App.MvcHelper
{
    public class filter :  IAuthorizationFilter
    {
        private readonly IUserRole userRoleService;
        
        public filter(IUserRole userRoleService)
        {
            this.userRoleService = userRoleService;
        }

        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    //var httpContext = context.HttpContext;

        //    //Summery_VM record = new Summery_VM();
        //    //List<UserRole_VM> userRolelist = new List<UserRole_VM>();

        //    //var rec = userRoleService.GetUserRole(httpContext.User.Identity.Name);

        //    //userRolelist = rec.Select(x => ((UserRole_VM)x)).ToList();
        //    //var claims = new List<Claim>
        //    //{
        //    //    new Claim(ClaimTypes.Role, userRolelist.FirstOrDefault().RoleName.ToString()),
        //    //                new Claim(ClaimTypes.Name, userRolelist.FirstOrDefault().UserName.ToString()),
        //    //                new Claim("RoleName", userRolelist.FirstOrDefault().RoleName.ToString()),
        //    //                new Claim("uCount", userRolelist.Count.ToString()),
        //    //            };
        //    //var claimsIdentity = new ClaimsIdentity(
        //    //    claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //}

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
        }

        public void  OnAuthorization(AuthorizationFilterContext context)
        {

            var httpContext = context.HttpContext;
            
            var user = httpContext.User as ClaimsPrincipal;
            var data = httpContext.User.Claims.ToList();
            var identity = user.Identity as ClaimsIdentity;
            var claim = (from c in user.Claims

                         select c).ToList();

            foreach (var deleteClaim in claim)
            {
                identity.RemoveClaim(deleteClaim);
            }


            Summery_VM record = new Summery_VM();
            List<UserRole_VM> userRolelist = new List<UserRole_VM>();

            var rec = userRoleService.GetUserRole(User.Identity.Name);

            userRolelist = rec.Select(x => ((UserRole_VM)x)).ToList();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, userRolelist.FirstOrDefault().RoleName.ToString()),
                            new Claim(ClaimTypes.Name, userRolelist.FirstOrDefault().UserName.ToString()),
                            new Claim("RoleName", userRolelist.FirstOrDefault().RoleName.ToString()),
                            new Claim("uCount", userRolelist.Count.ToString()),
                        };
            var userwe = httpContext.User as ClaimsPrincipal;
            var identity21 = user.Identity as ClaimsIdentity;
            identity21.AddClaim(new Claim(ClaimTypes.Role, userRolelist.Select(s=>s.RoleName).FirstOrDefault()));

            //var claimsIdentity = new ClaimsIdentity(
            //    claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //var authProperties = new AuthenticationProperties
            //{
            //    IsPersistent = true,
            //    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(2),
            //};
            //httpContext.SignInAsync(
            //    CookieAuthenticationDefaults.AuthenticationScheme,
            //    new ClaimsPrincipal(claimsIdentity),
            //    authProperties);
        }
    }
}
