namespace Ejercicio_4_TecladoCalculadora
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borrar = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Seiz = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Sinco = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 35);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrar);
            this.groupBox1.Controls.Add(this.Division);
            this.groupBox1.Controls.Add(this.Multiplicar);
            this.groupBox1.Controls.Add(this.Igual);
            this.groupBox1.Controls.Add(this.Suma);
            this.groupBox1.Controls.Add(this.Cero);
            this.groupBox1.Controls.Add(this.Seiz);
            this.groupBox1.Controls.Add(this.Ocho);
            this.groupBox1.Controls.Add(this.Tres);
            this.groupBox1.Controls.Add(this.Siete);
            this.groupBox1.Controls.Add(this.Sinco);
            this.groupBox1.Controls.Add(this.Cuatro);
            this.groupBox1.Controls.Add(this.Nueve);
            this.groupBox1.Controls.Add(this.Dos);
            this.groupBox1.Controls.Add(this.Uno);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.borrar.Location = new System.Drawing.Point(106, 47);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(25, 23);
            this.borrar.TabIndex = 14;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.button15_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Division.Location = new System.Drawing.Point(106, 77);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(25, 23);
            this.Division.TabIndex = 13;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(106, 106);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(25, 23);
            this.Multiplicar.TabIndex = 12;
            this.Multiplicar.Text = "*";
            this.Multiplicar.UseVisualStyleBackColor = false;
            // 
            // Igual
            // 
            this.Igual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Igual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(106, 134);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(35, 23);
            this.Igual.TabIndex = 11;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(75, 134);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(24, 23);
            this.Suma.TabIndex = 10;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = false;
            // 
            // Cero
            // 
            this.Cero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cero.Location = new System.Drawing.Point(7, 135);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(57, 23);
            this.Cero.TabIndex = 9;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = false;
            // 
            // Seiz
            // 
            this.Seiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Seiz.Location = new System.Drawing.Point(75, 77);
            this.Seiz.Name = "Seiz";
            this.Seiz.Size = new System.Drawing.Size(24, 23);
            this.Seiz.TabIndex = 8;
            this.Seiz.Text = "6";
            this.Seiz.UseVisualStyleBackColor = false;
            // 
            // Ocho
            // 
            this.Ocho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ocho.Location = new System.Drawing.Point(42, 106);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(24, 23);
            this.Ocho.TabIndex = 7;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = false;
            // 
            // Tres
            // 
            this.Tres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tres.Location = new System.Drawing.Point(75, 48);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(23, 23);
            this.Tres.TabIndex = 6;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = false;
            this.Tres.Click += new System.EventHandler(this.button7_Click);
            // 
            // Siete
            // 
            this.Siete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Siete.Location = new System.Drawing.Point(7, 106);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(23, 23);
            this.Siete.TabIndex = 5;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = false;
            // 
            // Sinco
            // 
            this.Sinco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sinco.Location = new System.Drawing.Point(42, 77);
            this.Sinco.Name = "Sinco";
            this.Sinco.Size = new System.Drawing.Size(22, 23);
            this.Sinco.TabIndex = 4;
            this.Sinco.Text = "5";
            this.Sinco.UseVisualStyleBackColor = false;
            this.Sinco.Click += new System.EventHandler(this.button5_Click);
            // 
            // Cuatro
            // 
            this.Cuatro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cuatro.Location = new System.Drawing.Point(7, 77);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(23, 23);
            this.Cuatro.TabIndex = 3;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = false;
            // 
            // Nueve
            // 
            this.Nueve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nueve.Location = new System.Drawing.Point(75, 106);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(23, 23);
            this.Nueve.TabIndex = 2;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = false;
            // 
            // Dos
            // 
            this.Dos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dos.Location = new System.Drawing.Point(42, 48);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(22, 23);
            this.Dos.TabIndex = 1;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = false;
            // 
            // Uno
            // 
            this.Uno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Uno.Location = new System.Drawing.Point(7, 48);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(23, 23);
            this.Uno.TabIndex = 0;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Seiz;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Sinco;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button Division;
    }
}

