using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Cartas
{
    public partial class Form1 : Form
    {
        private Mazo mazo;
        private int x1, x2, x3, x4, x5, x6, x7;
        private List<Jugador> js = new List<Jugador>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Jugadores()
        {
            for (int i = 0; i < 7; i++)
            {
                Jugador j1 = new Jugador();
                j1.Nombre = (i + 1).ToString();
                j1.Cartas = new Card[2];
                js.Add(j1);
            }
        }

        private Carta DibujarCarta()
        {
            Carta carta = new Carta();
            string URL = String.Format("https://deckofcardsapi.com/api/deck/{0}/draw/?count=2", mazo.deck_id);
            string json = new WebClient().DownloadString(URL);
            carta = JsonConvert.DeserializeObject<Carta>(json);
            return carta;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mazo = new Mazo();
            string URL = @"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            string json = new WebClient().DownloadString(URL);
            mazo = JsonConvert.DeserializeObject<Mazo>(json);
            Jugadores();
            jugadorUno(DibujarCarta());
            jugadorDos(DibujarCarta());
            jugadorTres(DibujarCarta());
            jugadorCuatro(DibujarCarta());
            jugadorCinco(DibujarCarta());
            jugadorSeis(DibujarCarta());
            jugadorSiete(DibujarCarta());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        label1.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 1:
                        label2.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 2:
                        label3.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 3:
                        label4.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 4:
                        label5.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 5:
                        label6.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    case 6:
                        label7.Text = js[i].Contar(js[i].Cartas).ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void jugadorUno(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x1, panel1, i, carta);
                js[0].Cartas[i] = carta.cards[i];
                x1 += 25;
            }
        }

        private void jugadorDos(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x2, panel2, i, carta);
                js[1].Cartas[i] = carta.cards[i];
                x2 += 25;
            }
        }

        private void jugadorTres(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x3, panel3, i, carta);
                js[2].Cartas[i] = carta.cards[i];
                x3 += 25;
            }
        }
        private void jugadorCuatro(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x4, panel8, i, carta);
                js[3].Cartas[i] = carta.cards[i];
                x4 += 25;
            }
        }
        private void jugadorCinco(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x5, panel5, i, carta);
                js[4].Cartas[i] = carta.cards[i];
                x5 += 25;
            }
        }
        private void jugadorSeis(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x6, panel6, i, carta);
                js[5].Cartas[i] = carta.cards[i];
                x6 += 25;
            }
        }
        private void jugadorSiete(Carta carta)
        {
            for (int i = 0; i < 2; i++)
            {
                NuevoPB(x7, panel7, i, carta);
                js[6].Cartas[i] = carta.cards[i];
                x7 += 25;
            }
        }

        private void NuevoPB(int x, Panel panel, int i, Carta carta)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(x, 0);
            pb.Size = new System.Drawing.Size(150, 250);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BorderStyle = BorderStyle.None;
            panel.Controls.Add(pb);
            pb.Load(carta.cards[i].image);
            pb.BringToFront();
        }
    }
}
