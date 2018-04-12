using System;
using System.Windows.Forms;

namespace DemoWebServer
{
    public partial class Form1 : Form
    {
        private TipoCambio t;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Double.Parse(txtValor.Text);
                double result = 0;
                if (rbCD.Checked)
                {
                    result = t.ColonesDolares(valor);
                    lblResultado.Text = String.Format("Valor: {0:F2}", result);
                }
                else if (rbDC.Checked)
                {
                    result = t.DolaresColones(valor);
                    lblResultado.Text = String.Format("Valor: {0:F2}", result);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Formato incorrecto.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new TipoCambio();
            lblValor.Text = String.Format("Valor: {0:F2}", t.ValorCambio());
        }
    }
}
