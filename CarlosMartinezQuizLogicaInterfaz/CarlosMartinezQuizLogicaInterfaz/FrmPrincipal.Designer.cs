namespace CarlosMartinezQuizLogicaInterfaz
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaArregloToolStripMenuItem,
            this.pantallaNumeroToolStripMenuItem,
            this.pantallaTextoToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // pantallaArregloToolStripMenuItem
            // 
            this.pantallaArregloToolStripMenuItem.Name = "pantallaArregloToolStripMenuItem";
            this.pantallaArregloToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pantallaArregloToolStripMenuItem.Text = "Pantalla Arreglo";
            this.pantallaArregloToolStripMenuItem.Click += new System.EventHandler(this.pantallaArregloToolStripMenuItem_Click);
            // 
            // pantallaNumeroToolStripMenuItem
            // 
            this.pantallaNumeroToolStripMenuItem.Name = "pantallaNumeroToolStripMenuItem";
            this.pantallaNumeroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pantallaNumeroToolStripMenuItem.Text = "Pantalla Numero";
            this.pantallaNumeroToolStripMenuItem.Click += new System.EventHandler(this.pantallaNumeroToolStripMenuItem_Click);
            // 
            // pantallaTextoToolStripMenuItem
            // 
            this.pantallaTextoToolStripMenuItem.Name = "pantallaTextoToolStripMenuItem";
            this.pantallaTextoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pantallaTextoToolStripMenuItem.Text = "Pantalla Texto";
            this.pantallaTextoToolStripMenuItem.Click += new System.EventHandler(this.pantallaTextoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 285);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Pantalla Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaArregloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaNumeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaTextoToolStripMenuItem;
    }
}

