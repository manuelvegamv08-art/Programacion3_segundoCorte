namespace Inventario_ESBAM.views
{
    partial class RealizarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.lblmostrarNombre = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Inventario_ESBAM.Properties.Resources.fondo;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMAS DE VENTAS DEL SISTEMA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Inventario_ESBAM.Properties.Resources.fondo_medio;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.lblCantidadDisponible);
            this.groupBox2.Controls.Add(this.lblmostrarNombre);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnVenderProducto);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(45, 227);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 145);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnid
            // 
            this.btnid.Location = new System.Drawing.Point(45, 63);
            this.btnid.Name = "btnid";
            this.btnid.Size = new System.Drawing.Size(100, 20);
            this.btnid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BALOR QUE DEBE CANCELAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CANTIDAD DE PRODUCTO QUE DESEA COMPRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID DEL PRODUCTO QUE DESEA COMPRAR";
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(420, 215);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(171, 32);
            this.btnVenderProducto.TabIndex = 1;
            this.btnVenderProducto.Text = "VENDER PRODUCTO";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmostrarNombre
            // 
            this.lblmostrarNombre.AutoSize = true;
            this.lblmostrarNombre.Location = new System.Drawing.Point(420, 47);
            this.lblmostrarNombre.Name = "lblmostrarNombre";
            this.lblmostrarNombre.Size = new System.Drawing.Size(80, 13);
            this.lblmostrarNombre.TabIndex = 8;
            this.lblmostrarNombre.Text = "Mostrar nombre";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(420, 83);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(99, 13);
            this.lblCantidadDisponible.TabIndex = 9;
            this.lblCantidadDisponible.Text = "Cantidad disponible";
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RealizarVenta";
            this.Text = "RealizarVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVenderProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox btnid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.Label lblmostrarNombre;
    }
}