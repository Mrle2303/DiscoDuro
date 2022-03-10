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
    public partial class FrmDetallesParticiones : Form
    {
        List<Particiones> listaParticiones;
        public FrmDetallesParticiones()
        {
            InitializeComponent();
            listaParticiones = new List<Particiones>();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Particiones particion = new Particiones();
            //Debes recolectar los datos que el usuario pondra como el nombre y tamaño
            particion.Nombre = nombre;//nombre es lo que pondran en el text box
            particion.Tamanio = tamanio;//Igual que arriba
            listaParticiones.Add(particion);
        }
    }
}
