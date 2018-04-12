using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;

namespace Twitter
{
    public partial class Form1 : Form
    {
        public string url;
        public IAuthenticatedUser twit { get; private set; }

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Form1(string url)
        {
            InitializeComponent();
            panel1.Visible = false;
            webBrowser1.Navigate(url);
            CenterToScreen();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                TwitterConfig t = new TwitterConfig();
                twit = t.AutenticarUsuario(textBox1.Text);
                this.Close();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.Equals("https://api.twitter.com/oauth/authorize"))
            {
                panel1.Visible = true;
            }
        }
    }
}
