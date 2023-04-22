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
    public partial class NumeroMagico : Form
    {
        public NumeroMagico()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NumeroMagico_Load(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            btnIniciarPartida.Enabled = false;

            ControlDesde.Maximum = 99;
            ControlDesde.Minimum = 1;
            ControlDesde.Value = 1;

            ControlHasta.Maximum = 100;
            ControlHasta.Minimum = 2;
            ControlHasta.Value = 2;

            ControlHasta.ReadOnly = true;
            ControlDesde.ReadOnly = true;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                btnIniciarPartida.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                btnIniciarPartida.Enabled = true;
            }
        }

        private void ControlDesde_ValueChanged(object sender, EventArgs e)
        {
            if (ControlDesde.Value == ControlHasta.Value)
            {
                ControlHasta.Value = ControlHasta.Value + 1;
            }

            if (checkBoxRelog.Checked)
            {
                label3.Text = "Dispondras de " + (ControlHasta.Value - ControlDesde.Value) * 3 + " segundos para adivinar el numero magico";
            }
        }

        private void ControlHasta_ValueChanged(object sender, EventArgs e)
        {
            if (ControlHasta.Value <= ControlDesde.Value)
            {
                ControlHasta.Value = ControlDesde.Value + 1;
            }

            if (checkBoxRelog.Checked)
            {
                label3.Text = "Dispondras de " + (ControlHasta.Value - ControlDesde.Value) * 3 + " segundos para adivinar el numero magico";
            }

        }

        private void checkBoxRelog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRelog.Checked)
            {
                label3.Text = "Dispondras de " + (ControlHasta.Value - ControlDesde.Value) * 3 + " segundos para adivinar el numero magico";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            if (checkBoxRelog.Checked)
            {
                AdivinaElNumeroTiempo ob2 = new AdivinaElNumeroTiempo();
                ob2.MdiParent = this.MdiParent;
                ob2.tiempoLimite(((int)ControlHasta.Value - (int)ControlDesde.Value) * 3);
                ob2.numAleatorio(r.Next((int)ControlDesde.Value, (int)ControlHasta.Value + 1));
                ob2.nombre(txtNombre.Text);
                ob2.Show();
            }
            else
            {
                AdivinaElNumero ob1 = new AdivinaElNumero();
                ob1.MdiParent = this.MdiParent;
                ob1.numAleatorio(r.Next((int)ControlDesde.Value, (int)ControlHasta.Value + 1));
                ob1.nombre(txtNombre.Text);
                ob1.Show();
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDeNumeroMagico ob1 = new AcercaDeNumeroMagico();
            ob1.MdiParent = this.MdiParent;
            ob1.Show();
        }
    }
}
