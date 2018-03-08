namespace RelojMarcador
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHorario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.horarioToolStripMenuItem});
            this.agregarToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(114, 21);
            this.agregarToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDocente,
            this.modificarDocente,
            this.eliminarDocente});
            this.docenteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // agregarDocente
            // 
            this.agregarDocente.Name = "agregarDocente";
            this.agregarDocente.Size = new System.Drawing.Size(152, 22);
            this.agregarDocente.Text = "Agregar";
            this.agregarDocente.Click += new System.EventHandler(this.agregarDocente_Click_1);
            // 
            // modificarDocente
            // 
            this.modificarDocente.Name = "modificarDocente";
            this.modificarDocente.Size = new System.Drawing.Size(152, 22);
            this.modificarDocente.Text = "Modificar";
            // 
            // eliminarDocente
            // 
            this.eliminarDocente.Name = "eliminarDocente";
            this.eliminarDocente.Size = new System.Drawing.Size(152, 22);
            this.eliminarDocente.Text = "Eliminar";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCurso,
            this.modificarCurso,
            this.eliminarCurso});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // agregarCurso
            // 
            this.agregarCurso.Name = "agregarCurso";
            this.agregarCurso.Size = new System.Drawing.Size(152, 22);
            this.agregarCurso.Text = "Agregar";
            // 
            // modificarCurso
            // 
            this.modificarCurso.Name = "modificarCurso";
            this.modificarCurso.Size = new System.Drawing.Size(152, 22);
            this.modificarCurso.Text = "Modificar";
            // 
            // eliminarCurso
            // 
            this.eliminarCurso.Name = "eliminarCurso";
            this.eliminarCurso.Size = new System.Drawing.Size(152, 22);
            this.eliminarCurso.Text = "Eliminar";
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarHorario,
            this.modificarHorario,
            this.eliminarHorario});
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horarioToolStripMenuItem.Text = "Horario";
            // 
            // agregarHorario
            // 
            this.agregarHorario.Name = "agregarHorario";
            this.agregarHorario.Size = new System.Drawing.Size(152, 22);
            this.agregarHorario.Text = "Agregar";
            // 
            // modificarHorario
            // 
            this.modificarHorario.Name = "modificarHorario";
            this.modificarHorario.Size = new System.Drawing.Size(152, 22);
            this.modificarHorario.Text = "Modificar";
            // 
            // eliminarHorario
            // 
            this.eliminarHorario.Name = "eliminarHorario";
            this.eliminarHorario.Size = new System.Drawing.Size(152, 22);
            this.eliminarHorario.Text = "Eliminar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 508);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmDocente";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDocente;
        private System.Windows.Forms.ToolStripMenuItem modificarDocente;
        private System.Windows.Forms.ToolStripMenuItem eliminarDocente;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCurso;
        private System.Windows.Forms.ToolStripMenuItem modificarCurso;
        private System.Windows.Forms.ToolStripMenuItem eliminarCurso;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarHorario;
        private System.Windows.Forms.ToolStripMenuItem modificarHorario;
        private System.Windows.Forms.ToolStripMenuItem eliminarHorario;
    }
}