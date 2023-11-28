using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class UserRoleService : IUserRole
    {
        private readonly DirectoryContext dirdbcontext;

        public UserRoleService(DirectoryContext dirdbcontext)
        {
            this.dirdbcontext = dirdbcontext;
        }

        public List<Role> GetAllUserRole()
        {
            List<Role> UserRoles = new List<Role>();
            UserRoles = dirdbcontext.Roles.ToList();
            return UserRoles;
        }

        public List<Sp_userRole> GetUserRole(string user, [Optional] int pageNum, [Optional] int recordPerPage)
        {
            List<Sp_userRole> sp_UserRoles = new List<Sp_userRole>();

            // For Live we need to comment line no 36 and uncomment line no 32

            // var userName = new SqlParameter("@userName", user);
            // var userName = new SqlParameter("@userName", "SKNANB" + @"\" + "JUNIORJ");

            // For testing
            var userName = new SqlParameter("@userName", "test");
            // var userName = new SqlParameter("@userName", "SKNANB\\TestK");

            var appName = new SqlParameter("@appName", "NB_VAT_FEES");
            //var appName = new SqlParameter("@appName", "National Online Support");
            try
            {
                sp_UserRoles = dirdbcontext.Sp_UserRoles.FromSqlRaw("exec getUserAccess_NewKK @userName,@appName", userName, appName).AsEnumerable().ToList();
            }
            catch (Exception ex) { }
            return sp_UserRoles;
        }
    }
}