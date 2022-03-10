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
            
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Particiones objEspacio = new Particiones();
            objEspacio.Tamanios = int.Parse(txtTamaño.Text);
            FrmDetallesParticiones frm = new FrmDetallesParticiones();
            frm.Show();
        }
    }
}
