using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MainProject.MODEL;

namespace MainProject.BACKEND
{
    public class CategoriesDAO
    {
        /// <summary>
        /// Obtiene el registro de la categoría cuyo id sea igual al especificado en 
        /// el parámetro.
        /// </summary>
        /// <param name="CategoryID">Id de la categoría a retornar</param>
        /// <returns>La categoría si existe, sino retorna null</returns>
        public static CategoriesPOJO Select(int CategoryID) {
            try {
                // Crea la consulta y asigna los parámetros
                String query = "SELECT * FROM Categories WHERE CategoryId = @P0 LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@P0", CategoryID);

                // Ejecuta la consulta y la almacena
                DataTable tbl = Connection.Query(cmd);

                // Solo debe existir un registro
                if (tbl != null && tbl.Rows.Count == 1)
                    return CategoriesPOJO.FromDataRow(tbl.Rows[0]);
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
        ///  Obtiene la lista de las categorías almacenados en la base de datos.
        /// </summary>
        /// <returns>La lista con los nombres de las categorías si existen, o null si no.</returns>
        public static List<CategoriesPOJO> Select()
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "SELECT * FROM Categories";
                MySqlCommand cmd = new MySqlCommand(query);


                // Ejecuta la consulta y almacena los resultados
                DataTable tbl = Connection.Query(cmd);

                List<CategoriesPOJO> list = new List<CategoriesPOJO>();

                if (tbl != null)
                    foreach (DataRow dr in tbl.Rows)
                        list.Add(CategoriesPOJO.FromDataRow(dr));

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
