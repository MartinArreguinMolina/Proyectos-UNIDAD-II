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
    public partial class Convertidor : Form
    {
        Validar ob1 = new Validar();
        public Convertidor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal n;

            if (!ob1.vacio(txtMetros.Text))
            {
                n = decimal.Parse(txtMetros.Text);

                lblMm.Text = ((n * 1000m) + "\n" + (n * 100) + "\n" + (n * 10) + "\n" + (n) + "\n" + (n / 10m) + "\n" + (n / 100m) + "\n" + (n / 1000m)).ToString();
            }
            else
            {
                lblMm.Text = "";
            }
        }

        private void Convertidor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMetros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ob1.validarNumeros(e.KeyChar, txtMetros.Text);
        }
    }
}
