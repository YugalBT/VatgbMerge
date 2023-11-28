using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class AccountServiceRepo :IAccountRepo
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly DirectoryContext _directorycontext;
        SqlDataReader readRow;

        public AccountServiceRepo(IHttpContextAccessor httpContext,DirectoryContext directoryContext)
        {
            this.httpContext = httpContext;
            _directorycontext = directoryContext;
        }
        public string GetUserId()
        {
            return httpContext.HttpContext.User.FindFirst("Id").ToString();
        }
        public int GetEmpId( ref string result, ref int userId)
        {
            var connString = _directorycontext.Database.GetDbConnection();
            // get all ids needed to access the relevant pages
            result = "success";
            int empID = 0;
            string uname = Environment.UserName;
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _directorycontext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getEmpID";
                // retrieves both empId and userId for Application Directory
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", "Test");

                conn.Open();
                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    empID = Convert.ToInt32(dataTable.Rows[0]["EmployeeID"]);
                    userId = Convert.ToInt32(dataTable.Rows[0]["UserID"]);
                }
                else
                    result = "Error, employee:  " + uname + " is not in Bank9.Directory Database";
            }
            catch (Exception e)
            {
                result = "Error retrieving EmpID for user " + uname + ": " + e.Message;
            }
           
            return empID;
        }
    }
    }

