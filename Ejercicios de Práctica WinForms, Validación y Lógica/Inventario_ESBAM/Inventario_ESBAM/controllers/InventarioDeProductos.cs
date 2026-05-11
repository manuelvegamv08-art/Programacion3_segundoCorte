using Inventario_ESBAM.models;
using System;
using System.Collections.Generic;

namespace Inventario_ESBAM.controllers
{
    internal class InventarioDeProductos
    {
        internal void Crear(Producto p)
        {
            // Delegar a la lógica de persistencia del modelo
            p.Crear(p.id, p.nombreDeProducto, p.descripcionDeProducto, p.precio, p.cantidad, p.ventasDelproductoRealizadas);
        }

        internal void Eliminar(int id)
        {
            var modelo = new Producto();
            modelo.Eliminar(id);
        }

        internal List<Producto> Listar()
        {
            var modelo = new Producto();
            return modelo.Listar();
        }
    }
}