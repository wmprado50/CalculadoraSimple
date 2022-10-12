namespace CalculadoraSimple
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA SIMPLE";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(136, 109);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(135, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(494, 109);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(139, 20);
            this.txtNumero2.TabIndex = 2;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(136, 189);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(82, 40);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "SUMAR";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "RESTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(402, 189);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(88, 40);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(553, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "DIVIDIR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(325, 323);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primer Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo Numero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}

