using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using parcial_2.Modelo;

namespace parcial_2
{
    public partial class Form1 : Form
    {
        private BindingList<Producto> listaProductos;
        private Producto modeloProducto = new Producto();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            
            var datosExistentes = modeloProducto.Listar();
            listaProductos = new BindingList<Producto>(datosExistentes);

            
            dataGridView1.DataSource = listaProductos;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nom = txtNombre.Text;
            string cat = txtCantidad.Text;
            string mar = txtMarca.Text;
            int pre = int.Parse(numPrecio.Text);
            int stk = int.Parse(txtStock.Text);
            string prov = txtProveedor.Text;

            Producto nuevo = new Producto();

            nuevo.Crear(id, nom, cat, mar, pre, stk, prov);


            listaProductos.Add(nuevo);

            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtId.Clear(); txtNombre.Clear(); 
        }
    }
}
