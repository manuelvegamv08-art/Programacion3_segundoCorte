using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parcial_2.Modelo
{
    internal class Producto
    {
        private static readonly string RUTA = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "db", "productos.csv"
        );

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { set; get; }
        public string Marca { set; get; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }

        public void Crear(int Id, string Nombre, string Categoria, string Marca, int Precio, int Stock, string Proveedor){

            this.Id = Id;
            this.Nombre = Nombre;
            this.Categoria = Categoria;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Proveedor = Proveedor;

            string linea = $"{Id},{Nombre},{Categoria},{Marca},{Precio},{Stock},{Proveedor}";

            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);

        }

        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');

                    if (datos.Length == 7)
                    {
                        Producto producto = new Producto
                        {
                            Id = int.Parse(datos[0]),
                            Nombre = datos[1],
                            Categoria = datos[2],
                            Marca = datos[3],
                            Precio = int.Parse(datos[4]),
                            Stock = int.Parse(datos[5]),
                            Proveedor = datos[6]
                        };

                        productos.Add(producto);
                    }
                }
            }

            return productos;
        }

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

        public void Actualizar(int Id, string Nombre, string Categoria,string Marca,
                               int Precio, int Stock, int Proveedor)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);

                for (int i = 0; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');

                    if (datos.Length == 7 && int.Parse(datos[0]) == Id)
                    {
                        lineas[i] = $"{Id},{Nombre},{Categoria},{Marca},{Precio},{Stock},{Proveedor}";
                        break;
                    }
                }

                File.WriteAllLines(RUTA, lineas);
            }
        }

    }
}
