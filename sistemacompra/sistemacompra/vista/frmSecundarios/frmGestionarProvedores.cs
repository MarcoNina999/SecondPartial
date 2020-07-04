using sistemacompra.vista.frmNuevos;
using sistemacompra.vista.frmPadres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacompra.vista.frmSecundarios
{
    public partial class frmGestionarProvedores : frmGestionar
    {
        public frmGestionarProvedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoProvedor fm = new frmNuevoProvedor();
            fm.ShowDialog();
        }
    }
}
