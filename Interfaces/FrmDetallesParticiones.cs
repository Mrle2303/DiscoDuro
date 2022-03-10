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
        //----------------------- ATRIBUTOS ----------------------------
        private int tamanioDiscoTotal;//Variable que guardara el tamaño total del DD
        private int tamanioDiscoDisponible;//--Guardara el disponible que hay del DD
        private List<Particiones> listaParticiones;//-- guardara cuantas y cuales particiones vamos creando
        private string nombreParticion;//-- guardara el nombre de la particion que se va añadir
        private int tamanioParticion;//-- guardara el tamaño de la particion que se va añadir
        //----------------------- CONSTRUCTOR ---------------------------
        public FrmDetallesParticiones(int tamanioDiscoDuro)
        {    
            InitializeComponent();
            this.tamanioDiscoTotal = tamanioDiscoDuro;//-- Asignamos cual sera el tamaño total del disco
            this.tamanioDiscoDisponible = tamanioDiscoTotal;//-- Al principio el espacion disponible es el mismo al de el total ya que aun no hay nada
            listaParticiones = new List<Particiones>();//-- Se instancia el objeto de la lista donde estara las particiones
        }
        //---------------------- METODOS -----------------------------------------------------
        private void btnAñadir_Click(object sender, EventArgs e)//-- Metodo al hacer clic sobre el boton añadir
        {
            tamanioParticion = int.Parse(TxtTamanioP.Text);//-- Guarda el tamaño de la particion que añadira el usuario
            if (tamanioParticion < tamanioDiscoDisponible)//-- Verifica si hay espacio disponible en el DD para añadir particion
            {
                tamanioDiscoDisponible -= tamanioParticion;//-- Disminuye el tamaño disponible respecto ala particion agregada
                Particiones particion = new Particiones();//-- Guarda el nombre de la particion que añadira el usuario
                //Debes recolectar los datos que el usuario pondra como el nombre y tamaño
                particion.Nombre = nombreParticion;//nombre es lo que pondran en el text box
                particion.Tamanio = tamanioParticion;//Igual que arriba
                listaParticiones.Add(particion);//-- Añadimos la particion a la lista
            }
        }
    }
}
