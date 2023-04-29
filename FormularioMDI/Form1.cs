namespace FormularioMDI
{
    public partial class Form1 : Form
    {
        Inicio obs;
        int tiempo = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convertidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convertidor ob1 = new Convertidor();
            ob1.MdiParent = this;
            ob1.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora ob2 = new Calculadora();
            ob2.MdiParent = this;
            ob2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void semaforoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Semaforo ob1 = new Semaforo();
            ob1.MdiParent = this;
            ob1.Show();
        }

        private void numeroNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo = 2;
            obs = new Inicio();
            obs.MdiParent = this;
            obs.Show();
            tiempoMagico.Start();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDePrincipal ob1 = new AcercaDePrincipal();
            ob1.MdiParent = this;
            ob1.Show();
        }

        private void tiempoMagico_Tick(object sender, EventArgs e)
        {
            if (tiempo > 0)
            {
                tiempo--;
                if (tiempo == 0)
                {
                    tiempoMagico.Stop();
                    obs.Dispose();
                    NumeroMagico ob1 = new NumeroMagico();
                    ob1.MdiParent = this;
                    ob1.Show();
                }
            }
        }
    }
}