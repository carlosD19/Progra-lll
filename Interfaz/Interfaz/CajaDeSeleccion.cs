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
    public partial class CajaDeSeleccion : Form
    {
        public CajaDeSeleccion()
        {
            InitializeComponent();
        }

        private void Negrita_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                this.label1.Font.Size,this.label1.Font.Style ^ FontStyle.Bold);
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Italic);
        }

        private void Strickeout_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Strikeout);
        }

        private void Underline_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                this.label1.Font.Size, this.label1.Font.Style ^ FontStyle.Underline);
        }

        private void Consolas_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Consolas");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
                this.label1.Font.Style);
        }

        private void ColonnaMT_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Colonna MT");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
                this.label1.Font.Style);
        }

        private void Verdana_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Verdana");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
                this.label1.Font.Style);
        }

        private void Broadway_CheckedChanged(object sender, EventArgs e)
        {
            FontFamily csl = new FontFamily("Broadway");
            this.label1.Font = new Font(csl, this.label1.Font.Size,
                this.label1.Font.Style);
        }

        private void tamanno8_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                8, this.label1.Font.Style);
        }

        private void tamanno12_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                12, this.label1.Font.Style);
        }

        private void tamanno16_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                16, this.label1.Font.Style);
        }

        private void tamanno20_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font.FontFamily,
                20, this.label1.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontFamily mss = new FontFamily("Microsoft Sans Serif");
            this.label1.Font = new Font(mss, 12, FontStyle.Regular);
        }
    }
}
