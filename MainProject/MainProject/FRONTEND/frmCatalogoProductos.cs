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

        }
    }
}
