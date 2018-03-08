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
    public partial class Form4 : Form
    {
        public string Nombre
        {
            set
            {
                label1.Text = value;
            }
        }
        public string Calle
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string Colonia
        {
            get
            {
                return textBox2.Text;
            }
        }
        public string Delegacion
        {
            get
            {
                return textBox3.Text;
            }
        }
        public string CodigoPostal
        {
            get
            {
                return textBox4.Text;
            }
        }
        public string Telefono
        {
            get
            {
                return textBox5.Text;
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
