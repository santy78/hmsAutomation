using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation.Model
{
    public class HMSAutomationDBContext
    {
        string _connectionString = ConfigurationManager.AppSettings.Get("connectionString");
        public string SaveAutomationResult(HMSAutomationResult automationresult)
        {

            var items = JsonConvert.SerializeObject(automationresult);
            string connectionString = @"Data Source=LAPTOP-E4BM7RO2\SQLEXPRESS01;Initial Catalog=hms;Integrated Security = True";
            SqlConnection dc = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Sp_HMSAutomationResult", dc);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AutomationResult", items);
            dc.Open();
            cmd.ExecuteNonQuery();
            dc.Close();

            return null;
        }
        public static int GetBatchID()
        {
            int result = 0;
            string connectionString = @"Data Source=LAPTOP-E4BM7RO2\SQLEXPRESS01;Initial Catalog=hms;Integrated Security = True";
            string _connectionString = ConfigurationManager.AppSettings.Get("connectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GETBatchId", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                result = Convert.ToInt32(dr["BatchId"]);

            }
            connection.Close();
            result = result + 1;
            return result;

        }











    }
}
