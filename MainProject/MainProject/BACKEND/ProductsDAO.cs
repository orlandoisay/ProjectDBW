using MainProject.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MainProject.BACKEND
{
    public class ProductsDAO
    {        
        public static ProductsPOJO Select(int ProductID)
        {
            try
            {
                String query = "SELECT * FROM Products WHERE ProductId = @P0 LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@P0", ProductID);

                DataTable tbl = Connection.Query(cmd);

                if (tbl != null && tbl.Rows.Count == 1)
                    return ProductsPOJO.FromDataRow(tbl.Rows[0]);
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Disconnect();
            }
        }    
        public static List<ProductsPOJO> Select()
        {
            try
            {
                String query = "SELECT * FROM Products";
                MySqlCommand cmd = new MySqlCommand(query);

                DataTable tbl = Connection.Query(cmd);

                List<ProductsPOJO> list = new List<ProductsPOJO>();

                if (tbl != null) 
                    foreach (DataRow dr in tbl.Rows)
                        list.Add(ProductsPOJO.FromDataRow(dr));

                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Disconnect();
            }
        }
        public static bool Insert(ProductsPOJO Product)
        {
            try
            {
                String query = "INSERT INTO products VALUES(null,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)";
                var cmd = new MySqlCommand(query);

                cmd.Parameters.AddWithValue("@p1", Product.ProductName);
                cmd.Parameters.AddWithValue("@p2", Product.SupplierID);
                cmd.Parameters.AddWithValue("@p3", Product.CategoryID);
                cmd.Parameters.AddWithValue("@p4", Product.QuantityPerUnit);
                cmd.Parameters.AddWithValue("@p5", Product.UnitPrice);
                cmd.Parameters.AddWithValue("@p6", Product.UnitsInStock);
                cmd.Parameters.AddWithValue("@p7", Product.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@p8", Product.ReorderLevel);
                cmd.Parameters.AddWithValue("@p9", Product.Discontinued);

                return Connection.Execute(cmd);
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Disconnect();
            }
        }
    }
}
