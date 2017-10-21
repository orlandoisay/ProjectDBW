using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProject.BACKEND;
using MainProject.MODEL;

namespace MainProject.FRONTEND
{
    public partial class FrmCatalogoProductos : Form
    {

        public void data() {
            List<ProductsPOJO> productsList = ProductsDAO.Select();
            dtgProducts.DataSource = null;
            dtgProducts.DataSource = productsList;
        }

        public FrmCatalogoProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto frmAgregar = new FrmProducto();
            frmAgregar.Show();
            //Hace falta recargar el datagrid después de cerrar el formulario
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //ProductsPOJO objProducto = ProductsDAO.Select(int.Parse(dtgProducts.CurrentRow.Cells[0].Value.ToString()));
            FrmProducto frmEditar = new FrmProducto(int.Parse(dtgProducts.CurrentRow.Cells[0].Value.ToString()));
            frmEditar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductsPOJO objProducto = ProductsDAO.Select(int.Parse(dtgProducts.CurrentRow.Cells[0].Value.ToString()));
            if (MessageBox.Show("¿Está seguro de querere eliminar el producto " + objProducto.ProductName + "?", "Eliminar producto", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                if (ProductsDAO.Delete(objProducto.ProductID) == true)
                {
                    MessageBox.Show("Producto eliminado");
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser eliminado");
                }
            }

        }

        private void dtgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
