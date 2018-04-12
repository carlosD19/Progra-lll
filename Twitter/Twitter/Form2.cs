using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi.Models;

namespace Twitter
{
    public partial class Form2 : Form
    {
        TwitterConfig tw = new TwitterConfig();
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwitterConfig t = new TwitterConfig();
            var frm = new Form1(t.SolicitudCredenciales());
            frm.ShowDialog();
            CargarUsuario(frm.twit);
        }

        private void CargarUsuario(IAuthenticatedUser twit)
        {
            if (twit != null)
            {
                pictureBox1.Load(twit.ProfileImageUrl);
            }
        }
    }
}
