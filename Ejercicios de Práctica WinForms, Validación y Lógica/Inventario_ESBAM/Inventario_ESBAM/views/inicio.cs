using Inventario_ESBAM.views;
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


namespace Inventario_ESBAM
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            this.Load += new EventHandler(inicio_Load);
        }

        private void CargarResumen()
        {
            ProductoController controller = new ProductoController();
            var lista = controller.Listar();

            int totalProductos = lista.Count;

            lblProductosRegistrados.Text = "Productos registrados: " + totalProductos;
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            CargarResumen();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var inventarioForm = new inventario();
            inventarioForm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProducto form = new agregarProducto(this);
            form.ShowDialog();  

            CargarResumen();    
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            var informe = new informacion();
            informe.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var RealizarVenta = new RealizarVenta(this);
            RealizarVenta.ShowDialog();

        }
    }
}
