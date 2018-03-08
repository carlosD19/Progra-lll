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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.SelectedItem.ToString());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
