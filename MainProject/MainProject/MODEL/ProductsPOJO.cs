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

        public ProductsPOJO() { }
        public ProductsPOJO(int ProductID)
        {
            this.ProductID = ProductID;
        }
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
