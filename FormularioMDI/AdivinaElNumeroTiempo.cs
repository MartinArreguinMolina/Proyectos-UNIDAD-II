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
    public partial class AdivinaElNumeroTiempo : Form
    {

        ValidarNumeroMagico ob1 = new ValidarNumeroMagico();
        int tiempoLimiteSegundos;
        int numeroAleatorio;
        int puntos = 100;
        string nombreUsuario;

        public AdivinaElNumeroTiempo()
        {
            InitializeComponent();
        }

        private void AdivinaElNumeroTiempo_Load(object sender, EventArgs e)
        {
            TiempoRestante.Start();
            btnVerificar.Enabled = false;
            GanasteGif.Visible = false;
            PerdisteGIf.Visible = false;
            label1.Text = "Tiempo restante: " + tiempoLimiteSegundos.ToString();
            label2.Text = "Puntos de esta partida " + puntos;
        }

        public void tiempoLimite(int n)
        {
            tiempoLimiteSegundos = n;
        }

        private void TiempoRestante_Tick(object sender, EventArgs e)
        {
            tiempoLimiteSegundos -= 1;

            if (tiempoLimiteSegundos == 0)
            {
                TiempoRestante.Stop();
                MessageBox.Show("Tu tiempo se a agotado");
                label1.Text = "Tiempo restante: " + tiempoLimiteSegundos.ToString();
                textBox1.Enabled = false;
                btnVerificar.Enabled = false;
            }
            else
            {
                label1.Text = "Tiempo restante: " + tiempoLimiteSegundos.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                btnVerificar.Enabled = false;
            }
            else
            {
                btnVerificar.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !ob1.validarNumeros(e.KeyChar);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text);

            if (numeroAleatorio == n)
            {
                TiempoRestante.Stop();
                MessageBox.Show("Felicidades " + nombreUsuario + ", Ganaste");
                btnVerificar.Enabled = false;
                textBox1.Enabled = false;
                GanasteGif.Visible = true;
                PerdisteGIf.Visible = false;
                label4.Text = "GANASTE!!!!";
            }
            else
            {
                if (numeroAleatorio < n)
                {
                    label4.Text = "El numero magico es menor";
                }
                else
                {
                    label4.Text = "El numero magico es mayor";
                }
                puntos -= 10;
                label2.Text = "Puntos de esta partida " + puntos;
                PerdisteGIf.Visible = true;
                GanasteGif.Visible = false;

                if (puntos == 0)
                {
                    TiempoRestante.Stop();
                    btnVerificar.Enabled = false;
                    textBox1.Enabled = false;
                    label4.Text = "Has perdidio esta partida :(";
                    MessageBox.Show("Has perdido todos tus puntos!");
                }

                textBox1.Text = "";
                textBox1.Select();
            }

        }

        public void numAleatorio(int n)
        {
            numeroAleatorio = n;
        }

        public void nombre(string nombre)
        {
            nombreUsuario = nombre;
        }
    }
}
