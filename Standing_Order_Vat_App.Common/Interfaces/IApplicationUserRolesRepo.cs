using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IApplicationUserRolesRepo : IGenericRepository<ApplicationUserRolesNew>
    {
        public List<ApplicationUserRolesNew> GetUserApplicationRoles(int UserId);
    }
}
