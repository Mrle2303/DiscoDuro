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
        public FrmDetallesArchivos(Particiones particion)
        {
            InitializeComponent();
            this.particion = particion;
            archivos = new DataTable(); //se crea el objeto para manejar el datagridview
            archivos.Columns.Add("Nombre del archivo"); //mediante el objeto se le añade columna al datagridview
            archivos.Columns.Add("Tamaño del archivo"); //mediante el objeto se le añade columna al datagridview

            dgvArchivos.DataSource=archivos;  //le mandamos al datagridview la informacion de las columnas 
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DataRow row = archivos.NewRow(); //se crea el objeto row para que agregue filas
            nombreArch = txtNombreAr.Text;
            tamanioArch = int.Parse(txtTamañoAr.Text);
            Archivos archivo = new Archivos(nombreArch, tamanioArch);
            if(archivo.Tamanio < particion.TamanioDisponible)
            {
                particion.AgregarArchivo(archivo);
                row["Nombre del archivo"] = nombreArch;//le establece la informacion a la fila tomandola de la variable con el valor del textBox
                row["Tamaño del archivo"] = tamanioArch;//le establece la informacion a la fila tomandola de la variable con el valor del textBox
                archivos.Rows.Add(row); //se van añadiendo las filas con los datos introducidos
            }
          
            txtNombreAr.Text = ""; //se limpian el textbox
            txtTamañoAr.Text = ""; //se limpia el textbox
        }

        
    }
}
