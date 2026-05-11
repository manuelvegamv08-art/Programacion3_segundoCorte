using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Inventario_ESBAM.controllers;

namespace Inventario_ESBAM
{
    public partial class agregarProducto : Form
    {
        //  referencia al formulario inventario
        public inventario formInventario;

        public agregarProducto(inicio inicio)
        {
            InitializeComponent();
        }

        public agregarProducto(inventario form)
        {
            InitializeComponent();
            formInventario = form; // 🔥 AQUÍ SE ASIGNA
        }
        public void btnCargarDato_Click(object sender, EventArgs e)
        {



            ProductoController productoController = new ProductoController();

            MessageBox.Show("Click funcionando");




            try
            {
                


                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                double precio = double.Parse(numPrecio.Text);
                int cantidad = int.Parse(numCantidad.Text);




                productoController.Crear(id, nombre, descripcion, precio, cantidad);

                MessageBox.Show("Producto agregado exitosamente.");
                MessageBox.Show(formInventario == null ? "ES NULL" : "NO ES NULL");
                //  ACTUALIZA EL DATAGRIDVIEW AUTOMÁTICAMENTE
                if (formInventario != null)
                {
                    // CargarProductos es private en la clase inventario; usar el método accesible disponible
                    // (según los tipos proporcionados existe internal void CargarDatos())
                    formInventario.CargarDatos();
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese datos válidos.");
            }



        }
    }
}