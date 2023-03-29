using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMDI
{

    public partial class Coordenadas : Form
    {
        public Coordenadas()
        {
            InitializeComponent();
        }

        private void Coordenadas_Load(object sender, EventArgs e)
        {

        }

        public void lblAncho_Click(object sender, EventArgs e)
        {

        }

        public void coordenadas(int x, int y, int ancho, int alto)
        {
            this.Location = new Point(x + ancho + 10, y);
            lblAncho.Text = x.ToString();
            lblAlto.Text = y.ToString();
            lblArriba.Text = alto.ToString();
            lblIzquierda.Text = ancho.ToString();
        }

        private void lblArriba_Click(object sender, EventArgs e)
        {

        }
    }
}
