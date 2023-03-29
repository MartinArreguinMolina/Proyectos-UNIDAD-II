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
    public partial class ContadorCadenas : Form
    {
        ValidarContraseña vl = new ValidarContraseña();
        public ContadorCadenas()
        {
            InitializeComponent();
        }

        private void ContadorCadenas_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (vl.valirdarContraseña(txtContraseña.Text))
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFormato_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void checkBoxCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCaracteres.Checked)
            {
                lblCaracteres.Text = richTextBox1.Text.Length + " Caracteres";
            }
            else
            {
                lblCaracteres.Text = "";
            }
        }

        private void checkBoxLetras_CheckedChanged(object sender, EventArgs e)
        {
            int contador = 0;

            if (checkBoxLetras.Checked)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if ((int)richTextBox1.Text[i] >= 65 && (int)richTextBox1.Text[i] <= 90 || (int)richTextBox1.Text[i] >= 97 && (int)richTextBox1.Text[i] <= 122)
                    {
                        contador++;
                    }
                }

                lblLetras.Text = contador + " Letras";
            }
            else
            {
                lblLetras.Text = "";
            }
        }

        private void checkBoxNumeros_CheckedChanged(object sender, EventArgs e)
        {
            int contador = 0;

            if (checkBoxNumeros.Checked)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if ((int)richTextBox1.Text[i] >= 48 && (int)richTextBox1.Text[i] <= 57)
                    {
                        contador++;
                    }
                }
                lblNumeros.Text = contador + " Numeros";
            }
            else
            {
                lblNumeros.Text = "";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int contador = 0;
            int contadorDos = 0;

            if (checkBoxCaracteres.Checked)
            {
                lblCaracteres.Text = richTextBox1.Text.Length + " Caracteres";
            }
            else
            {
                lblCaracteres.Text = "";
            }

            if (checkBoxNumeros.Checked)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if ((int)richTextBox1.Text[i] >= 48 && (int)richTextBox1.Text[i] <= 57)
                    {
                        contador++;
                    }
                }

                lblNumeros.Text = contador + " Numeros";
            }
            else
            {
                lblNumeros.Text = "";
            }

            if (checkBoxLetras.Checked)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if ((int)richTextBox1.Text[i] >= 65 && (int)richTextBox1.Text[i] <= 90 || (int)richTextBox1.Text[i] >= 97 && (int)richTextBox1.Text[i] <= 122)
                    {
                        contadorDos++;
                    }
                }

                lblLetras.Text = contadorDos + " Letras";
            }
            else
            {
                lblLetras.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
