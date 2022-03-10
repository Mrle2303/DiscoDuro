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
        private int tamanioDiscoTotal;
        private int tamanioDiscoDisponible;
        private List<Particiones> listaParticiones;
        private string nombre;
        private int tamanio;
        public FrmDetallesParticiones(int tamanioDiscoDuro)
        {    
            InitializeComponent();
            string NombreParticion = TxtNombreP.Text;
            this.tamanioDiscoTotal = tamanioDiscoDuro;
            this.tamanioDiscoDisponible = tamanioDiscoTotal;
            listaParticiones = new List<Particiones>();
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
            if (tamanio < tamanioDiscoDisponible)
            {
                tamanioDiscoDisponible -= tamanio;
                Particiones particion = new Particiones();
                //Debes recolectar los datos que el usuario pondra como el nombre y tamaño
                particion.Nombre = TxtNombreP.Text;//nombre es lo que pondran en el text box
                particion.Tamanio = int.Parse(TxtTamanioP.Text);//Igual que arriba
                listaParticiones.Add(particion);
            }
        }
    }
}
