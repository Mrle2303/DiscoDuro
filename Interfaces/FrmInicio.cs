using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_de_negocios;

namespace Interfaces
{
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();
            string tamanio = txtTamaño.Text;
            
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            FrmDetallesParticiones frm = new FrmDetallesParticiones();
            frm.Show();
        }
    }
}
