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
        DiscoDuro disco;//-- Guardara la informacion del DD
        private string nombreParticion;//-- guardara el nombre de la particion que se va añadir
        private int tamanioParticion;//-- guardara el tamaño de la particion que se va añadir
        //----------------------- CONSTRUCTOR ---------------------------
        public FrmDetallesParticiones(int tamanioDiscoDuro)//-- Constructor que tiene info del DD
        {
            InitializeComponent();
            disco = new DiscoDuro(tamanioDiscoDuro);//-- Creamos el disco duro
        }
        //---------------------- METODOS -----------------------------------------------------
        private void btnAñadir_Click(object sender, EventArgs e)//-- Metodo al hacer clic sobre el boton añadir
        {
            if(TxtNombreP.Text != "" && TxtTamanioP.Text != "")
            {
                nombreParticion = TxtNombreP.Text;
                if (!disco.VerificarNombreParticion(nombreParticion))// si no esta en la particion que se meta al bloque
                {
                    tamanioParticion = int.Parse(TxtTamanioP.Text);//-- Guarda el tamaño de la particion que añadira el usuario
                    if (tamanioParticion <= disco.TamanioDiscoDisponible && tamanioParticion > 0)//-- Verifica si hay espacio disponible en el DD para añadir particion
                    {
                        Particiones particion = new Particiones(tamanioParticion, nombreParticion);//-- Creamos la particion y por medio del constructor pasamos la info
                        disco.AsignarParticion(particion);//-- Añadimos la particion a la lista
                        int n = DgvInfoParticiones.Rows.Add();//--Se adicionan nuevo renglones y cuento en cual voy
                        DgvInfoParticiones.Rows[n].Cells[0].Value = particion.Nombre;//--Coloca la informacion de la particion
                        DgvInfoParticiones.Rows[n].Cells[1].Value = particion.Tamanio + " MB";//Coloca la informacion del tamaño
                        LimpiarTexto();
                    }
                    else//-- en caso de que el archivo no quepa
                    {
                        MessageBox.Show("No hay suficiente espacio\npara añadir la particion");
                        LimpiarTexto();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una particion con este nombre");
                }
            }
           
        }
        private void LimpiarTexto()//----- Para limpiar los textos
        {
            TxtNombreP.Text = "";//--Limpia los text
            TxtTamanioP.Text = "";//--Limpia los text
        }

        private void DgvInfoParticiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//--Enviara los datos al formularioDetalleArchivos
        {
            nombreParticion = DgvInfoParticiones.Rows[DgvInfoParticiones.CurrentRow.Index].Cells[0].Value.ToString();//--Obtenemos el nombre de la fila seleccionada
            Particiones particion = disco.ObtenerParticion(nombreParticion);//-- Obtenemos de que partciones se trata
            FrmDetallesArchivos frm = new FrmDetallesArchivos(particion);//-- Mandamos la particion a su frm para que la trabaje
            frm.Show();//-- se muestra el frm
        }
        private void btnBorar_Click(object sender, EventArgs e)
        {
            if(DgvInfoParticiones.CurrentRow != null)
            {
                nombreParticion = DgvInfoParticiones.Rows[DgvInfoParticiones.CurrentRow.Index].Cells[0].Value.ToString();//--Obtenemos el nombre de la fila seleccionada
                DgvInfoParticiones.Rows.Remove(DgvInfoParticiones.CurrentRow);//--Su funcion es para la particion que este seleccionada elimine completamente la columna
                disco.BorrarParticiones(nombreParticion);//-- Borra la particion del disco duro
            }
        }
        private void TxtTamanioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//--Es la validacion para solo insertar  numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void TxtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar <58)//--Es la validacion para solo insertar  letras
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }

        private void FrmDetallesParticiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
