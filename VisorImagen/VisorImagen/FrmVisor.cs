using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VisorImagenBOL;
using VisorImagenENL;

namespace VisorImagen
{
    public partial class FrmVisor : Form
    {
        private ImagenBOL bol;
        private Imagen img;
        private int i;
        private bool funcion;
        private string filtro;
        private List<Imagen> imagenes;

        public FrmVisor()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialogImagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openDialogImagen.FileName;
                    picImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                img.Descripcion = txtDesc.Text;
                img.Foto = picImagen.Image;
                img.Tipo = txtTipo.Text;
                img.Titulo = txtTitulo.Text;
                img.Id = 0;
                if (bol.VerificarImagen(img))
                {
                    img = new Imagen();
                    MessageBox.Show("Agregado con éxito.");
                    LimpiarCampos();
                    imagenes = bol.CargarTodo(filtro);
                }
                else
                {
                    MessageBox.Show("Intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (img.Id != 0)
                {
                    img.Descripcion = txtDesc.Text;
                    img.Foto = picImagen.Image;
                    img.Tipo = txtTipo.Text;
                    img.Titulo = txtTitulo.Text;
                    
                    if (bol.VerificarImagen(img))
                    {
                        img = new Imagen();
                        MessageBox.Show("Modificado con éxito.");
                        LimpiarCampos();
                        imagenes = bol.CargarTodo(filtro);
                    }
                    else
                    {
                        MessageBox.Show("Intente nuevamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (img.Id > 0)
            {
                DialogResult result = MessageBox.Show(String.Format("Está seguro que desea eliminar a {0}", img.Titulo),
                    "Eliminar",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bol.EliminarImagen(img.Id))
                    {
                        imagenes = bol.CargarTodo(filtro);
                        i = 0;
                        LimpiarCampos();
                    }
                }
            }
        }

        private void FrmVisor_Load(object sender, EventArgs e)
        {
            bol = new ImagenBOL();
            img = new Imagen();
            imagenes = new List<Imagen>();
            filtro = "";
            imagenes = bol.CargarTodo(filtro);
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            comboBox1.Items.Add("");
            for (int i = 0; i < imagenes.Count; i++)
            {
                comboBox1.Items.Add(imagenes[i].Tipo);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (imagenes.Count != 0)
            {
                if (i <= 1)
                {
                    i = imagenes.Count;
                }
                else
                {
                    i--;
                }

                img = new Imagen();

                img.Descripcion = imagenes[i - 1].Descripcion;
                img.Foto = imagenes[i - 1].Foto;
                img.Tipo = imagenes[i - 1].Tipo;
                img.Titulo = imagenes[i - 1].Titulo;
                img.Id = imagenes[i - 1].Id;
                CargarImagen();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!funcion)
            {
                timer1.Start();
                funcion = true;
            }
            else
            {
                timer1.Stop();
                funcion = false;
            }
            
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (imagenes.Count != 0)
            {
                if (i == imagenes.Count)
                {
                    i = 1;
                }
                else
                {
                    i++;
                }
                img = new Imagen();

                img.Descripcion = imagenes[i - 1].Descripcion;
                img.Foto = imagenes[i - 1].Foto;
                img.Tipo = imagenes[i - 1].Tipo;
                img.Titulo = imagenes[i - 1].Titulo;
                img.Id = imagenes[i - 1].Id;

                CargarImagen();
            }
        }

        private void CargarImagen()
        {
            picImagen.Image = img.Foto;
            txtDesc.Text = img.Descripcion;
            txtTipo.Text = img.Tipo;
            txtTitulo.Text = img.Titulo;
            pictureBox1.Image = img.Foto;
        }

        private void LimpiarCampos()
        {
            picImagen.Image = null;
            txtDesc.Text = "";
            txtTipo.Text = "";
            txtTitulo.Text = "";
            pictureBox1.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imagenes.Count != 0)
            {
                if (i == imagenes.Count)
                {
                    i = 1;
                }
                else
                {
                    i++;
                }
                img = new Imagen();

                img.Descripcion = imagenes[i - 1].Descripcion;
                img.Foto = imagenes[i - 1].Foto;
                img.Tipo = imagenes[i - 1].Tipo;
                img.Titulo = imagenes[i - 1].Titulo;
                img.Id = imagenes[i - 1].Id;

                CargarImagen();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro = comboBox1.SelectedItem.ToString();
            imagenes = bol.CargarTodo(filtro);
            LimpiarCampos();
        }
    }
}
