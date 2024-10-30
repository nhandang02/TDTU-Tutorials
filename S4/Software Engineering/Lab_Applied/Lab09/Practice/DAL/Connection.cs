using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;
        private static string connectionString = "Data Source=NHANDANG76E7;Initial Catalog=InternManage;Integrated Security=True";

        public static void Connect()
        {
            try
            {
                cn = new SqlConnection(connectionString);
                cn.Open();
                Console.WriteLine("Connected to database successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }
        }

        public static void Close()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
                Console.WriteLine("Connection closed.");
            }
        }

        public static void ActionQuery(string sql)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Query executed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public static DataTable selectQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }
    }
}
