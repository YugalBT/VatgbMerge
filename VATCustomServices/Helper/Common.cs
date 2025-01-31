using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATCustomServices.Helper
{
    public static class Common
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        public static double GetVatApplyValue(string connectionstring, DateTime recorddate)
        {
            double vatValue = 1.17;

            try
            {
                conn = new SqlConnection(connectionstring);
                cmd = new SqlCommand("GetActiveVatValue", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RecordDate", recorddate);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    vatValue = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return vatValue;
        }
    }
}
