using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvanceProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text == "El Admin" && tbxPass.Text == "D3r3zz3d")
            {
                new Cobro().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña ingresados son incorrectos. Inténtalo de nuevo");
                tbxUser.Clear();
                tbxPass.Clear();
                tbxUser.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbxUser.Clear();
            tbxPass.Clear();
            tbxUser.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
