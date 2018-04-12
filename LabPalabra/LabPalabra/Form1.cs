using LabPalabraBOL;
using LabPalabraENL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPalabra
{
    public partial class Form1 : Form
    {
        private PalabraBOL bol;
        private PalabraENL palabraENL;
        private List<PalabraENL> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string letra = "";
            string palabra = textBox1.Text;
            richTextBox1.Text = "";
            if (bol.VerificarPalabra(palabra))
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    letra = palabra[i].ToString();
                    palabraENL = bol.CargarPorLetra(letra);
                    if (palabraENL.Palabra == null)
                    {
                        richTextBox1.Text += letra.ToUpper() + System.Environment.NewLine;
                    }
                    else
                    {
                        richTextBox1.Text += palabraENL.Palabra + System.Environment.NewLine;
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bol = new PalabraBOL();
            palabraENL = new PalabraENL();
            lista = new List<PalabraENL>();
            lista = bol.CargarTodo();
            dataGridView1.DataSource = lista;
        }
    }
}
