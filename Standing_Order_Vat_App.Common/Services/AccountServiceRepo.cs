using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.Common.GeneralResult;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.ViewModels;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNAB;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class AccountServiceRepo : IAccountRepo
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly DirectoryContext _directorycontext;
        private SKNABContext _sKNABContext;
        private readonly SKNANBLIVEContext _sKNANBLIVEContext;
        SqlDataReader readRow;

        public AccountServiceRepo(IHttpContextAccessor httpContext, DirectoryContext directoryContext, SKNABContext sKNABContext, SKNANBLIVEContext sKNANBLIVEContext)
        {
            this.httpContext = httpContext;
            _directorycontext = directoryContext;
            _sKNABContext = sKNABContext;
            _sKNANBLIVEContext = sKNANBLIVEContext;
        }
        public string GetUserId()
        {
            return httpContext.HttpContext.Session.GetString("UserId");
        }
        public string GetLastName()
        {
            return httpContext.HttpContext.Session.GetString("LASTNAME");
        }
        public string GetFirstName()
        {
            return httpContext.HttpContext.Session.GetString("FirstName");
        }
        public string GetDepartment()
        {
            return httpContext.HttpContext.Session.GetString("Department");
        }
        public string GetJobTitle()
        {
            return httpContext.HttpContext.Session.GetString("JobTitle");

        }
        public string GetEmpCode()
        {
            return httpContext.HttpContext.Session.GetString("EmpCode");
        }
        public string GetEmpId()
        {
            return httpContext.HttpContext.Session.GetString("EmpId");
        }
        public string GetBranchID()
        {
            return httpContext.HttpContext.Session.GetString("BranchId");
        }
        public string GetBranchName()
        {
            return httpContext.HttpContext.Session.GetString("BranchName");
        }
        public string GetCoreId()
        {
            return httpContext.HttpContext.Session.GetString("CoreID");
        }
        public string GetSSnum()
        {
            return httpContext.HttpContext.Session.GetString("SsNum");
        }
        public string GetAppAccessRoles()
        {
            return httpContext.HttpContext.Session.GetString("AppAccessRoles") ?? "";
        }
        public string Geturole()
        {
            return httpContext.HttpContext.Session.GetString("urole") ?? "";
        }
        public string Getucount()
        {
            return httpContext.HttpContext.Session.GetString("ucount") ?? "";
        }
        public string Getuname()
        {
            return httpContext.HttpContext.Session.GetString("uname");
        } 
        public string Getuid()
        {
            return httpContext.HttpContext.Session.GetString("uid");
        }

        
        public int GetUserinfo(ref string result, ref GetCurrentUserInfoVm userinfo)
        {
            try
            {
                SetUserinfoInSession();
                GetCurrentUserInfoVm vm = new GetCurrentUserInfoVm();
                vm.FirstName = GetFirstName();
                vm.BranchName = GetBranchName();
                vm.LASTNAME = GetLastName();
                vm.EmpCode = GetEmpCode();
                vm.ssnum = GetSSnum();
                vm.CoreID = GetCoreId();
                vm.EmpID = GetEmpId();
                vm.JobTitle = GetJobTitle();
                vm.UserId = GetUserId();
                vm.Department = GetDepartment();
                vm.BranchID = GetBranchID();
                userinfo = vm;
                result = "Success";
            }

            catch (Exception e)
            {
                result = "Error retrieving EmpID for user " + GetFirstName() + ": " + e.Message;
            }

            return Convert.ToInt32(userinfo.EmpID);
        }
        public void SetUserinfoInSession()
        {
            GetCurrentUserInfoVm userinfo = new GetCurrentUserInfoVm();
            var connString = _directorycontext.Database.GetDbConnection();
            // get all ids needed to access the relevant pages
            //result = "success";
            int empID = 0;
            //string uname = Environment.UserName;
            string uname = "LISAME";
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
                //cmd.Parameters.AddWithValue("@userName", "Test");
                cmd.Parameters.AddWithValue("@userName", uname);

                conn.Open();
                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                adp.Dispose();
                conn.Close();
                if (dataTable.Rows.Count > 0)
                {
                    userinfo.EmpID = dataTable.Rows[0]["EmployeeID"].ToString();
                    empID = Convert.ToInt32(userinfo.EmpID);

                    if (Convert.ToInt32(userinfo.EmpID) > 0)
                    {
                        userinfo.UserId = dataTable.Rows[0]["UserID"].ToString();
                        userinfo.ssnum = GetSocSecNum(Convert.ToInt32(userinfo.EmpID));
                        if (!string.IsNullOrEmpty(userinfo.ssnum))
                        {
                            GetCurrentUserPersonalInfo(ref userinfo);
                            httpContext.HttpContext.Session.SetString("FirstName", userinfo.FirstName);
                            httpContext.HttpContext.Session.SetString("BranchName", userinfo.BranchName);
                            httpContext.HttpContext.Session.SetString("LastName", userinfo.LASTNAME);
                            httpContext.HttpContext.Session.SetString("EmpCode", userinfo.EmpCode);
                            httpContext.HttpContext.Session.SetString("SsNum", userinfo.ssnum);
                            httpContext.HttpContext.Session.SetString("CoreID", userinfo.CoreID);
                            httpContext.HttpContext.Session.SetString("EmpId", userinfo.EmpID);
                            httpContext.HttpContext.Session.SetString("JobTitle", userinfo.JobTitle);
                            httpContext.HttpContext.Session.SetString("UserId", userinfo.UserId);
                            httpContext.HttpContext.Session.SetString("Department", userinfo.Department);
                            httpContext.HttpContext.Session.SetString("BranchId", userinfo.BranchID);
                        }

                    }

                }

            }
            catch (Exception e)
            {

            }
        }
        public string GetCurrentUserPersonalInfo(ref GetCurrentUserInfoVm userInfo)
        {

            var connString = _sKNANBLIVEContext.Database.GetDbConnection();
            string result = "Success";

            try
            {

                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _sKNANBLIVEContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUserInfo";
                cmd.Parameters.AddWithValue("@ssnum", userInfo.ssnum);
                cmd.Parameters.AddWithValue("@empId", userInfo.EmpID);

                conn.Open();

                DbDataAdapter adp = Helper.DataAdapterUD.CreateDataAdapter(connString, cmd);
                var dataTable = new DataTable();
                adp.Fill(dataTable);
                adp.Dispose();
                conn.Close();
                if (dataTable.Rows.Count == 0)
                {
                    string msg = "User is not in the SKNAB.dbo.UPR00100 table";
                    string subj = "Login failed for user  " + userInfo;
                }
                else
                {

                    userInfo.EmpID = (dataTable.Rows[0]["EmpID"]).ToString();
                    userInfo.LASTNAME = (dataTable.Rows[0]["LASTNAME"]).ToString();
                    userInfo.FirstName = (dataTable.Rows[0]["FRSTNAME"]).ToString();
                    userInfo.Department = (dataTable.Rows[0]["DEPT"]).ToString();
                    userInfo.JobTitle = (dataTable.Rows[0]["JobTitle"]).ToString();
                    userInfo.EmpCode = (dataTable.Rows[0]["EmpCode"]).ToString();
                    userInfo.BranchID = dataTable.Rows[0]["BranchId"].ToString();
                    userInfo.BranchName = dataTable.Rows[0]["BranchName"].ToString();
                    userInfo.CoreID = dataTable.Rows[0]["CoreID"].ToString();
                    // userInfo.UserId = (readRow["UserId"]).ToString();

                }

            }
            catch (SqlException exp)
            {
                result = "Error retrieving user info for " + userInfo.ssnum + ": " + exp.Message;
            }

            return result;
        }
        public string GetSocSecNum(int empId)
        {
            string ssnum = "";

            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                conn.ConnectionString = _sKNANBLIVEContext.Database.GetDbConnection().ConnectionString;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getSSNum";
                cmd.Parameters.AddWithValue("@empID", empId);

                conn.Open();
                ssnum = (cmd.ExecuteScalar()).ToString();
                cmd.Connection.Close();
                conn.Close();
            }
            catch (Exception s)
            {
                ssnum = "Error " + s.Message;
            }
            return ssnum;
        }
        public void RemoveSessionData()
        {
            httpContext.HttpContext.Session.Clear();
        }
    }
}

