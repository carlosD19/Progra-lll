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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 data = new Form4();
            data.Nombre = textBox1.Text;
            data.ShowDialog();
            label2.Text = "Calle: " + data.Calle;
            label3.Text = "Colonia: " + data.Colonia;
            label4.Text = "Delegación: " + data.Delegacion;
            label5.Text = "Codigo Postal: " + data.CodigoPostal;
            label6.Text = "Telefono: " + data.Telefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 acercaDe = new Form3();
            acercaDe.ShowDialog();
        }
    }
}
