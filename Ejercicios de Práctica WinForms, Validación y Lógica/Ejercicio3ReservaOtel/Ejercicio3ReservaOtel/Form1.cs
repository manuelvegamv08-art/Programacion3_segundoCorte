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

            // 🔹 Validación de fechas
            if (dtpSalida.Value <= dtpEntrada.Value)
            {
                MessageBox.Show("La fecha de salida debe ser mayor a la fecha de entrada");
                return;
            }

            //  Calcular días
            int totalDias = (int)(dtpSalida.Value - dtpEntrada.Value).TotalDays;

            //  Calcular valor por día
            int valorDia = (int)(numPersonas.Value * numValorPersona.Value);

            //  Calcular total
            int total = totalDias * valorDia;

            // Mostrar total en label
            lblValorTotal.Text = total.ToString("C");

            //  MEJOR PRESENTACIÓN DEL RESUMEN
            rtbResumen.Clear();

            // Título centrado
            

            // Volver a la izquierda
            rtbResumen.SelectionAlignment = HorizontalAlignment.Left;
            rtbResumen.SelectionFont = new Font("Consolas", 10, FontStyle.Regular);

            // Contenido organizado
            rtbResumen.AppendText($"Fecha de entrada : {dtpEntrada.Value.ToShortDateString()}\n");
            rtbResumen.AppendText($"Fecha de salida  : {dtpSalida.Value.ToShortDateString()}\n");
            rtbResumen.AppendText($"Total de días    : {totalDias}\n");
            rtbResumen.AppendText($"Personas         : {numPersonas.Value}\n");
            rtbResumen.AppendText($"Valor por persona: {numValorPersona.Value:C}\n");
            rtbResumen.AppendText("-----------------------------------\n");
            rtbResumen.AppendText($"TOTAL A PAGAR    : {total:C}\n");


        }
    }
}
