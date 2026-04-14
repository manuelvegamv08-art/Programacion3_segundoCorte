namespace Reto_intentoDos
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
            this.txtNuevoRegistro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texNotas = new System.Windows.Forms.TextBox();
            this.texAprovados = new System.Windows.Forms.GroupBox();
            this.texReprobado = new System.Windows.Forms.GroupBox();
            this.tbnGuardarNotas = new System.Windows.Forms.Button();
            this.listAprobados = new System.Windows.Forms.ListBox();
            this.listDesaprobados = new System.Windows.Forms.ListBox();
            this.txtNuevoRegistro.SuspendLayout();
            this.texAprovados.SuspendLayout();
            this.texReprobado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNuevoRegistro
            // 
            this.txtNuevoRegistro.Controls.Add(this.tbnGuardarNotas);
            this.txtNuevoRegistro.Controls.Add(this.texNotas);
            this.txtNuevoRegistro.Controls.Add(this.texNombre);
            this.txtNuevoRegistro.Controls.Add(this.label2);
            this.txtNuevoRegistro.Controls.Add(this.label1);
            this.txtNuevoRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNuevoRegistro.Location = new System.Drawing.Point(0, 0);
            this.txtNuevoRegistro.Name = "txtNuevoRegistro";
            this.txtNuevoRegistro.Size = new System.Drawing.Size(656, 184);
            this.txtNuevoRegistro.TabIndex = 0;
            this.txtNuevoRegistro.TabStop = false;
            this.txtNuevoRegistro.Text = "Nuevo Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notas (0.0 - 5.0)";
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(6, 68);
            this.texNombre.Multiline = true;
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(270, 20);
            this.texNombre.TabIndex = 2;
            // 
            // texNotas
            // 
            this.texNotas.Location = new System.Drawing.Point(365, 68);
            this.texNotas.Name = "texNotas";
            this.texNotas.Size = new System.Drawing.Size(160, 20);
            this.texNotas.TabIndex = 3;
            // 
            // texAprovados
            // 
            this.texAprovados.Controls.Add(this.listAprobados);
            this.texAprovados.Dock = System.Windows.Forms.DockStyle.Left;
            this.texAprovados.Location = new System.Drawing.Point(0, 184);
            this.texAprovados.Name = "texAprovados";
            this.texAprovados.Size = new System.Drawing.Size(312, 266);
            this.texAprovados.TabIndex = 1;
            this.texAprovados.TabStop = false;
            this.texAprovados.Text = "Aprobados (>= 3.0)";
            // 
            // texReprobado
            // 
            this.texReprobado.Controls.Add(this.listDesaprobados);
            this.texReprobado.Dock = System.Windows.Forms.DockStyle.Right;
            this.texReprobado.Location = new System.Drawing.Point(318, 184);
            this.texReprobado.Name = "texReprobado";
            this.texReprobado.Size = new System.Drawing.Size(338, 266);
            this.texReprobado.TabIndex = 2;
            this.texReprobado.TabStop = false;
            this.texReprobado.Text = "Desaprobados (< 3.0)";
            // 
            // tbnGuardarNotas
            // 
            this.tbnGuardarNotas.Location = new System.Drawing.Point(365, 130);
            this.tbnGuardarNotas.Name = "tbnGuardarNotas";
            this.tbnGuardarNotas.Size = new System.Drawing.Size(160, 36);
            this.tbnGuardarNotas.TabIndex = 4;
            this.tbnGuardarNotas.Text = "Guardar Registro";
            this.tbnGuardarNotas.UseVisualStyleBackColor = true;
            this.tbnGuardarNotas.Click += new System.EventHandler(this.tbnGuardarNotas_Click);
            // 
            // listAprobados
            // 
            this.listAprobados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAprobados.FormattingEnabled = true;
            this.listAprobados.Location = new System.Drawing.Point(3, 16);
            this.listAprobados.Name = "listAprobados";
            this.listAprobados.Size = new System.Drawing.Size(306, 247);
            this.listAprobados.TabIndex = 0;
            // 
            // listDesaprobados
            // 
            this.listDesaprobados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDesaprobados.FormattingEnabled = true;
            this.listDesaprobados.Location = new System.Drawing.Point(3, 16);
            this.listDesaprobados.Name = "listDesaprobados";
            this.listDesaprobados.Size = new System.Drawing.Size(332, 247);
            this.listDesaprobados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.texReprobado);
            this.Controls.Add(this.texAprovados);
            this.Controls.Add(this.txtNuevoRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txtNuevoRegistro.ResumeLayout(false);
            this.txtNuevoRegistro.PerformLayout();
            this.texAprovados.ResumeLayout(false);
            this.texReprobado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtNuevoRegistro;
        private System.Windows.Forms.TextBox texNotas;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox texAprovados;
        private System.Windows.Forms.GroupBox texReprobado;
        private System.Windows.Forms.Button tbnGuardarNotas;
        private System.Windows.Forms.ListBox listAprobados;
        private System.Windows.Forms.ListBox listDesaprobados;
    }
}

