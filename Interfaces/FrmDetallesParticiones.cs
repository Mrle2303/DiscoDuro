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
        DiscoDuro disco;
        private string nombreParticion;//-- guardara el nombre de la particion que se va añadir
        private int tamanioParticion;//-- guardara el tamaño de la particion que se va añadir
        //----------------------- CONSTRUCTOR ---------------------------
        public FrmDetallesParticiones(int tamanioDiscoDuro)
        {
            InitializeComponent();
            disco = new DiscoDuro(tamanioDiscoDuro);
        }
        //---------------------- METODOS -----------------------------------------------------
        private void btnAñadir_Click(object sender, EventArgs e)//-- Metodo al hacer clic sobre el boton añadir
        {
            tamanioParticion = int.Parse(TxtTamanioP.Text);//-- Guarda el tamaño de la particion que añadira el usuario
            if (tamanioParticion <= disco.TamanioDiscoDisponible && tamanioParticion > 0)//-- Verifica si hay espacio disponible en el DD para añadir particion
            {
                nombreParticion = TxtNombreP.Text;
                Particiones particion = new Particiones(tamanioParticion, nombreParticion);//-- Creamos la particion y por medio del constructor pasamos la info
                disco.AsignarParticion(particion);//-- Añadimos la particion a la lista
                int n = DgvInfoParticiones.Rows.Add();//--Se adicionan nuevo renglones y cuento en cual voy
                DgvInfoParticiones.Rows[n].Cells[0].Value = particion.Nombre;//--Coloca la informacion de la particion
                DgvInfoParticiones.Rows[n].Cells[1].Value = particion.Tamanio+" MB";//Coloca la informacion del tamaño
                LimpiarTexto();
            }
            else//-- en caso de que el archivo no quepa
            {
                MessageBox.Show("No hay suficiente espacio\npara añadir la particion");
                LimpiarTexto();
            }
        }
        private void LimpiarTexto()//----- Para limpiar los textos
        {
            TxtNombreP.Text = "";//--Limpia los text
            TxtTamanioP.Text = "";//--Limpia los text
        }

        private void DgvInfoParticiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//--Enviara los datos al formularioDetalleArchivos
        {
            nombreParticion = DgvInfoParticiones.Rows[DgvInfoParticiones.CurrentRow.Index].Cells[0].Value.ToString();
            Particiones particion = disco.ObtenerParticion(nombreParticion);
            Console.WriteLine(particion.Nombre);//---------- Linea de prueba

            FrmDetallesArchivos frm = new FrmDetallesArchivos(particion);
            frm.Show();
        }
        private void btnBorar_Click(object sender, EventArgs e)
        {
            nombreParticion = DgvInfoParticiones.Rows[DgvInfoParticiones.CurrentRow.Index].Cells[0].Value.ToString();
            DgvInfoParticiones.Rows.Remove(DgvInfoParticiones.CurrentRow);//--Su funcion es para la particion que este seleccionada elimine completamente la columna
            disco.BorrarParticiones(nombreParticion);
        }

        private void FrmDetallesParticiones_Load(object sender, EventArgs e)
        {

        }

        private void TxtTamanioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;
            }
        }

        private void TxtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar <58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;
            }
        }
    }
}
