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

            int tamanioDiscoDuro = int.Parse(txtTamaño.Text);
            FrmDetallesParticiones frm = new FrmDetallesParticiones(tamanioDiscoDuro);
            this.Hide();
            frm.Show();
        }

        private void txtTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <=255))//--Validacion para solo insertar numeros
            {
               e.Handled = true;
            }
        }
    }
}
