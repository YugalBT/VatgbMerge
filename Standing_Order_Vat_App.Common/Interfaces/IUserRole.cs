using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IUserRole
    {
        List<Role> GetAllUserRole();
        //List<Sp_userRole> GetUserRole(string user, int pn = 1, int recordPerPage = 10);
        List<Sp_userRole> GetUserRole(string user);
    }
}
