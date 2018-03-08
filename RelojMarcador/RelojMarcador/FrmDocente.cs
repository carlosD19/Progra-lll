using System;
using System.Data;
using System.Windows.Forms;

namespace RelojMarcador
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
            CenterToParent();
        }

        public FrmDocente(int f)
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.Hour.ToString());
        }
    }
}
