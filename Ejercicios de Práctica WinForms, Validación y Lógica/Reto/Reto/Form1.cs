using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.IO;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        private const string ARCHIVO = "estudiantes.csv";

        public Form1()
        {
            InitializeComponent();
            CargarListas();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del alumno");
                return;
            }

            if (txtNotas.Text == "")
            {
                MessageBox.Show("Ingrese la nota del alumno");
                return;
            }

            double nota;
            if (!double.TryParse(txtNotas.Text, out nota))
            {
                MessageBox.Show("Ingrese una nota válida");
                return;
            }

            if (nota < 0 || nota > 5)
            {
                MessageBox.Show("La nota debe estar entre 0.0 y 5.0");
                return;
            }

            File.AppendAllText(ARCHIVO, txtNombre.Text + "," + nota + "\r\n");

            txtNombre.Text = "";
            txtNotas.Text = "";

            CargarListas();

            MessageBox.Show("Estudiante guardado correctamente");
        }

        private void CargarListas()
        {
            lstAprobados.Items.Clear();
            lstDesaprobados.Items.Clear();

            if (!File.Exists(ARCHIVO))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(ARCHIVO);

            foreach (string linea in lineas)
            {
                if (linea == "") continue;

                string[] datos = linea.Split(',');
                string nombre = datos[0];
                double nota = double.Parse(datos[1]);

                if (nota >= 3.0)
                {
                    lstAprobados.Items.Add(nombre + " - " + nota);
                }
                else
                {
                    lstDesaprobados.Items.Add(nombre + " - " + nota);
                }
            }

            lblAprobados.Text = "Aprobados (>= 3.0) - Total: " + lstAprobados.Items.Count;
            lblDesaprobados.Text = "Desaprobados (< 3.0) - Total: " + lstDesaprobados.Items.Count;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btGuardar.PerformClick();
            }
        }

        private void txtNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btGuardar.PerformClick();
            }
        }
    }
}