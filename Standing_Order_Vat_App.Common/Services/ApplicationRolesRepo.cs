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
    public class ApplicationRolesRepo : BaseRepository<DirectoryContext, ApplicationRolesNew>, IApplicationRolesRepo
    {
        private readonly DirectoryContext dirdbcontext;
        private readonly IHttpContextAccessor httpContext;

        public ApplicationRolesRepo(DirectoryContext dirdbcontext, IHttpContextAccessor httpContext)
        {
            this.dirdbcontext = dirdbcontext;
            this.httpContext = httpContext;
        }

        public List<ApplicationRolesNew> GetApplicationRoles()
        {
            List<ApplicationRolesNew> UserRoles = new List<ApplicationRolesNew>();
            UserRoles = dirdbcontext.ApplicationRolesNews.Where(x=>x.IsActive == true).ToList();
            return UserRoles;
        }
    }
}
