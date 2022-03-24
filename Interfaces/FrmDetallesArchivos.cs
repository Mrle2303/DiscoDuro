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
        private string nombreArch;
        private int tamanioArch;
        private DataTable archivos;
        private Particiones particion;
        private List<Archivos> listaArchivos;
        private FrmDetallesParticiones frmDetallesParticiones;
        public FrmDetallesArchivos(Particiones particion, FrmDetallesParticiones frmDetallesParticiones)
        {
            InitializeComponent();
            this.particion = particion;
            this.Text = particion.Nombre;
            this.frmDetallesParticiones = frmDetallesParticiones;
            archivos = new DataTable(); //se crea el objeto para manejar el datagridview
            archivos.Columns.Add("Nombre del archivo"); //mediante el objeto se le añade columna al datagridview
            archivos.Columns.Add("Tamaño del archivo"); //mediante el objeto se le añade columna al datagridview
            dgvArchivos.DataSource=archivos;  //le mandamos al datagridview la informacion de las columnas 
            mostrarArchivosExistentes();
        }
        private void mostrarArchivosExistentes()//-- metodo que vera si en la particion ya hay archivos
        {
            listaArchivos = particion.ObtenerListaDeArchivos();//-- Obtengo la lista de archivos de la particion
            for (int i = 0; i < listaArchivos.Count; i++)//-- Recorremos toda la lista
            {
                DataRow row = archivos.NewRow();//-- se crea la nueva fila
                row["Nombre del archivo"] = listaArchivos[i].Nombre;//le establece la informacion a la fila tomandola del archivo correspondiente
                row["Tamaño del archivo"] = listaArchivos[i].Tamanio + " MB";//le establece la informacion a la fila tomandola del archivo correspondiente
                archivos.Rows.Add(row); //se van añadiendo las filas con los datos introducidos
            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if(txtNombreAr.Text != "" && txtTamañoAr.Text != "")
            {
                DataRow row = archivos.NewRow(); //se crea el objeto row para que agregue filas
                nombreArch = txtNombreAr.Text;//Se guarda el nombre del archivo obtenido del text box
                tamanioArch = int.Parse(txtTamañoAr.Text);
                Archivos archivo = new Archivos(nombreArch, tamanioArch);//se crea el objeto de la clase archivos
                if (archivo.Tamanio <= particion.TamanioDisponible)//Evaluar que el tamaño del archivo sea menos que el de la particion
                {
                    particion.AgregarArchivo(archivo);
                    row["Nombre del archivo"] = archivo.Nombre;//le establece la informacion a la fila tomandola de la variable con el valor del textBox
                    row["Tamaño del archivo"] = archivo.Tamanio + " MB";//le establece la informacion a la fila tomandola de la variable con el valor del textBox
                    archivos.Rows.Add(row); //se van añadiendo las filas con los datos introducidos
                    frmDetallesParticiones.RefrescarDatos(particion);//-- Actualñiza el campo grafico
                }
                else//-- en caso de que el archivo no quepa
                {
                    MessageBox.Show("No hay suficiente espacio\npara añadir mas archivos");

                }

                txtNombreAr.Text = ""; //se limpian el textbox
                txtTamañoAr.Text = ""; //se limpia el textbox
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvArchivos.CurrentRow != null)//-- Verificamos que si haya filas
            {
                nombreArch = dgvArchivos.Rows[dgvArchivos.CurrentRow.Index].Cells[0].Value.ToString();//Se obtiene el nombre del archivo
                particion.EliminarArchivo(nombreArch);//Se elimina el archivo de la particion
                dgvArchivos.Rows.Remove(dgvArchivos.CurrentRow);//borra el archivo selecionado en el datagrid
                frmDetallesParticiones.RefrescarDatos(particion);//-- Actualñiza el campo grafico
            }
        }

        private void txtNombreAr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 47 && e.KeyChar < 58) //valida que solo pueda introducir texto
            {
                e.Handled = true;//-- decimos que se controlo el evento
            }
        }

        private void txtTamañoAr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))//valida que solo pueda introducir numeros
            {
                e.Handled = true;//-- Decimos que si se controlo el evento
            }
        }
    }
}
