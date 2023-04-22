namespace FormularioMDI
{
    partial class CalculadoraBasica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtValorUno = new TextBox();
            label2 = new Label();
            txtValorDos = new TextBox();
            groupBox1 = new GroupBox();
            lblResultados = new Label();
            groupBox2 = new GroupBox();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            btnReiniciar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 0;
            label1.Text = "Valor 1: ";
            label1.Click += label1_Click;
            // 
            // txtValorUno
            // 
            txtValorUno.Location = new Point(82, 16);
            txtValorUno.Name = "txtValorUno";
            txtValorUno.Size = new Size(100, 23);
            txtValorUno.TabIndex = 1;
            txtValorUno.TextChanged += txtValorUno_TextChanged;
            txtValorUno.KeyPress += txtValorUno_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor 2: ";
            // 
            // txtValorDos
            // 
            txtValorDos.Location = new Point(82, 52);
            txtValorDos.Name = "txtValorDos";
            txtValorDos.Size = new Size(100, 23);
            txtValorDos.TabIndex = 3;
            txtValorDos.TextChanged += txtValorDos_TextChanged;
            txtValorDos.KeyPress += txtValorDos_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultados);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtValorUno);
            groupBox1.Controls.Add(txtValorDos);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 134);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblResultados
            // 
            lblResultados.Location = new Point(193, 89);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(158, 32);
            lblResultados.TabIndex = 4;
            lblResultados.Click += lblResultados_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMultiplicar);
            groupBox2.Controls.Add(btnDividir);
            groupBox2.Controls.Add(btnRestar);
            groupBox2.Controls.Add(btnSumar);
            groupBox2.Location = new Point(15, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 201);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(20, 147);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(315, 32);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "MULTIPLICAR";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(19, 109);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(315, 32);
            btnDividir.TabIndex = 2;
            btnDividir.Text = "DIVIDIR";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(20, 71);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(315, 32);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "RESTAR";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(19, 34);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(315, 32);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "SUMAR";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(36, 376);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(314, 33);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.Text = "REINICIAR CALCULADORA";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // CalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 433);
            Controls.Add(btnReiniciar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CalculadoraBasica";
            Text = "ARREGUIN MOLINA MARTIN - CALCULADORA";
            Load += CalculadoraBasica_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtValorUno;
        private Label label2;
        private TextBox txtValorDos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnReiniciar;
        private Label lblResultados;
    }
}