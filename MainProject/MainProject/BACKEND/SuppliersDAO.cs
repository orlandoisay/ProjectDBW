using MainProject.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.BACKEND
{
    public class SuppliersDAO
    {
        /// <summary>
        /// Obtiene el registro del proveedor cuyo id sea igual al especificado en 
        /// el parámetro.
        /// </summary>
        /// <param name="ProductID">Id del proveedor</param>
        /// <returns>El proveedor si existe, sino retorna null</returns>
        public static SuppliersPOJO Select(int SupplierID)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "SELECT * FROM Suppliers WHERE SupplierID = @P0 LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@P0", SupplierID);

                // Ejecuta la consulta y la almacena
                DataTable tbl = Connection.Query(cmd);

                // Solo debe existir un registro
                if (tbl != null && tbl.Rows.Count == 1)
                    return SuppliersPOJO.FromDataRow(tbl.Rows[0]);
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
        /// Obtiene la lista de los proveedores almacenados en la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<SuppliersPOJO> Select()
        {
            try
            {
                // Crea la consulta
                String query = "SELECT * FROM Suppliers";
                MySqlCommand cmd = new MySqlCommand(query);

                // Ejecuta la consulta y almacena los resultados
                DataTable tbl = Connection.Query(cmd);

                List<SuppliersPOJO> list = new List<SuppliersPOJO>();

                if (tbl != null)
                    foreach (DataRow dr in tbl.Rows)
                        list.Add(SuppliersPOJO.FromDataRow(dr));

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
    }
}
