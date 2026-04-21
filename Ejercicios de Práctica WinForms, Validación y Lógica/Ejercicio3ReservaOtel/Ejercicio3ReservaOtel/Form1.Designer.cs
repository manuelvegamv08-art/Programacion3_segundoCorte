namespace Ejercicio3ReservaOtel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.Label();
            this.errorProvider3 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.numValorPersona = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numValorPersona);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.errorProvider3);
            this.groupBox1.Controls.Add(this.errorProvider2);
            this.groupBox1.Controls.Add(this.errorProvider1);
            this.groupBox1.Controls.Add(this.btnCalcularReserva);
            this.groupBox1.Controls.Add(this.clbServicios);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpEntrada);
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numPersonas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos usuario";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(6, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(316, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(352, 44);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrada.TabIndex = 2;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(352, 93);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora de entrada del cliente ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora de salida del cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(6, 97);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 20);
            this.numPersonas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de personas";
            // 
            // clbServicios
            // 
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "WIFI Premiun",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(352, 146);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(126, 64);
            this.clbServicios.TabIndex = 4;
            // 
            // rtbResumen
            // 
            this.rtbResumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbResumen.Location = new System.Drawing.Point(0, 236);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(750, 214);
            this.rtbResumen.TabIndex = 6;
            this.rtbResumen.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor de la avitacion";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Location = new System.Drawing.Point(551, 165);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(165, 23);
            this.btnCalcularReserva.TabIndex = 6;
            this.btnCalcularReserva.Text = "Calcular la Reserva";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.AutoSize = true;
            this.errorProvider1.Location = new System.Drawing.Point(133, 103);
            this.errorProvider1.Name = "errorProvider1";
            this.errorProvider1.Size = new System.Drawing.Size(120, 13);
            this.errorProvider1.TabIndex = 7;
            this.errorProvider1.Text = "Error Campo obligatorio*";
            this.errorProvider1.Visible = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.AutoSize = true;
            this.errorProvider2.Location = new System.Drawing.Point(133, 153);
            this.errorProvider2.Name = "errorProvider2";
            this.errorProvider2.Size = new System.Drawing.Size(120, 13);
            this.errorProvider2.TabIndex = 8;
            this.errorProvider2.Text = "Error Campo obligatorio*";
            this.errorProvider2.Visible = false;
            // 
            // errorProvider3
            // 
            this.errorProvider3.AutoSize = true;
            this.errorProvider3.Location = new System.Drawing.Point(202, 31);
            this.errorProvider3.Name = "errorProvider3";
            this.errorProvider3.Size = new System.Drawing.Size(120, 13);
            this.errorProvider3.TabIndex = 9;
            this.errorProvider3.Text = "Error Campo obligatorio*";
            this.errorProvider3.Visible = false;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(12, 199);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(35, 13);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "label6";
            this.lblValorTotal.Visible = false;
            // 
            // numValorPersona
            // 
            this.numValorPersona.Location = new System.Drawing.Point(6, 151);
            this.numValorPersona.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numValorPersona.Name = "numValorPersona";
            this.numValorPersona.Size = new System.Drawing.Size(120, 20);
            this.numValorPersona.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(183, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "FACTURA DEL HOTEL LAS MARIANAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label errorProvider3;
        private System.Windows.Forms.Label errorProvider2;
        private System.Windows.Forms.Label errorProvider1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.NumericUpDown numValorPersona;
        private System.Windows.Forms.Label label6;
    }
}

