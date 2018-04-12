using IMNWebServices.IMN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMNWebServices
{
    public partial class Form1 : Form
    {
        private List<PRONOSTICO_REGIONALREGION> listaR;
        private List<PRONOSTICO_PORCIUDADESCIUDAD> listaC;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaR = new List<PRONOSTICO_REGIONALREGION>();
            listaC = new List<PRONOSTICO_PORCIUDADESCIUDAD>();
            Efemeries();
            PronosticoCiudad();
            PronosticoRegion();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void Efemeries()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            ws.efemerides(new efemerides());
            EFEMERIDES efe = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            rtEfemeries.Text = "Sale la luna: " + efe.EFEMERIDE_LUNA.SALE
                + "\nSepone la luna: " + efe.EFEMERIDE_LUNA.SEPONE
                + "\nSale el sol: " + efe.EFEMERIDE_SOL.SALE
                + "\nSepone el sol: " + efe.EFEMERIDE_SOL.SEPONE
                + "\nFase Lunar: " + efe.FASELUNAR.Value;
        }
        private void PronosticoCiudad()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            ws.pronosticoPorCiudad(new pronosticoCiudad());
            PRONOSTICO_PORCIUDADES pc = ws.pronosticoPorCiudad(new pronosticoCiudad()).ParseXML<PRONOSTICO_PORCIUDADES>();
            for (int i = 0; i < pc.CIUDADES.Length; i++)
            {
                listaC.Add(pc.CIUDADES[i]);
                comboBox1.Items.Add(pc.CIUDADES[i].nombre);
            }
        }

        private void PronosticoRegion()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            ws.pronosticoRegional(new pronosticoRegion());
            PRONOSTICO_REGIONAL pr = ws.pronosticoRegional(new pronosticoRegion()).ParseXML<PRONOSTICO_REGIONAL>();
            for (int i = 0; i < pr.REGIONES.Length; i++)
            {
                listaR.Add(pr.REGIONES[i]);
                comboBox2.Items.Add(pr.REGIONES[i].nombre);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaC.Count; i++)
            {
                if (listaC[i].nombre.Equals(comboBox1.SelectedItem.ToString()))
                {
                    rtCiudad.Text = "NOMBRE:  " + System.Environment.NewLine + listaC[i].nombre + System.Environment.NewLine;
                    rtCiudad.Text += "COMENTARIO MAÑANA:  " + System.Environment.NewLine + listaC[i].COMENTARIOMANANA + System.Environment.NewLine;
                    rtCiudad.Text += "COMENTARIO TARDE:  " + System.Environment.NewLine + listaC[i].COMENTARIOTARDE + System.Environment.NewLine;
                    rtCiudad.Text += "COMENTARIO NOCHE:  " + System.Environment.NewLine + listaC[i].COMENTARIOMANANA + System.Environment.NewLine;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaR.Count; i++)
            {
                if (listaR[i].nombre.Equals(comboBox2.SelectedItem.ToString()))
                {
                    richTextBox1.Text = "NOMBRE:  " + System.Environment.NewLine + listaR[i].nombre + System.Environment.NewLine;
                    richTextBox1.Text += "COMENTARIO MAÑANA:  " + System.Environment.NewLine + listaR[i].COMENTARIOMANANA + System.Environment.NewLine;
                    richTextBox1.Text += "COMENTARIO TARDE:  " + System.Environment.NewLine + listaR[i].COMENTARIOTARDE + System.Environment.NewLine;
                    richTextBox1.Text += "COMENTARIO NOCHE:  " + System.Environment.NewLine + listaR[i].COMENTARIOMANANA + System.Environment.NewLine;
                }
            }
        }
    }
}
