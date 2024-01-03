using GbRegister.Core.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Helper;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using Standing_Order_Vat_App.DAL.Sp_DirectoryDB;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace Standing_Order_Vat_App.Common.Services
{
    public class UserRoleService : IUserRole
    {
        private readonly DirectoryContext dirdbcontext;
        private readonly IHttpContextAccessor httpContext;

        public UserRoleService(DirectoryContext dirdbcontext, IHttpContextAccessor httpContext)
        {
            this.dirdbcontext = dirdbcontext;
            this.httpContext = httpContext;
        }

        public List<Role> GetAllUserRole()
        {
            List<Role> UserRoles = new List<Role>();
            UserRoles = dirdbcontext.Roles.ToList();
            return UserRoles;
        }


        //public List<Sp_userRole> GetUserRole(string user, [Optional] int pageNum, [Optional] int recordPerPage)
        //{
        //    List<Sp_userRole> sp_UserRoles = new List<Sp_userRole>();
        //    string ApplicationAccessRole = "";
        //    var userName = new SqlParameter("@userName", user);
        //    //// var userName = new SqlParameter("@userName", "SKNANB" + @"\" + "JUNIORJ");
        //    ////var userName = new SqlParameter("@userName", "test");
        //    //// var userName = new SqlParameter("@userName", "SKNANB\\TestK");

        //    var appName = new SqlParameter("@appName", "NB_VAT_FEES");
        //    //var appName = new SqlParameter("@appName", "National Online Support");
        //    try
        //    {
        //        // Fot get Application access Roles
        //        var connString = dirdbcontext.Database.GetDbConnection();
        //        SqlConnection conn = new SqlConnection();
        //        SqlCommand cmd = new SqlCommand();
        //        conn.ConnectionString = dirdbcontext.Database.GetDbConnection().ConnectionString;
        //        cmd.Connection = conn;
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.CommandText = "GetAplicationGetUserRole";
        //        cmd.Parameters.AddWithValue("@username", user);
        //        conn.Open();
        //        DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
        //        var dataTable = new DataTable();
        //        adp.Fill(dataTable);
        //        if (dataTable.Rows.Count > 0)
        //        {
        //            for (int i = 0; i < dataTable.Rows.Count; i++)
        //            {
        //                string n = dataTable.Rows[i]["RoleName"].ToString();
        //                ApplicationAccessRole += n + ",";
        //            }
        //            httpContext.HttpContext.Session.SetString("AppAccessRoles", ApplicationAccessRole);
        //        }
        //        conn.Close();

        //        // For get User roles
        //        sp_UserRoles = dirdbcontext.Sp_UserRoles.FromSqlRaw("exec getUserAccess_New @userName,@appName", userName, appName).AsEnumerable().ToList();
        //        httpContext.HttpContext.Session.SetString("ucount", sp_UserRoles.Count.ToString());
        //        httpContext.HttpContext.Session.SetInt32("uid", Convert.ToInt32(sp_UserRoles.FirstOrDefault().RoleID));
        //        httpContext.HttpContext.Session.SetString("uname", sp_UserRoles.FirstOrDefault().UserName);
        //        httpContext.HttpContext.Session.SetString("urole", sp_UserRoles.FirstOrDefault().RoleName);
        //    }

        //    catch (Exception ex) { }
        //    return sp_UserRoles;
        //}
        public List<Sp_userRole> GetUserRole(string user)
        {
            List<Sp_userRole> sp_UserRoles = new List<Sp_userRole>();
            string ApplicationAccessRole = "";
            var userName = new SqlParameter("@userName", user);
            var appName = new SqlParameter("@appName", "NB_VAT_FEES");
            try
            {
                // Fot get Application access Roles
                var connString = dirdbcontext.Database.GetDbConnection();
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = dirdbcontext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "GetAplicationGetUserRole";
                cmd.Parameters.AddWithValue("@username", user);
                conn.Open();
                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string n = dataTable.Rows[i]["RoleName"].ToString();
                        ApplicationAccessRole += n + ",";
                    }
                    httpContext.HttpContext.Session.SetString("AppAccessRoles", ApplicationAccessRole);
                }
                conn.Close();

                // For get User roles
                sp_UserRoles = dirdbcontext.Sp_UserRoles.FromSqlRaw("exec getUserAccess_New @userName,@appName", userName, appName).AsEnumerable().ToList();
                if(sp_UserRoles.FirstOrDefault().RoleName == "No Access")
                {
                    sp_UserRoles.FirstOrDefault().RoleName = "";
                }
                httpContext.HttpContext.Session.SetString("ucount", sp_UserRoles.Count.ToString());
                httpContext.HttpContext.Session.SetInt32("uid", Convert.ToInt32(sp_UserRoles.FirstOrDefault().RoleID));
                httpContext.HttpContext.Session.SetString("uname", sp_UserRoles.FirstOrDefault().UserName);
                httpContext.HttpContext.Session.SetString("urole", sp_UserRoles.FirstOrDefault().RoleName);
            }

            catch (Exception ex) { }
            return sp_UserRoles;
        }
    }
}
