namespace FormularioMDI
{
    partial class Convertidor
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
            groupBox1 = new GroupBox();
            txtMetros = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            lblMm = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMetros);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cantidad en metros";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(11, 27);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(155, 23);
            txtMetros.TabIndex = 0;
            txtMetros.TextChanged += textBox1_TextChanged;
            txtMetros.KeyPress += txtMetros_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(172, 44);
            button1.TabIndex = 1;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 144);
            button2.Name = "button2";
            button2.Size = new Size(172, 44);
            button2.TabIndex = 2;
            button2.Text = "FINALIZAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMm);
            groupBox2.Location = new Point(213, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 176);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equivalencias";
            // 
            // lblMm
            // 
            lblMm.Location = new Point(13, 31);
            lblMm.Name = "lblMm";
            lblMm.Size = new Size(181, 131);
            lblMm.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(249, 15);
            label1.TabIndex = 4;
            label1.Text = "Evaluacion Unidad I - Martin Arreguin Molina ";
            label1.Click += label1_Click;
            // 
            // Convertidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 228);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Convertidor";
            Load += Convertidor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMetros;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblMm;
    }
}