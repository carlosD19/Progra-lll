namespace DemoCapas
{
    partial class FrmMantUsu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRePas = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.txtEma = new System.Windows.Forms.TextBox();
            this.txtAps = new System.Windows.Forms.TextBox();
            this.txtApu = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openDialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mantenimiento de Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtRePas);
            this.groupBox1.Controls.Add(this.txtPas);
            this.groupBox1.Controls.Add(this.txtUsu);
            this.groupBox1.Controls.Add(this.txtEma);
            this.groupBox1.Controls.Add(this.txtAps);
            this.groupBox1.Controls.Add(this.txtApu);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCed);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(562, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DemoCapas.Properties.Resources.preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(506, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DemoCapas.Properties.Resources.send64;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(382, 120);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 65);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar   ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // txtRePas
            // 
            this.txtRePas.Location = new System.Drawing.Point(382, 88);
            this.txtRePas.Margin = new System.Windows.Forms.Padding(2);
            this.txtRePas.Name = "txtRePas";
            this.txtRePas.PasswordChar = '*';
            this.txtRePas.Size = new System.Drawing.Size(150, 26);
            this.txtRePas.TabIndex = 15;
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(382, 62);
            this.txtPas.Margin = new System.Windows.Forms.Padding(2);
            this.txtPas.Name = "txtPas";
            this.txtPas.PasswordChar = '*';
            this.txtPas.Size = new System.Drawing.Size(124, 26);
            this.txtPas.TabIndex = 14;
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(382, 36);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(150, 26);
            this.txtUsu.TabIndex = 13;
            // 
            // txtEma
            // 
            this.txtEma.Location = new System.Drawing.Point(112, 140);
            this.txtEma.Margin = new System.Windows.Forms.Padding(2);
            this.txtEma.Name = "txtEma";
            this.txtEma.Size = new System.Drawing.Size(150, 26);
            this.txtEma.TabIndex = 12;
            // 
            // txtAps
            // 
            this.txtAps.Location = new System.Drawing.Point(112, 114);
            this.txtAps.Margin = new System.Windows.Forms.Padding(2);
            this.txtAps.Name = "txtAps";
            this.txtAps.Size = new System.Drawing.Size(150, 26);
            this.txtAps.TabIndex = 11;
            // 
            // txtApu
            // 
            this.txtApu.Location = new System.Drawing.Point(112, 88);
            this.txtApu.Margin = new System.Windows.Forms.Padding(2);
            this.txtApu.Name = "txtApu";
            this.txtApu.Size = new System.Drawing.Size(150, 26);
            this.txtApu.TabIndex = 10;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 62);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 26);
            this.txtNom.TabIndex = 9;
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(112, 36);
            this.txtCed.Margin = new System.Windows.Forms.Padding(2);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(150, 26);
            this.txtCed.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Re-contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "1er Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "2ndo Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula: ";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.cedCol,
            this.usuCol,
            this.nomCol,
            this.apuCol,
            this.apsCol,
            this.pasCol,
            this.emaCol});
            this.dgvUsuarios.DataSource = this.eUsuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 127);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowTemplate.Height = 33;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(906, 245);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_CellMouseClick);
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 50;
            // 
            // cedCol
            // 
            this.cedCol.DataPropertyName = "Cedula";
            this.cedCol.HeaderText = "Cédula";
            this.cedCol.Name = "cedCol";
            this.cedCol.ReadOnly = true;
            this.cedCol.Width = 150;
            // 
            // usuCol
            // 
            this.usuCol.DataPropertyName = "Usuario";
            this.usuCol.HeaderText = "Usuario";
            this.usuCol.Name = "usuCol";
            this.usuCol.ReadOnly = true;
            this.usuCol.Width = 150;
            // 
            // nomCol
            // 
            this.nomCol.DataPropertyName = "Nombre";
            this.nomCol.HeaderText = "Nombre";
            this.nomCol.Name = "nomCol";
            this.nomCol.ReadOnly = true;
            this.nomCol.Width = 150;
            // 
            // apuCol
            // 
            this.apuCol.DataPropertyName = "ApellidoUno";
            this.apuCol.HeaderText = "1er Apellido";
            this.apuCol.Name = "apuCol";
            this.apuCol.ReadOnly = true;
            this.apuCol.Width = 250;
            // 
            // apsCol
            // 
            this.apsCol.DataPropertyName = "ApellidoDos";
            this.apsCol.HeaderText = "2ndo Apellido";
            this.apsCol.Name = "apsCol";
            this.apsCol.ReadOnly = true;
            this.apsCol.Width = 250;
            // 
            // pasCol
            // 
            this.pasCol.DataPropertyName = "Password";
            this.pasCol.HeaderText = "Contraseña";
            this.pasCol.Name = "pasCol";
            this.pasCol.ReadOnly = true;
            this.pasCol.Width = 200;
            // 
            // emaCol
            // 
            this.emaCol.DataPropertyName = "Email";
            this.emaCol.HeaderText = "Email";
            this.emaCol.Name = "emaCol";
            this.emaCol.ReadOnly = true;
            this.emaCol.Width = 300;
            // 
            // eUsuarioBindingSource
            // 
            this.eUsuarioBindingSource.DataSource = typeof(DemoCapasENL.EUsuario);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(18, 83);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(249, 28);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::DemoCapas.Properties.Resources.delete;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(510, 72);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 47);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = global::DemoCapas.Properties.Resources.add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(456, 72);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(45, 47);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = global::DemoCapas.Properties.Resources.search;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(268, 72);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(45, 47);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(602, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Imagen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(605, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openDialogImagen
            // 
            this.openDialogImagen.FileName = "openDialogImagen";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(824, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMantUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCargar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMantUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMantUsu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMantUsu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource eUsuarioBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRePas;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtEma;
        private System.Windows.Forms.TextBox txtAps;
        private System.Windows.Forms.TextBox txtApu;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn apuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn apsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openDialogImagen;
        private System.Windows.Forms.Button button2;
    }
}

