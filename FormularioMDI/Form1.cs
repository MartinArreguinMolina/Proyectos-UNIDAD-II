namespace FormularioMDI
{
    public partial class Form1 : Form
    {
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
    }
}