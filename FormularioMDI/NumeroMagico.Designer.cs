namespace FormularioMDI
{
    partial class NumeroMagico
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
            btnAcercaDe = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            checkBoxRelog = new CheckBox();
            groupBox3 = new GroupBox();
            ControlHasta = new NumericUpDown();
            ControlDesde = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtNombre = new TextBox();
            btnIniciarPartida = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ControlHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ControlDesde).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Location = new Point(12, 12);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(84, 23);
            btnAcercaDe.TabIndex = 0;
            btnAcercaDe.Text = "Informacion";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personaliza tu partida";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(checkBoxRelog);
            groupBox4.Location = new Point(204, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(220, 175);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Incrementa la emocion";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label3
            // 
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(178, 62);
            label3.TabIndex = 1;
            label3.Text = "En esta modalidad podras intentar adivinar el numero magivo sin preciones de tiempo Contaras con";
            // 
            // checkBoxRelog
            // 
            checkBoxRelog.AutoSize = true;
            checkBoxRelog.Location = new Point(11, 33);
            checkBoxRelog.Name = "checkBoxRelog";
            checkBoxRelog.Size = new Size(121, 19);
            checkBoxRelog.TabIndex = 0;
            checkBoxRelog.Text = "Jugar contra relog";
            checkBoxRelog.UseVisualStyleBackColor = true;
            checkBoxRelog.CheckedChanged += checkBoxRelog_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ControlHasta);
            groupBox3.Controls.Add(ControlDesde);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(6, 101);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(171, 96);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Indica el rango de valores";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // ControlHasta
            // 
            ControlHasta.Location = new Point(80, 64);
            ControlHasta.Name = "ControlHasta";
            ControlHasta.Size = new Size(84, 23);
            ControlHasta.TabIndex = 3;
            ControlHasta.ValueChanged += ControlHasta_ValueChanged;
            // 
            // ControlDesde
            // 
            ControlDesde.Location = new Point(80, 25);
            ControlDesde.Name = "ControlDesde";
            ControlDesde.Size = new Size(85, 23);
            ControlDesde.TabIndex = 2;
            ControlDesde.ValueChanged += ControlDesde_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 73);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Indica tu Nickname";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnIniciarPartida
            // 
            btnIniciarPartida.Location = new Point(18, 281);
            btnIniciarPartida.Name = "btnIniciarPartida";
            btnIniciarPartida.Size = new Size(418, 56);
            btnIniciarPartida.TabIndex = 2;
            btnIniciarPartida.Text = "INICIAR PARTIDA";
            btnIniciarPartida.UseVisualStyleBackColor = true;
            btnIniciarPartida.Click += btnIniciarPartida_Click;
            // 
            // NumeroMagico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 349);
            Controls.Add(btnIniciarPartida);
            Controls.Add(groupBox1);
            Controls.Add(btnAcercaDe);
            Name = "NumeroMagico";
            Text = "NumeroMagico";
            Load += NumeroMagico_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ControlHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ControlDesde).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAcercaDe;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNombre;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox checkBoxRelog;
        private NumericUpDown ControlHasta;
        private NumericUpDown ControlDesde;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnIniciarPartida;
    }
}