using MainProject.BACKEND;
using MainProject.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.FRONTEND
{
    public partial class FrmProducto : Form
    {
        private bool EditMode = false;
        private ProductsPOJO Prod = null;

        public FrmProducto()
        {
            InitializeComponent();
            InitWindow();
        }
        public FrmProducto(int ProductID)
        {
            InitializeComponent();

            this.Prod = ProductsDAO.Select(ProductID);
            this.EditMode = true;

            InitWindow();
        }

        public void InitWindow()
        {
            // Configuración de los combos
            cmbSupplier.DataSource = SuppliersDAO.Select();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierId";

            cmbCategory.DataSource = CategoriesDAO.Select();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            txtProductName.Focus();

            if (Prod == null) return;
            
            // Modo edición
            lblTitle.Text = "Editar producto";

            txtProductName.Text = Prod.ProductName;
            cmbSupplier.SelectedValue = Prod.SupplierID;
            cmbCategory.SelectedValue = Prod.CategoryID;
            txtQuantityPerUnit.Text = Prod.QuantityPerUnit;
            nmUnitPrice.Value = (decimal)Prod.UnitPrice;
            nmUnitsInStock.Value = Prod.UnitsInStock;
            nmUnitsOnOrder.Value = Prod.UnitsOnOrder;
            nmReorderLevel.Value = Prod.ReorderLevel;
            chkDescontinued.Checked = Prod.Discontinued != 0;
        }

        private void chkDescontinued_CheckedChanged(object sender, EventArgs e)
        {
            chkDescontinued.Text = chkDescontinued.Checked ? "Sí" : "No";
        }

        public bool DataIsValid()
        {
            bool success = true;
            String msgError = "Faltan los siguientes campos:";

            if (txtProductName.Text.Length == 0)
            {
                msgError += "\n - Nombre del producto";
                success = false;
            }
            if (cmbSupplier.SelectedIndex == -1)
            {
                msgError += "\n - Proveedor";
                success = false;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                msgError += "\n - Categoría";
                success = false;
            }
            if (txtQuantityPerUnit.Text.Length == 0)
            {
                msgError += "\n - Cantidad por unidad";
                success = false;
            }

            if (!success)
                MessageBox.Show(null, msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return success;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DataIsValid())
                return;

            Prod = new ProductsPOJO(
                EditMode ? Prod.ProductID : -1,
                txtProductName.Text,
                (int)cmbSupplier.SelectedValue,
                (int)cmbCategory.SelectedValue,
                txtQuantityPerUnit.Text,
                (double)nmUnitPrice.Value,
                (int)nmUnitsInStock.Value,
                (int)nmUnitsOnOrder.Value,
                (int)nmReorderLevel.Value,
                chkDescontinued.Checked ? 1 : 0
            );


            bool success = EditMode ? ProductsDAO.Update(Prod) : ProductsDAO.Insert(Prod);

            if (!success)
            {
                MessageBox.Show(null, "Ocurrió un error.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(null, "Cambios guardados correctamente.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
