using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.MODEL
{
    public class ProductsPOJO
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public String QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public String CategoryName
        {
            get
            {
                throw new NotImplementedException();
                //return BACKEND.CategoriesDAO.Get(CategoryID);
            }
        }
        public String CompanyName
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Crea un objeto de tipo ProductsPOJO vacio.
        /// </summary>
        public ProductsPOJO() { }
        /// <summary>
        /// Crea un objeto de tipo ProducsPOJO con el identificador
        /// especificado.
        /// </summary>
        /// <param name="ProductID">Id del producto</param>
        public ProductsPOJO(int ProductID)
        {
            this.ProductID = ProductID;
        }
        /// <summary>
        /// Crea un objeto del tipo ProductsPOJO con los datos
        /// especificados
        /// </summary>
        /// <param name="ProductID">Id del producto</param>
        /// <param name="ProductName">Nombre del producto</param>
        /// <param name="SupplierID">Id del proveedor</param>
        /// <param name="CategoryID">Id de la categoria</param>
        /// <param name="QuantityPerUnit">Cantidad por unidad de producto</param>
        /// <param name="UnitPrice">Precio unitario del producto</param>
        /// <param name="UnitsInStock">Unidades en almacen</param>
        /// <param name="UnitsOnOrder">Unidades en pedido</param>
        /// <param name="ReorderLevel">Valor de reorden</param>
        /// <param name="Discontinued">Esta descontinuado</param>
        public ProductsPOJO(int ProductID, String ProductName, int SupplierID, int CategoryID,
                            String QuantityPerUnit, double UnitPrice, int UnitsInStock, 
                            int UnitsOnOrder, int ReorderLevel, int Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.CategoryID = CategoryID;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
            this.Discontinued = Discontinued;
        }

        /// <summary>
        /// Crea un objeto de tipo ProductsPOJO a partir de un objeto de 
        /// tipo DataRow que proviene de las consultas a la base de datos.
        /// </summary>
        /// <param name="dr">Es el contenedor DataRow que tiene los datos del objeto.</param>
        /// <returns></returns>
        public static ProductsPOJO FromDataRow(DataRow dr)
        {
            try
            {
                return new ProductsPOJO(
                    int.Parse(dr["ProductID"].ToString()),
                    dr["ProductName"].ToString(),
                    int.Parse(dr["SupplierId"].ToString()),
                    int.Parse(dr["CategoryId"].ToString()),
                    dr["QuantityPerUnit"].ToString(),
                    double.Parse(dr["UnitPrice"].ToString()),
                    int.Parse(dr["UnitsInStock"].ToString()),
                    int.Parse(dr["UnitsOnOrder"].ToString()),
                    int.Parse(dr["ReorderLevel"].ToString()),
                    int.Parse(dr["Discontinued"].ToString())
                );
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
