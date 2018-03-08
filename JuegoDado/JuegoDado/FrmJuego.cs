using JuegoDadoBOL;
using JuegoDadoENL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDado
{
    public partial class FrmJuego : Form
    {
        private bool bus;
        private int tiros;
        private int puntos;
        private int num1;
        private int num2;
        private UsuarioBOL bol;
        private UsuarioENL usu;
        private DadoENL puntaje;
        public FrmJuego()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeControlStyles(btnDadoUno, ControlStyles.Selectable, false);
            ChangeControlStyles(btnDadoDos, ControlStyles.Selectable, false);
            tiros = 0;
            num1 = 0;
            num2 = 0;
            bol = new UsuarioBOL();
            puntaje = new DadoENL();
            usu = new UsuarioENL();
        }

        private void ChangeControlStyles(Control ctrl, ControlStyles flag, bool value)
        {
            MethodInfo method = ctrl.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            if (method != null)
                method.Invoke(ctrl, new object[] { flag, value });
        }

        private void btnDadoDos_Click(object sender, EventArgs e)
        {
            DetenerDado();
        }

        private void DetenerDado()
        {
            if (tiros == 10)
            {
                txtResultado.Text += "Tiros: " + tiros + "  Puntaje: " + puntos;
                btnDadoUno.Enabled = false;
                btnDadoDos.Enabled = false;

            }
            if (!bus)
            {
                RandomNumero();
                bus = true;
                tiros++;
            }
            else
            {
                btnDadoUno.Image = Properties.Resources.dado;
                btnDadoDos.Image = Properties.Resources.dado;
                bus = false;
            }
        }

        private void RandomNumero()
        {
            Random rnd = new Random();
            num1 = rnd.Next(1, 7);
            num2 = rnd.Next(1, 7);
            int resultado = num1 + num2;
            txtResultado.Text += "Número Uno: " + num1 + "  Número Dos: " + num2 + "\n";
            if (resultado == spNum.Value)
            {
                puntos += 2;
            }
            else if (resultado + 1 == spNum.Value || resultado - 1 == spNum.Value)
            {
                puntos += 1;
            }

            btnDadoUno.Image = AsignarImagen(num1);
            btnDadoDos.Image = AsignarImagen(num2);
        }

        private void btnDadoUno_Click(object sender, EventArgs e)
        {
            DetenerDado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tiros == 10)
            {
                try
                {
                    usu.Usuario = txtUsu.Text.Trim();
                    usu.Fecha = DateTime.Now.Date;
                    puntaje.Puntaje = puntos;
                    if(bol.VerificarUsu(usu, puntaje))
                    {
                        MessageBox.Show("Guardado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private Image AsignarImagen(int num1)
        {
            if (num1 == 1)
            {
                return Properties.Resources._1;
            }
            if (num1 == 2)
            {
                return Properties.Resources._2;
            }
            if (num1 == 3)
            {
                return Properties.Resources._3;
            }
            if (num1 == 4)
            {
                return Properties.Resources._4;
            }
            if (num1 == 5)
            {
                return Properties.Resources._5;
            }
            if (num1 == 6)
            {
                return Properties.Resources._6;
            }
            return null;
        }
    }
}
