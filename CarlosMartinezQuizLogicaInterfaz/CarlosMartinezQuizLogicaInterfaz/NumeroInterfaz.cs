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
    public partial class NumeroInterfaz : Form
    {
        public NumeroInterfaz()
        {
            InitializeComponent();
        }

        private void numeroNarcistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroUtilidades n = new NumeroUtilidades();
            int num = Int32.Parse(textBox1.Text);
            richTextBox1.Text = n.verificarNumero(num);
        }
    }
}
