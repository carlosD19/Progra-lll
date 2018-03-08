using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojMarcador
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void modificarDocente_Click(object sender, EventArgs e)
        {
            FrmDocente frmDocente = new FrmDocente(2);
            frmDocente.Show();
        }

        private void eliminarDocente_Click(object sender, EventArgs e)
        {
            FrmDocente frmDocente = new FrmDocente(3);
            frmDocente.Show();
        }

        private void agregarCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso(1);
            frmCurso.Show();
        }

        private void modificarCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso(2);
            frmCurso.Show();
        }

        private void eliminarCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso(3);
            frmCurso.Show();
        }

        private void agregarHorario_Click(object sender, EventArgs e)
        {
            FrmHorario frmHorario = new FrmHorario(1);
            frmHorario.Show();
        }

        private void modificarHorario_Click(object sender, EventArgs e)
        {
            FrmHorario frmHorario = new FrmHorario(2);
            frmHorario.Show();
        }

        private void eliminarHorario_Click(object sender, EventArgs e)
        {
            FrmHorario frmHorario = new FrmHorario(3);
            frmHorario.Show();
        }

        private void agregarDocente_Click_1(object sender, EventArgs e)
        {
            FrmDocente frmDocente = new FrmDocente(1);
            frmDocente.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
