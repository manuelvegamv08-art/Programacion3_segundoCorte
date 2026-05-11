using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Inventario_ESBAM.models
{
    internal class Producto
    {
        private static readonly string RUTA = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "db", "productos.csv"
        );

        public int id { get; set; }
        public string nombreDeProducto { get; set; }
        public string descripcionDeProducto { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public int ventasDelproductoRealizadas { get; set; }

        public Producto() { }

        //  CREAR
        public void Crear(int id, string nombreDeProducto, string descripcionDeProducto,
                          double precio, int cantidad, int ventasDelproductoRealizadas)
        {
            this.id = id;
            this.nombreDeProducto = nombreDeProducto;
            this.descripcionDeProducto = descripcionDeProducto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.ventasDelproductoRealizadas = ventasDelproductoRealizadas;

            string linea = $"{id},{nombreDeProducto},{descripcionDeProducto},{precio},{cantidad},{ventasDelproductoRealizadas}";

            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);
        }

        //  LISTAR
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');

                    if (datos.Length == 6)
                    {
                        Producto producto = new Producto
                        {
                            id = int.Parse(datos[0]),
                            nombreDeProducto = datos[1],
                            descripcionDeProducto = datos[2],
                            precio = double.Parse(datos[3]),
                            cantidad = int.Parse(datos[4]), 
                            ventasDelproductoRealizadas = int.Parse(datos[5])
                        };

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

        //  ELIMINAR
        public void Eliminar(int id)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                var lineasActualizadas = lineas
                    .Where(linea => linea.Split(',')[0] != id.ToString())
                    .ToArray();

                File.WriteAllLines(RUTA, lineasActualizadas);
            }
        }

        //  ACTUALIZAR
        public void Actualizar(int id, string nombreDeProducto, string descripcionDeProducto,
                               double precio, int cantidad, int ventasDelproductoRealizadas)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                for (int i = 0; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');

                    if (datos.Length == 6 && int.Parse(datos[0]) == id)
                    {
                        lineas[i] = $"{id},{nombreDeProducto},{descripcionDeProducto},{precio},{cantidad},{ventasDelproductoRealizadas}";
                        break;
                    }
                }

                File.WriteAllLines(RUTA, lineas);
            }
        }

        //  BUSCAR
        public Producto Buscar(int id)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');

                    if (datos.Length == 6 && int.Parse(datos[0]) == id)
                    {
                        return new Producto
                        {
                            id = int.Parse(datos[0]),
                            nombreDeProducto = datos[1],
                            descripcionDeProducto = datos[2],
                            precio = double.Parse(datos[3]),
                            cantidad = int.Parse(datos[4]),
                            ventasDelproductoRealizadas = int.Parse(datos[5])
                        };
                    }
                }
            }

            return null;
        }

        public void Vender(int id, int cantidadVendida)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                for (int i = 0; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');

                    if (datos.Length == 6 && int.Parse(datos[0]) == id)
                    {
                        int cantidadActual = int.Parse(datos[4]);
                        int ventasActuales = int.Parse(datos[5]);

                        if (cantidadVendida > cantidadActual)
                        {
                            MessageBox.Show("No hay suficiente stock");
                            return;
                        }

                        int nuevaCantidad = cantidadActual - cantidadVendida;
                        int nuevasVentas = ventasActuales + cantidadVendida;

                        lineas[i] = $"{datos[0]},{datos[1]},{datos[2]},{datos[3]},{nuevaCantidad},{nuevasVentas}";
                        break;
                    }
                }

                File.WriteAllLines(RUTA, lineas);
            }
        }
    }
}