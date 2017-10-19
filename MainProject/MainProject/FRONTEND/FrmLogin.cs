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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool DataIsValid()
        {
            String msgError = "Faltan los siguientes campos:";

            bool success = true;

            if (txtUser.Text.Length == 0)
            {
                msgError += "\n - Nombre de usuario";
                success = false;
            }
            if (txtPass.Text.Length == 0)
            {
                msgError += "\n - Contraseña";
                success = false;
            }

            if (!success)
                MessageBox.Show(null, msgError, "Error", MessageBoxButtons.OK);

            return success;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DataIsValid()) 
                return;

            UsersPOJO user = UsersDAO.Login(txtUser.Text, txtPass.Text);

            if(user != null)
            {
                this.Visible = false;
                (new FrmPrincipal(user)).Show();
            } 
            else
            {
                MessageBox.Show(null, "Credenciales inválidas", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
