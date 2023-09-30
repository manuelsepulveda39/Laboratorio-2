namespace Laboratorio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxRectaUno = new System.Windows.Forms.TextBox();
            this.TextBoxRectaDos = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.erroresUno = new System.Windows.Forms.Label();
            this.erroresDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recta 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recta 2";
            // 
            // TextBoxRectaUno
            // 
            this.TextBoxRectaUno.Location = new System.Drawing.Point(21, 116);
            this.TextBoxRectaUno.Name = "TextBoxRectaUno";
            this.TextBoxRectaUno.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectaUno.TabIndex = 2;
            // 
            // TextBoxRectaDos
            // 
            this.TextBoxRectaDos.Location = new System.Drawing.Point(201, 116);
            this.TextBoxRectaDos.Name = "TextBoxRectaDos";
            this.TextBoxRectaDos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectaDos.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcular.Location = new System.Drawing.Point(121, 208);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // erroresUno
            // 
            this.erroresUno.AutoSize = true;
            this.erroresUno.Location = new System.Drawing.Point(18, 167);
            this.erroresUno.Name = "erroresUno";
            this.erroresUno.Size = new System.Drawing.Size(35, 13);
            this.erroresUno.TabIndex = 5;
            this.erroresUno.Text = "label3";
            this.erroresUno.Visible = false;
            // 
            // erroresDos
            // 
            this.erroresDos.AutoSize = true;
            this.erroresDos.Location = new System.Drawing.Point(198, 167);
            this.erroresDos.Name = "erroresDos";
            this.erroresDos.Size = new System.Drawing.Size(35, 13);
            this.erroresDos.TabIndex = 6;
            this.erroresDos.Text = "label3";
            this.erroresDos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(329, 367);
            this.Controls.Add(this.erroresDos);
            this.Controls.Add(this.erroresUno);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.TextBoxRectaDos);
            this.Controls.Add(this.TextBoxRectaUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Intercepto entre rectas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxRectaUno;
        private System.Windows.Forms.TextBox TextBoxRectaDos;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label erroresUno;
        private System.Windows.Forms.Label erroresDos;
    }
}

