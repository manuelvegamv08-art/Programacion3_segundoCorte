using Inventario_ESBAM.models;
using System.Collections.Generic;

namespace Inventario_ESBAM.controllers
{
    internal class ProductoController
    {
        private InventarioDeProductos inventario = new InventarioDeProductos();

        public List<Producto> Listar()
        {
            return inventario.Listar();
        }

        public void Crear(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            Producto p = new Producto
            {
                id = id,
                nombreDeProducto = nombre,
                descripcionDeProducto = descripcion,
                precio = precio,
                cantidad = cantidad,
                ventasDelproductoRealizadas = 0
            };

            inventario.Crear(p);
        }

        public void Eliminar(int id)
        {
            inventario.Eliminar(id);
        }

        public void Vender(int id, int cantidad)
        {
            Producto p = new Producto();
            p.Vender(id, cantidad);
        }
    }
}