using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cf;
            double ct1;
            string r;
            ct1 = Convert.ToDouble(textBox1.Text);
            cf = ct1 * 1.8 + 32.0;
            r = String.Format("{0:F3}", cf);
            textBox2.Text = r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fc;
            double ct1;
            string r;
            ct1 = Convert.ToDouble(textBox1.Text);
            fc = (ct1 - 32.0) / 1.8;
            r = String.Format("{0:F3}", fc);
            textBox2.Text = r;
        }
    }
}
