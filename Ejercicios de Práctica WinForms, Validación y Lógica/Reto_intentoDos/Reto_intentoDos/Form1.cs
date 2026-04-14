using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reto_intentoDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tbnGuardarNotas_Click(object sender, EventArgs e)
        {
            string archivo = "estudiantes.csv";

            string nombreEstudiante = texNombre.Text;
            double notaEstudiante;

            if (nombreEstudiante == "" || texNotas.Text == "")
            {
                MessageBox.Show("Complete los campos");
                return;
            }

            if (!double.TryParse(texNotas.Text, out notaEstudiante))
            {
                MessageBox.Show("Nota inválida");
                return;
            }

            // Guardar estudiante
            string lineaGuardar = nombreEstudiante + "," + notaEstudiante;
            File.AppendAllText(archivo, lineaGuardar + Environment.NewLine);

            listAprobados.Items.Clear();
            listDesaprobados.Items.Clear();

            // Leer archivo en lista
            List<string> lineasArchivo = File.ReadAllLines(archivo).ToList();

            for (int indice = 0; indice < lineasArchivo.Count; indice++)
            {
                string lineaArchivo = lineasArchivo[indice];

                string[] datosEstudiante = lineaArchivo.Split(',');

                string nombre = datosEstudiante[0];
                double nota = double.Parse(datosEstudiante[1]);

                if (nota >= 3.0)
                    listAprobados.Items.Add(nombre + " - " + nota);
                else
                    listDesaprobados.Items.Add(nombre + " - " + nota);
            }

            texNombre.Clear();
            texNotas.Clear();
        }



    }
}
