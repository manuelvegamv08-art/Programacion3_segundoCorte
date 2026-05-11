using app_inventario_ESBAM.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario_ESBAM
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var InventarioForm = new Inventario();
            InventarioForm.ShowDialog();
        }
    }
}
