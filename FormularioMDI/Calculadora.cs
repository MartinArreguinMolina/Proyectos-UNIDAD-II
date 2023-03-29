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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculadoraBasica ob1 = new CalculadoraBasica();
            ob1.MdiParent = this.MdiParent;
            ob1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContadorCadenas ob1 = new ContadorCadenas();
            ob1.MdiParent = this.MdiParent;
            ob1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seguidor ob1 = new Seguidor();
            ob1.MdiParent = this.MdiParent;
            ob1.Show();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
