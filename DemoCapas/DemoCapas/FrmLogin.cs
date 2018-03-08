using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCapasENL;
using DemoCapasBOL;

namespace DemoCapas
{
    public partial class FrmLogin : Form
    {
        private UsuarioBOL ubo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ubo = new UsuarioBOL();
        }

        private void Login(object sender, EventArgs e)
        {
            EUsuario usuario = new EUsuario
            {
                Usuario = txtUser.Text.Trim(),
                Email = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim()
            };

            usuario = ubo.Login(usuario);

            if (usuario != null)
            {
                FrmMantUsu frm = new FrmMantUsu();
                LimpiarDatos();
                frm.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña inválidos");
            }
        }

        private void LimpiarDatos()
        {
            txtUser.Text = "";
            txtPass.Clear();
        }
    }
}
