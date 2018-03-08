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
    public partial class MessageBoxes : Form
    {
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
        public MessageBoxes()
        {
            InitializeComponent();
        }

        private void TipoDeBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1)
            {
                tipoDeBoton = MessageBoxButtons.OK;
            }
            else if (sender == radioButton2)
            {
                tipoDeBoton = MessageBoxButtons.OKCancel;
            }
            else if (sender == radioButton3)
            {
                tipoDeBoton = MessageBoxButtons.YesNo;
            }
            else if (sender == radioButton5)
            {
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            }
            else if (sender == radioButton4)
            {
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            }
            else
            {
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
            }
        }

        private void TipoDeIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton6)
            {
                tipoDeIcono = MessageBoxIcon.Information;
            }
            else if (sender == radioButton9)
            {
                tipoDeIcono = MessageBoxIcon.Exclamation;
            }
            else if (sender == radioButton8)
            {
                tipoDeIcono = MessageBoxIcon.Question;
            }
            else
            {
                tipoDeIcono = MessageBoxIcon.Error;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mensaje a desplegar",
                "Titulo de la Ventana",tipoDeBoton,tipoDeIcono);
            switch (result)
            {
                case DialogResult.OK:
                    label2.Text = "Seleccionó OK.";
                    break;
                case DialogResult.Cancel:
                    label2.Text = "Seleccionó Cancel.";
                    break;
                case DialogResult.Yes:
                    label2.Text = "Seleccionó YES.";
                    break;
                case DialogResult.No:
                    label2.Text = "Seleccionó No.";
                    break;
                case DialogResult.Ignore:
                    label2.Text = "Seleccionó Ignore.";
                    break;
                case DialogResult.Abort:
                    label2.Text = "Seleccionó Abort.";
                    break;
                case DialogResult.Retry:
                    label2.Text = "Seleccionó Retry.";
                    break;
            }
        }
    }
}
