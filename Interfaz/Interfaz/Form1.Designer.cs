namespace Interfaz
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
            this.Operador1 = new System.Windows.Forms.Label();
            this.Operador2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operador1
            // 
            this.Operador1.AutoSize = true;
            this.Operador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operador1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Operador1.Location = new System.Drawing.Point(74, 61);
            this.Operador1.Name = "Operador1";
            this.Operador1.Size = new System.Drawing.Size(76, 16);
            this.Operador1.TabIndex = 0;
            this.Operador1.Text = "Operador 1";
            // 
            // Operador2
            // 
            this.Operador2.AutoSize = true;
            this.Operador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operador2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Operador2.Location = new System.Drawing.Point(74, 114);
            this.Operador2.Name = "Operador2";
            this.Operador2.Size = new System.Drawing.Size(76, 16);
            this.Operador2.TabIndex = 1;
            this.Operador2.Text = "Operador 2";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(159, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(159, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Multiplicar
            // 
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Multiplicar.Location = new System.Drawing.Point(77, 155);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(76, 23);
            this.Multiplicar.TabIndex = 4;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(159, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Limpiar.Location = new System.Drawing.Point(77, 204);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salir.Location = new System.Drawing.Point(184, 204);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Operador2);
            this.Controls.Add(this.Operador1);
            this.Name = "Form1";
            this.Text = "Multiplica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Operador1;
        private System.Windows.Forms.Label Operador2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
    }
}

