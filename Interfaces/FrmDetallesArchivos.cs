using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class FrmDetallesArchivos : Form
    {
        
        private DataTable archivos;

        public FrmDetallesArchivos()
        {
            InitializeComponent();
            archivos = new DataTable();

            archivos.Columns.Add("Nombre del archivo");
            archivos.Columns.Add("Tamaño del archivo");

            dgvArchivos.DataSource=archivos;   
        }

        

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DataRow row = archivos.NewRow();

            row["Nombre del archivo"] = txtNombreAr.Text;
            row["Tamaño del archivo"] = txtTamañoAr.Text;

            archivos.Rows.Add(row);

            txtNombreAr.Text = "";
            txtTamañoAr.Text = "";
        }

        
    }
}
