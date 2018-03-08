using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojMarcador
{
    public partial class FrmHorario : Form
    {
        private int funcion;

        public FrmHorario()
        {
            InitializeComponent();
            CenterToParent();
        }

        public FrmHorario(int f)
        {
            InitializeComponent();
            CenterToParent();
            funcion = f;
        }
    }
}
