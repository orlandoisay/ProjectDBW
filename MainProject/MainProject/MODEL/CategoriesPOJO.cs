using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.MODEL
{
    public class CategoriesPOJO
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }

        /// <summary>
        /// Crea un objeto de tipo CategoriesPOJO vacio.
        /// </summary>
        public CategoriesPOJO() { }
        /// <summary>
        /// Crea un objeto de tipo CategoriesPOJO con el identificador
        /// especificado.
        /// </summary>
        /// <param name="CategoryID">Id de la categoria</param>
        public CategoriesPOJO(int CategoryID)
        {
            this.CategoryID = CategoryID;
        }
        /// <summary>
        /// Crea un objeto de tipo CategoriesPOJO con los datos especificados.
        /// </summary>
        /// <param name="CategoryID">Id de la categoria</param>
        /// <param name="CategoryName">Nombre de la categoria</param>
        public CategoriesPOJO(int CategoryID, String CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }

        /// <summary>
        /// Crea un objeto de tipo CategoriesPOJO a partir de un objeto de 
        /// tipo DataRow que proviene de las consultas a la base de datos.
        /// </summary>
        /// <param name="dr">Es el contenedor DataRow que tiene los datos del objeto.</param>
        /// <returns></returns>
        public static CategoriesPOJO FromDataRow(DataRow dr)
        {
            try
            {
                return new CategoriesPOJO(
                    int.Parse(dr["CategoryID"].ToString()),
                    dr["CategoryName"].ToString()
                );
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
