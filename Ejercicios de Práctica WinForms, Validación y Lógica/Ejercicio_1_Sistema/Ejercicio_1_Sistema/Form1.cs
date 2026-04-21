using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (txtNombres.Text == "" || txtApellidos.Text == "" ||
                txtEmail.Text == "" || txtIdentificacion.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // Validar correo
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, patronEmail))
            {
                MessageBox.Show("Correo inválido");
                return;
            }

            // Validar identificación
            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                MessageBox.Show("La identificación debe tener exactamente 10 dígitos");
                return;
            }

            // Calcular sueldo
            decimal sueldoBase = numSueldoBase.Value;
            decimal sueldoNeto = sueldoBase - (sueldoBase * 0.10m);

            // Mostrar resultado
            lblResultadoSueldo.Text = "Sueldo Neto: " + sueldoNeto.ToString("C");

            MessageBox.Show("Empleado registrado correctamente");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
