using System;
using System.Windows.Forms;

namespace RelojMarcador
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToString("dddd")
                + "  " + DateTime.Now.ToShortDateString();
        }
    }
}
