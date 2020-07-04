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
using sistemacompra.vista.frmSecundarios;

namespace sistemacompra.vista.frmPadres
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Funcion que permite abrir un formulario dentro del panel
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGestionarUsuario());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGestionarProductos());
        }

        private void btnProvedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGestionarProvedores());
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            frmLogin fm = new frmLogin();
            this.Close();
            fm.Show();
        }

        private void Pbxrecorrer_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 227)
                PanelMenuVertical.Width = 70;
            else
                PanelMenuVertical.Width = 227;
        }

        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
