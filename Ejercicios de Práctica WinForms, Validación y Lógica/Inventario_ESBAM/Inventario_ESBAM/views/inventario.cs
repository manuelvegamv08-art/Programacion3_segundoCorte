using Inventario_ESBAM.controllers;
using Inventario_ESBAM.models;
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
    public partial class inventario : Form
    {
        ProductoController controller = new ProductoController();

        public inventario()
        {
            InitializeComponent();
            this.Load += new EventHandler(inventario_Load);
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario cargado");
            CargarProductos();
        }

        //  MÉTODO PARA LLENAR EL DATAGRIDVIEW
        public void CargarProductos()
        {
            Producto modelo = new Producto();
            var lista = modelo.Listar();

            dataGridView1.AutoGenerateColumns = false; 

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;

            //  SUMAR CANTIDAD TOTAL
            int total = lista.Sum(p => p.cantidad);
            int totalProductos = lista.Count;
            double totalDinero = lista.Sum(p => p.precio * p.cantidad);

            label2.Text = "Cantidad total: " + total;
            label4.Text = "Total productos: " + totalProductos;
            label5.Text = "Total dinero $" + totalDinero;

            // MAPEO DE COLUMNAS
            dataGridView1.Columns["id"].DataPropertyName = "id";
            dataGridView1.Columns["nombreDeProducto"].DataPropertyName = "nombreDeProducto";
            dataGridView1.Columns["descripcionDeProducto"].DataPropertyName = "descripcionDeProducto";
            dataGridView1.Columns["precio"].DataPropertyName = "precio";
            dataGridView1.Columns["cantidad"].DataPropertyName = "cantidad";
            dataGridView1.Columns["ventasDelproductoRealizadas"].DataPropertyName = "ventasDelproductoRealizadas";
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
           
        }

        internal void CargarDatos()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                DialogResult confirmacion = MessageBox.Show(
                    "¿Seguro que deseas eliminar este producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    controller.Eliminar(id);

                    CargarProductos(); //  refresca la tabla
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }

        }
    }
}