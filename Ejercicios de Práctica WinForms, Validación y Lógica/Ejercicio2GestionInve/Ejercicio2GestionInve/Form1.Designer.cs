namespace Ejercicio2GestionInve
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numStockInicial = new System.Windows.Forms.NumericUpDown();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.groupIVA = new System.Windows.Forms.GroupBox();
            this.rbExento = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbReducido = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.groupIVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(41, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(41, 91);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(198, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Electrónica",
            "Alimentos",
            "Ropa"});
            this.cmbCategoria.Location = new System.Drawing.Point(380, 36);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categorias";
            // 
            // numStockInicial
            // 
            this.numStockInicial.Location = new System.Drawing.Point(380, 64);
            this.numStockInicial.Name = "numStockInicial";
            this.numStockInicial.Size = new System.Drawing.Size(120, 20);
            this.numStockInicial.TabIndex = 6;
            // 
            // numStockMinimo
            // 
            this.numStockMinimo.Location = new System.Drawing.Point(380, 91);
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(120, 20);
            this.numStockMinimo.TabIndex = 7;
            // 
            // groupIVA
            // 
            this.groupIVA.Controls.Add(this.chkEsPerecedero);
            this.groupIVA.Controls.Add(this.rbReducido);
            this.groupIVA.Controls.Add(this.rbGeneral);
            this.groupIVA.Controls.Add(this.rbExento);
            this.groupIVA.Location = new System.Drawing.Point(56, 198);
            this.groupIVA.Name = "groupIVA";
            this.groupIVA.Size = new System.Drawing.Size(183, 100);
            this.groupIVA.TabIndex = 8;
            this.groupIVA.TabStop = false;
            this.groupIVA.Text = "Iva";
            // 
            // rbExento
            // 
            this.rbExento.AutoSize = true;
            this.rbExento.Location = new System.Drawing.Point(6, 19);
            this.rbExento.Name = "rbExento";
            this.rbExento.Size = new System.Drawing.Size(39, 17);
            this.rbExento.TabIndex = 0;
            this.rbExento.TabStop = true;
            this.rbExento.Text = "0%";
            this.rbExento.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(6, 42);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(45, 17);
            this.rbGeneral.TabIndex = 1;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "19%";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbReducido
            // 
            this.rbReducido.AutoSize = true;
            this.rbReducido.Location = new System.Drawing.Point(6, 65);
            this.rbReducido.Name = "rbReducido";
            this.rbReducido.Size = new System.Drawing.Size(39, 17);
            this.rbReducido.TabIndex = 2;
            this.rbReducido.TabStop = true;
            this.rbReducido.Text = "5%";
            this.rbReducido.UseVisualStyleBackColor = true;
            // 
            // chkEsPerecedero
            // 
            this.chkEsPerecedero.AutoSize = true;
            this.chkEsPerecedero.Location = new System.Drawing.Point(74, 42);
            this.chkEsPerecedero.Name = "chkEsPerecedero";
            this.chkEsPerecedero.Size = new System.Drawing.Size(107, 17);
            this.chkEsPerecedero.TabIndex = 3;
            this.chkEsPerecedero.Text = "¿Es perecedero?";
            this.chkEsPerecedero.UseVisualStyleBackColor = true;
            this.chkEsPerecedero.CheckedChanged += new System.EventHandler(this.chkEsPerecedero_CheckedChanged);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(153, 145);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(295, 234);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.groupIVA);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.numStockInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.groupIVA.ResumeLayout(false);
            this.groupIVA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numStockInicial;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.GroupBox groupIVA;
        private System.Windows.Forms.RadioButton rbReducido;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbExento;
        private System.Windows.Forms.CheckBox chkEsPerecedero;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

