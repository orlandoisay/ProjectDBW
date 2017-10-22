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
        /// <summary>
        /// Obtiene el registro del producto cuyo id sea igual al especificado en 
        /// el parámetro.
        /// </summary>
        /// <param name="ProductID">Id del producto a retornar</param>
        /// <returns>El producto si existe, sino retorna null</returns>
        public static ProductsPOJO Select(int ProductID)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "SELECT * FROM products WHERE ProductId = @P0 LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@P0", ProductID);

                // Ejecuta la consulta y la almacena
                DataTable tbl = Connection.Query(cmd);

                // Solo debe existir un registro
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
        /// <summary>
        /// Obtiene la lista de los productos almacenados en la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<ProductsPOJO> Select()
        {
            try
            {
                // Crea la consulta
                String query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query);

                // Ejecuta la consulta y almacena los resultados
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
        /// <summary>
        /// Inserta un registro de un producto nuevo en la base de datos.
        /// </summary>
        /// <param name="Product">El objeto que tiene los datos del registro a insertar</param>
        /// <returns>Retorna true si se pudo agregar el producto</returns>
        public static bool Insert(ProductsPOJO Product)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
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

                // Ejecuta la consulta
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
        /// <summary>
        /// Actualiza los datos de un producto existente en la base de datos. Modifica el registro que 
        /// concuerda con el ProductID del objeto de parámetro
        /// </summary>
        /// <param name="Product">El objeto que tiene los datos del registro a actualizar.</param>
        /// <returns>Retorna true si se pudo actualizar el registro</returns>
        public static bool Update(ProductsPOJO Product)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "UPDATE products SET ProductName = @P1, SupplierID = @P2, CategoryID = @P3, " +
                               "QuantityPerUnit = @P4, UnitPrice = @P5, UnitsInStock = @P6, UnitsOnOrder = @P7," + 
                               "ReorderLevel = @P8, Discontinued = @P9 WHERE ProductID = @P0";
                var cmd = new MySqlCommand(query);

                cmd.Parameters.AddWithValue("@P0", Product.ProductID);
                cmd.Parameters.AddWithValue("@P1", Product.ProductName);
                cmd.Parameters.AddWithValue("@P2", Product.SupplierID);
                cmd.Parameters.AddWithValue("@P3", Product.CategoryID);
                cmd.Parameters.AddWithValue("@P4", Product.QuantityPerUnit);
                cmd.Parameters.AddWithValue("@P5", Product.UnitPrice);
                cmd.Parameters.AddWithValue("@P6", Product.UnitsInStock);
                cmd.Parameters.AddWithValue("@P7", Product.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@P8", Product.ReorderLevel);
                cmd.Parameters.AddWithValue("@P9", Product.Discontinued);

                // Ejecuta la consulta
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
        /// <summary>
        /// Borra el registro del producto cuyo ProductID concuerda con el parámetro
        /// </summary>
        /// <param name="ProductID">Id del producto a eliminar</param>
        /// <returns>Retorna true si se pudo eliminar el registro</returns>
        public static bool Delete(int ProductID)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "DELETE FROM products WHERE ProductID = @P0";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@P0", ProductID);

                // Ejecuta la consulta
                Connection.Execute(cmd);

                return true;
            }
            catch (Exception ex)
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
