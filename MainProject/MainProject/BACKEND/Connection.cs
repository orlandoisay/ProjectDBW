using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.BACKEND
{
    class Connection
    {
        public static MySqlConnection conn = null;

        public static bool Connect()
        {
            String connString =
                String.Format("Server={0};Port={1};Uid={2};Pwd={3}",
                                  Properties.Settings.Default.Server,
                                  Properties.Settings.Default.Port,
                                  Properties.Settings.Default.User,
                                  Properties.Settings.Default.Pass);
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static void Disconnect()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static DataTable Query(MySqlCommand cmd)
        {
            try
            {
                if (Connect())
                {
                    cmd.Connection = conn;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);

                    return tbl;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool Execute(MySqlCommand cmd)
        {
            try
            {
                if (Connect())
                {
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Disconnect();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
