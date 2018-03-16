using JuegoDadoBOL;
using JuegoDadoENL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDado
{
    public partial class FrmTop : Form
    {
        private DadoBOL dadoBOL;
        private UsuarioBOL usuarioBOL;
        private List<UsuarioENL> usuarios;
        private List<DadoENL> dados;

        public FrmTop()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {
            dadoBOL = new DadoBOL();
            usuarioBOL = new UsuarioBOL();
            usuarios = usuarioBOL.CargarTodo();
            dados = dadoBOL.CargarTodo();
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            foreach (DadoENL d in dados)
            {
                foreach (UsuarioENL u in usuarios)
                {
                    if (d.Id_Usuario == u.Id)
                    {
                        dgvTop.Rows.Add(u.Usuario, d.Puntaje);
                    }
                }
            }



        }
    }
}
