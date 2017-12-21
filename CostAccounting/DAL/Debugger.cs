using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccounting.DAL
{
    public class Debugger
    {
        public string Query { get; set; }
        public Debugger()
        {

        }
        public Debugger(string query)
        {
            Query = query;
        }
        public DataTable GetData()
        {
            DataTable inv = new DataTable();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\DbCostAccounting.mdf;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            try
            {
                using (SqlCommand cmd = new SqlCommand(Query, connect))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    inv.Load(dr);
                    dr.Close();
                    connect.Close();
                }
                return inv;
            }
            catch
            {
                return null;
            }            
        }
    }
}
