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
        private int n = 0;//--Guardara lo que se selecciona y podamos eliminarlo por medio del boton
        private int tamanioDiscoTotal;//--Variable que guardara el tamaño total del DD
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
            if (tamanioParticion <= tamanioDiscoDisponible && tamanioParticion > 0)//-- Verifica si hay espacio disponible en el DD para añadir particion
            {
                nombreParticion = TxtNombreP.Text;
                Particiones particion = new Particiones(tamanioParticion, nombreParticion);//-- Creamos la particion y por medio del constructor pasamos la info
                listaParticiones.Add(particion);//-- Añadimos la particion a la lista
                int n = DgvInfoParticiones.Rows.Add();//--Se adicionan nuevo renglones y cuento en cual voy
                DgvInfoParticiones.Rows[n].Cells[0].Value = particion.Nombre;//--Coloca la informacion de la particion
                DgvInfoParticiones.Rows[n].Cells[1].Value = particion.Tamanio;//Coloca la informacion del tamaño
                TxtNombreP.Text = "";//--Limpia los text
                TxtTamanioP.Text = "";//--Limpia los text
                tamanioDiscoDisponible -= tamanioParticion;//-- Disminuye el tamaño disponible respecto ala particion agregada
            }
            else//-- en caso de que el archivo no quepa
            {
                MessageBox.Show("No hay suficiente espacio\npara añadir la particion");
            }
        }

        private void DgvInfoParticiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//--Enviara los datos al formularioDetalleArchivos
        {
            nombreParticion = DgvInfoParticiones.Rows[DgvInfoParticiones.CurrentRow.Index].Cells[0].Value.ToString();
            Particiones particion = ObtenerParticion(nombreParticion);
            Console.WriteLine(particion.Nombre);//---------- Linea de prueba

            FrmDetallesArchivos frm = new FrmDetallesArchivos(particion);
            frm.Show();
        }

        private Particiones ObtenerParticion(string nombre)//-- Metodo que me dira que aparticion es depediendo su nombre
        {
            for(int i = 0; i < listaParticiones.Count; i++)//-- da vueltas hasta que se acabe la lista
            {
                if (listaParticiones[i].Nombre == nombre)//-- revisa si el nombre esta en la lista
                {
                    return listaParticiones[i];//-- devuelve la particion escogida
                }
            }
            return null;
        }
        private void btnBorar_Click(object sender, EventArgs e)
        {
            //--Su funcion es para la particion que este seleccionada elimine completamente la columna
            
        }
    }
}
