using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2GestionInve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar código
            if (!txtCodigo.Text.StartsWith("PROD-"))
            {
                MessageBox.Show("El código debe iniciar con PROD-");
                return;
            }

            // Validar stock
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                MessageBox.Show("El stock inicial no puede ser menor al stock mínimo");
                return;
            }

            // Validar IVA
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de IVA");
                return;
            }

            // Obtener IVA
            string iva = "";

            if (rbExento.Checked)
                iva = "0%";
            else if (rbGeneral.Checked)
                iva = "19%";
            else if (rbReducido.Checked)
                iva = "5%";

            // Mostrar resultado
            MessageBox.Show("Producto registrado correctamente\nIVA: " + iva);
        }
    }
}
