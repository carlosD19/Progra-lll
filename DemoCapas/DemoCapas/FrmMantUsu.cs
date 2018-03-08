using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DemoCapasBOL;
using DemoCapasENL;

namespace DemoCapas
{
    public partial class FrmMantUsu : Form
    {
        private UsuarioBOL ubo;
        private EUsuario usuario;

        public FrmMantUsu()
        {
            InitializeComponent();
        }

        private void FrmMantUsu_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBOL();
            usuario = new EUsuario();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = ubo.CargarUsuarios(txtFiltro.Text.Trim());
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.Cedula = txtCed.Text.Trim();
                usuario.Nombre = txtNom.Text.Trim();
                usuario.ApellidoUno = txtApu.Text.Trim();
                usuario.ApellidoDos = txtAps.Text.Trim();
                usuario.Usuario = txtUsu.Text.Trim();
                usuario.Email = txtEma.Text.Trim();
                usuario.Password = txtPas.Text.Trim();
                Image imagen = pictureBox1.Image;
                if (ubo.Guardar(usuario, txtRePas.Text.Trim(), imagen))
                {
                    MessageBox.Show("Guardado con éxtito");
                }
                else
                {
                    MessageBox.Show("Intente nuevamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FrmMantUsu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            usuario = new EUsuario();
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtCed.Text = usuario.Cedula;
            txtNom.Text = usuario.Nombre;
            txtApu.Text = usuario.ApellidoUno;
            txtAps.Text = usuario.ApellidoDos;
            txtEma.Text = usuario.Email;
            txtUsu.Text = usuario.Usuario;
            txtPas.Text = usuario.Password;
            pictureBox1.Image = usuario.Imagen;
            txtRePas.Clear();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPas.PasswordChar = '\0';
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPas.PasswordChar = '*';
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //TODO: Controlar errores
            int row = dgvUsuarios.SelectedRows.Count > 0 ? dgvUsuarios.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                usuario = dgvUsuarios.CurrentRow.DataBoundItem as EUsuario;

                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuario.Id > 0)
            {
                DialogResult result = MessageBox.Show(String.Format("Está seguro que desea eliminar a {0}", usuario.Usuario),
                    "Eliminar",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ubo.Eliminar(usuario.Id);
                }

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length >= 3)
            {
                CargarUsuarios();
            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialogImagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openDialogImagen.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario.Id > 0)
            {
                DialogResult result = MessageBox.Show(String.Format("Está seguro que desea eliminar la imagen de {0}", usuario.Usuario),
                    "Eliminar",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (ubo.EliminarImagen(usuario.Id))
                    {
                        pictureBox1.Image = null;
                    }
                }

            }
        }
    }
}
