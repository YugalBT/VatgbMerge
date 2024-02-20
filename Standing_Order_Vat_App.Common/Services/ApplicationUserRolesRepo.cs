using Microsoft.AspNetCore.Http;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class ApplicationUserRolesRepo :  BaseRepository<DirectoryContext, ApplicationUserRolesNew>, IApplicationUserRolesRepo
    {
        private readonly DirectoryContext dirdbcontext;
        private readonly IHttpContextAccessor httpContext;

        public ApplicationUserRolesRepo(DirectoryContext dirdbcontext, IHttpContextAccessor httpContext)
        {
            this.dirdbcontext = dirdbcontext;
            this.httpContext = httpContext;
        }

        public List<ApplicationUserRolesNew> GetUserApplicationRoles(int UserId)
        {
            var data = dirdbcontext.ApplicationUserRolesNews.Where(x => x.UserId == UserId).ToList();
            return data;
        }

    }
}
