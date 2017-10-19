using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.MODEL
{
    public class SuppliersPOJO
    {
        public int SupplierID { get; set; }
        public String CompanyName { get; set; }

        /// <summary>
        /// Crea un objeto de tipo SuppliersPOJO vacío.
        /// </summary>
        public SuppliersPOJO() { }
        /// <summary>
        /// Crea un objeto de tipo SuppliersPOJO con el identificador
        /// especificado.
        /// </summary>
        /// <param name="SupplierID">Id del proveedor</param>
        public SuppliersPOJO(int SupplierID)
        {
            this.SupplierID = SupplierID;
        }
        /// <summary>
        /// Crea un objeto del tipo SuppliersPOJO con los datos
        /// especificados.
        /// </summary>
        /// <param name="SupplierID">Id del proveedor</param>
        /// <param name="CompanyName">Nombre del proveedor</param>
        public SuppliersPOJO(int SupplierID, String CompanyName)
        {
            this.SupplierID = SupplierID;
            this.CompanyName = CompanyName;
        }

        /// <summary>
        /// Crea un objeto de tipo SuppliersPOJO a partir de un objeto de
        /// tipo DataRow que proviene de las consultas a la base de datos.
        /// </summary>
        /// <param name="dr">Es el contenedor DataRow que tiene los datos del objeto</param>
        /// <returns></returns>
        public SuppliersPOJO FromDataRow(DataRow dr)
        {
            try
            {
                return new SuppliersPOJO(
                    int.Parse(dr["SuppliersID"].ToString()),
                    dr["CompanyName"].ToString()
                );
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
