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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            double ct1;
            double ct2;
            double m;
            string r;
            try
            {
                ct1 = Convert.ToDouble(textBox1.Text);
                ct2 = Convert.ToDouble(textBox2.Text);
                m = ct1 * ct2;
                r = String.Format("{0:F2}", m);
                textBox3.Text = r;
            }catch(Exception ex)
            {
                //label error
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
