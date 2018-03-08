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
    public partial class ArregloInterfaz : Form
    {
        public ArregloInterfaz()
        {
            InitializeComponent();
        }

        private void ordenarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArregloUtilidades a = new ArregloUtilidades();
            richTextBox1.Text = a.OrdenarArreglo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            int num1 = Int32.Parse(textBox2.Text);
            int num2 = Int32.Parse(textBox3.Text);
            ArregloUtilidades a = new ArregloUtilidades();
            richTextBox1.Text = a.cadenaCaracteres(p,num1,num2);
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArregloUtilidades a = new ArregloUtilidades();
            richTextBox1.Text = a.promedio();
        }
    }
}
