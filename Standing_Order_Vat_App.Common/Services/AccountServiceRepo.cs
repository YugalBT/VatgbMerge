using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Standing_Order_Vat_App.DAL.GB_Register;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class AccountServiceRepo
    {

        //SqlCommand cmd;
        //SendMail mail;

        //SqlConnection cnBnk9Directory = new SqlConnection(ConfigurationManager.ConnectionStrings["Directory"].ToString());
        //SqlConnection SknanbLiveBnk9 = new SqlConnection(ConfigurationManager.ConnectionStrings["SknanbLiveBnk9"].ToString());
        //SqlConnection cnGenBnkReg = new SqlConnection(ConfigurationManager.ConnectionStrings["GenBnkReg"].ToString());
        //SqlConnection Sknanb = new SqlConnection(ConfigurationManager.ConnectionStrings["SKNANB"].ToString());
        //SqlConnection CommBnk25 = new SqlConnection(ConfigurationManager.ConnectionStrings["CommBnk25"].ToString());
        private readonly IHttpContextAccessor httpContext;

        public AccountServiceRepo(IHttpContextAccessor httpContext)
        {
            this.httpContext = httpContext;
        }
        public string GetUserId()
        {
            return httpContext.HttpContext.User.FindFirst("Id").ToString();
        }
        
        }
    }

