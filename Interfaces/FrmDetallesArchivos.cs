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
    public partial class FrmDetallesArchivos : Form
    {
        private Particiones particion;
        public FrmDetallesArchivos(Particiones particion)
        {
            InitializeComponent();
            this.particion = particion;
        }

        private void FrmDetallesArchivos_Load(object sender, EventArgs e)
        {

        }
    }
}
