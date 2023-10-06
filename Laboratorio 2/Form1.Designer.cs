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
            this.errores = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.solucion = new System.Windows.Forms.Label();
            this.intercepto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recta 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recta 2";
            // 
            // TextBoxRectaUno
            // 
            this.TextBoxRectaUno.Location = new System.Drawing.Point(18, 86);
            this.TextBoxRectaUno.Name = "TextBoxRectaUno";
            this.TextBoxRectaUno.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectaUno.TabIndex = 2;
            // 
            // TextBoxRectaDos
            // 
            this.TextBoxRectaDos.Location = new System.Drawing.Point(154, 86);
            this.TextBoxRectaDos.Name = "TextBoxRectaDos";
            this.TextBoxRectaDos.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectaDos.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcular.Location = new System.Drawing.Point(92, 147);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 4;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // errores
            // 
            this.errores.AutoSize = true;
            this.errores.Location = new System.Drawing.Point(67, 120);
            this.errores.Name = "errores";
            this.errores.Size = new System.Drawing.Size(35, 13);
            this.errores.TabIndex = 5;
            this.errores.Text = "label3";
            this.errores.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "y-y1=m(x-x1)",
            "y=mx+b"});
            this.comboBox1.Location = new System.Drawing.Point(26, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "y=mx+b";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "y-y1=m(x-x1)",
            "y=mx+b"});
            this.comboBox2.Location = new System.Drawing.Point(162, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "y=mx+b";
            // 
            // solucion
            // 
            this.solucion.AutoSize = true;
            this.solucion.Location = new System.Drawing.Point(69, 188);
            this.solucion.Name = "solucion";
            this.solucion.Size = new System.Drawing.Size(35, 13);
            this.solucion.TabIndex = 9;
            this.solucion.Text = "label3";
            this.solucion.Visible = false;
            // 
            // intercepto
            // 
            this.intercepto.AutoSize = true;
            this.intercepto.Location = new System.Drawing.Point(69, 210);
            this.intercepto.Name = "intercepto";
            this.intercepto.Size = new System.Drawing.Size(35, 13);
            this.intercepto.TabIndex = 10;
            this.intercepto.Text = "label3";
            this.intercepto.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(274, 241);
            this.Controls.Add(this.intercepto);
            this.Controls.Add(this.solucion);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.errores);
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
        private System.Windows.Forms.Label errores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label solucion;
        private System.Windows.Forms.Label intercepto;
    }
}

