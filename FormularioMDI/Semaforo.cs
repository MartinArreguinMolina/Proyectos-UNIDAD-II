using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FormularioMDI
{
    public partial class Semaforo : Form
    {
        decimal rojo;
        decimal verde;
        decimal amarillo;
        public Semaforo()
        {
            InitializeComponent();
        }

        private void Semaforo_Load(object sender, EventArgs e)
        {
            ControlTiempoRojo.Maximum = 60;
            ControlTiempoRojo.Minimum = 1;
            ControlTiempoAmarillo.Maximum = 60;
            ControlTiempoAmarillo.Minimum = 1;
            ControlTiempoVerde.Maximum = 60;
            ControlTiempoVerde.Minimum = 1;

            iniciarlizarTempos();
        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ControlTiempoRojo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tiempoRojo_Tick(object sender, EventArgs e)
        {

            if (rojo >= 1)
            {
                lblVerde.Text = "";
                botonCircular3.Visible = true;
                lblRojo.Text = rojo.ToString();

                rojo -= 1;

                botonCircular1.Visible = false;

                if (rojo == 0)
                {
                    tiempoRojo.Stop();
                    tiempoAmarillo.Start();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btnIniciar.Text.Equals("INICIAR"))
            {
                leerDatos();
                iniciarTiempos();

                groupBox1.Enabled = false;
                btnIniciar.Text = "DETENER";
            }
            else if (btnIniciar.Text.Equals("DETENER"))
            {
                iniciarlizarTempos();
                iniciarImagenes();
                iniciarLabel();

                groupBox1.Enabled = true;
                btnIniciar.Text = "INICIAR";
                detenerTiempos();
                ControlTiempoRojo.Select();
            }
        }

        private void lblRojo_Click(object sender, EventArgs e)
        {

        }

        private void tiempoAmarillo_Tick(object sender, EventArgs e)
        {
            if (amarillo >= 1 && rojo == 0)
            {
                lblRojo.Text = "";
                botonCircular1.Visible = true;
                lblAmarillo.Text = amarillo.ToString();

                amarillo -= 1;

                botonCircular2.Visible = false;

                if (amarillo == 0)
                {
                    tiempoAmarillo.Stop();
                    tiempoVerde.Start();
                }
            }
        }

        private void tiempoVerde_Tick(object sender, EventArgs e)
        {
            if (verde >= 1 && rojo == 0 && amarillo == 0)
            {
                lblAmarillo.Text = "";
                botonCircular2.Visible = true;
                lblVerde.Text = verde.ToString();

                verde -= 1;

                botonCircular3.Visible = false;

                if (verde == 0)
                {
                    tiempoVerde.Stop();

                    leerDatos();
                    iniciarTiempos();
                }
            }

        }

        private void leerDatos()
        {
            rojo = ControlTiempoRojo.Value;
            amarillo = ControlTiempoAmarillo.Value;
            verde = ControlTiempoVerde.Value;
        }

        private void iniciarTiempos()
        {
            tiempoRojo.Start();
        }

        private void detenerTiempos()
        {
            tiempoRojo.Stop();
            tiempoAmarillo.Stop();
            tiempoVerde.Stop();
        }

        public void iniciarlizarTempos()
        {
            ControlTiempoRojo.Value = 1;
            ControlTiempoAmarillo.Value = 1;
            ControlTiempoVerde.Value = 1;
        }

        private void iniciarImagenes()
        {
            botonCircular1.Visible = true;
            botonCircular2.Visible = true;
            botonCircular3.Visible = true;
        }

        private void iniciarLabel()
        {
            lblRojo.Text = "";
            lblAmarillo.Text = "";
            lblVerde.Text = "";
        }
    }
}
