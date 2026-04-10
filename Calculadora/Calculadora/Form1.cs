using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //Numero 0
            tbDiplay.Text = tbDiplay.Text + "0";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Numero 9
            tbDiplay.Text = tbDiplay.Text + "9";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Numero 8
            tbDiplay.Text = tbDiplay.Text + "8";

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Numero 7
            tbDiplay.Text = tbDiplay.Text + "7";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Numero 6
            tbDiplay.Text = tbDiplay.Text + "6";
        }

        private void btnSinco_Click(object sender, EventArgs e)
        {
            //Numero 5
            tbDiplay.Text = tbDiplay.Text + "5";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Numero 4
            tbDiplay.Text = tbDiplay.Text + "4";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Numero 3
            tbDiplay.Text = tbDiplay.Text + "3";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Numero 2
            tbDiplay.Text = tbDiplay.Text + "2";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Numero 1
            tbDiplay.Text = tbDiplay.Text + "1";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //BOTON DE BORRAR
            tbDiplay.Text = "";
        }
    }
}
