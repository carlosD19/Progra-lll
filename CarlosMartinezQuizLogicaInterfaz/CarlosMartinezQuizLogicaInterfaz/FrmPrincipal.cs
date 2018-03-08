using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosMartinezQuizLogicaInterfaz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pantallaArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArregloInterfaz a = new ArregloInterfaz();
            a.Show();
        }

        private void pantallaNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumeroInterfaz n = new NumeroInterfaz();
            n.Show();
        }

        private void pantallaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextoInterfaz t = new TextoInterfaz();
            t.Show();
        }
    }
}
