using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3ReservaOtel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            // Limpiar errores
            errorProvider1.Visible = false;
            errorProvider2.Visible = false;
            errorProvider3.Visible = false;

            // VALIDACIONES

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                errorProvider3.Text = "Campo obligatorio";
                errorProvider3.Visible = true;
                return;
            }

            if (numPersonas.Value <= 0)
            {
                errorProvider2.Text = "Ingrese al menos 1 persona";
                errorProvider2.Visible = true;
                return;
            }

            if (numValorPersona.Value <= 0)
            {
                errorProvider1.Text = "Ingrese un valor válido";
                errorProvider1.Visible = true;
                return;
            }

            if (dtpSalida.Value <= dtpEntrada.Value)
            {
                MessageBox.Show("La fecha de salida debe ser mayor que la entrada");
                return;
            }

            // VALIDAR CAPACIDAD
            if (numPersonas.Value > 4)
            {
                rtbResumen.Text = " Excede la capacidad del cuarto\n";
                rtbResumen.Text += "Máximo 4 personas\n";
                return;
            }

            // CÁLCULOS
            int totalDias = (int)(dtpSalida.Value - dtpEntrada.Value).TotalDays;
            if (totalDias <= 0) totalDias = 1;

            decimal valorDia = numPersonas.Value * numValorPersona.Value;

            //  SERVICIOS OPCIONALES
            decimal costoServicios = 0;
            string serviciosSeleccionados = "";

            foreach (var item in clbServicios.CheckedItems)
            {
                string servicio = item.ToString();
                serviciosSeleccionados += "- " + servicio + "\n";

                switch (servicio)
                {
                    case "WIFI Premium":
                        costoServicios += 10000;
                        break;

                    case "Desayuno Buffet":
                        costoServicios += 20000;
                        break;

                    case "Estacionamiento":
                        costoServicios += 15000;
                        break;

                    case "Spa":
                        costoServicios += 50000;
                        break;

                    default:
                        costoServicios += 10000;
                        break;
                }
            }

            decimal total = (totalDias * valorDia) + costoServicios;

            lblValorTotal.Text = total.ToString("C");

            // RESUMEN

            rtbResumen.Text = "📄 RESUMEN DE LA RESERVA\n\n";
            rtbResumen.Text += "Cliente: " + txtCliente.Text + "\n";
            rtbResumen.Text += "Personas: " + numPersonas.Value + "\n";
            rtbResumen.Text += "Entrada: " + dtpEntrada.Value.ToShortDateString() + "\n";
            rtbResumen.Text += "Salida: " + dtpSalida.Value.ToShortDateString() + "\n";
            rtbResumen.Text += "Días: " + totalDias + "\n";

            rtbResumen.Text += "\nServicios seleccionados:\n";

            if (serviciosSeleccionados == "")
            {
                rtbResumen.Text += "Ninguno\n";
            }
            else
            {
                rtbResumen.Text += serviciosSeleccionados;
            }

            rtbResumen.Text += "Costo servicios: " + costoServicios.ToString("C") + "\n";
            rtbResumen.Text += "---------------------------------\n";
            rtbResumen.Text += "TOTAL A PAGAR: " + total.ToString("C") + "\n";
        }

        private void errorProvider3_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Visible = false;
        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}