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
    public partial class FrmPrincipal : Form
    {
        private UsersPOJO User = null;

        public FrmPrincipal(UsersPOJO User)
        {
            InitializeComponent();
            this.User = User;
            InitWindow();
        }

        public void InitWindow()
        {
            lblWelcomeMessage.Text = String.Format("Bienvenido: {0} | {1}", User.Name, User.Email);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
