namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblvalor2 = new System.Windows.Forms.Label();
            this.lblvalor1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtresultado);
            this.groupBox1.Controls.Add(this.txtValor2);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Controls.Add(this.lblresultado);
            this.groupBox1.Controls.Add(this.lblvalor2);
            this.groupBox1.Controls.Add(this.lblvalor1);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(135, 114);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 7;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(135, 73);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 6;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(135, 39);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 5;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(7, 114);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(100, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "R E S U L T A D O.";
            // 
            // lblvalor2
            // 
            this.lblvalor2.AutoSize = true;
            this.lblvalor2.Location = new System.Drawing.Point(67, 73);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(40, 13);
            this.lblvalor2.TabIndex = 3;
            this.lblvalor2.Text = "Valor 2";
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Location = new System.Drawing.Point(67, 39);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(40, 13);
            this.lblvalor1.TabIndex = 2;
            this.lblvalor1.Text = "Valor 1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(95, 163);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR.";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 252);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblvalor2;
        private System.Windows.Forms.Label lblvalor1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

