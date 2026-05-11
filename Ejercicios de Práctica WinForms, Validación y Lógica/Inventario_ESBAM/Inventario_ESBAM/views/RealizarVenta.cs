using Inventario_ESBAM.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_ESBAM.views
{
    public partial class RealizarVenta : Form
    {
        private ProductoController controller = new ProductoController();
        private inicio inicio;

        public RealizarVenta(inventario inventarioForm)
        {
            InitializeComponent();
            
        }

        public RealizarVenta(inicio inicio)
        {
            this.inicio = inicio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(btnid.Text);
                int cantidad = (int)numericUpDown1.Value;

                ProductoController controller = new ProductoController();

                controller.Vender(id, cantidad);

                MessageBox.Show("Venta realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
