using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace Logica_de_negocios
{
    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }
}