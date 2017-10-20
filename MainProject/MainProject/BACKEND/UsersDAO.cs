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
    public class UsersDAO
    {
        /// <summary>
        /// Verifica que las credenciales dadas sean válidas. En caso afirmativo
        /// retorna un objeto UsersPOJO con los datos del usuario.
        /// </summary>
        /// <param name="User">Nombre de usuario</param>
        /// <param name="Pass">Contraseña</param>
        /// <returns></returns>
        public static UsersPOJO Login(String User, String Pass)
        {
            try
            {
                // Crea la consulta y asigna los parámetros
                String query = "SELECT Nick, Name, Email FROM Users WHERE Nick=@USER AND SHA2(@PASS, 512) = Pass";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@USER", User);
                cmd.Parameters.AddWithValue("@PASS", Pass);

                // Ejecuta la consulta y la almacena
                DataTable tbl = Connection.Query(cmd);

                // Solo debe existir un registro
                if (tbl != null && tbl.Rows.Count == 1)
                    return UsersPOJO.FromDataRow(tbl.Rows[0]);
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
    }
}
