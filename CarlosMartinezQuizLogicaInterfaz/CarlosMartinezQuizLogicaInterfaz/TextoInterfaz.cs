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
    public partial class TextoInterfaz : Form
    {
        public TextoInterfaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextoUtilidades t = new TextoUtilidades();
            string p = textBox1.Text;
            richTextBox1.Text = t.verificarPalabra(p);
        }
    }
}
