using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AvanceProyecto
{
    public partial class Cobro : Form
    {

        private Form currentChildForm;
        public Cobro()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pbxMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbxMaximize.Visible = false;
            pbxRestore.Visible = true;
        }

        private void pbxRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbxRestore.Visible = false;
            pbxMaximize.Visible = true;
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pContainer.Controls.Add(childForm);
            pContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventario());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras());
        }
    }
}
