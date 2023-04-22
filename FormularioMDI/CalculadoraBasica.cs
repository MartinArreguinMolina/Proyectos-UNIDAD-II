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
    public partial class CalculadoraBasica : Form
    {

        Validar ob1 = new Validar();
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculadoraBasica_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void txtValorUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ob1.validarNumeros(e.KeyChar, txtValorUno.Text);
        }

        private void txtValorDos_TextChanged(object sender, EventArgs e)
        {
            if (ob1.vacio(txtValorUno.Text) && ob1.vacio(txtValorDos.Text))
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void txtValorDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ob1.validarNumeros(e.KeyChar, txtValorDos.Text);
        }

        private void txtValorUno_TextChanged(object sender, EventArgs e)
        {
            if (ob1.vacio(txtValorUno.Text) && ob1.vacio(txtValorDos.Text))
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            decimal n;
            decimal m;

            n = decimal.Parse(txtValorUno.Text);
            m = decimal.Parse(txtValorDos.Text);

            lblResultados.Text = "La suma es: " + (n + m);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            decimal n;
            decimal m;

            n = decimal.Parse(txtValorUno.Text);
            m = decimal.Parse(txtValorDos.Text);

            lblResultados.Text = "La resta es: " + (n - m);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            decimal n;
            decimal m;

            n = decimal.Parse(txtValorUno.Text);
            m = decimal.Parse(txtValorDos.Text);

            lblResultados.Text = "La divicion es: " + (n / m);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            decimal n;
            decimal m;

            n = decimal.Parse(txtValorUno.Text);
            m = decimal.Parse(txtValorDos.Text);

            lblResultados.Text = "La multiplicacion es: " + (n * m);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtValorUno.Clear();
            txtValorDos.Clear();
            lblResultados.Text = "";

            txtValorUno.Select();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
