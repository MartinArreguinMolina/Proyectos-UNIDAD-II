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
    public partial class Seguidor : Form
    {

        Coordenadas ob1 = new Coordenadas();
        public Seguidor()
        {
            InitializeComponent();
        }

        private void Seguidor_Load(object sender, EventArgs e)
        {
            ob1.MdiParent = this.MdiParent;
        }

        private void checkBoxSeguidor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeguidor.Checked)
            {
                ob1.Visible = true;
                ob1.coordenadas(this.Location.X, this.Location.Y, this.Width, this.Height);
            }
            else
            {
                ob1.Visible = false;
                ob1.coordenadas(this.Location.X, this.Location.Y, this.Width, this.Height);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }
    }
}
