using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario_ESBAM.vista
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        //Evento del botn enviar dell inventario al dataInventari
        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataInventario.Rows.Add(txtId,txtNombre,txtDescripcion,txtCantidad,numPrecio);
        }
    }
}
