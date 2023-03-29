namespace FormularioMDI
{
    partial class AdivinaElNumero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdivinaElNumero));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnVerificar = new Button();
            label3 = new Label();
            label4 = new Label();
            GanasteGif = new PictureBox();
            PerdisteGIf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GanasteGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PerdisteGIf).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 33);
            label1.TabIndex = 0;
            label1.Text = "Sin Limite de tiempo";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(353, 33);
            label2.TabIndex = 1;
            label2.Text = "Puntos de esta partida 100";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(16, 158);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(96, 23);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label3
            // 
            label3.Location = new Point(27, 209);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(252, 112);
            label4.Name = "label4";
            label4.Size = new Size(113, 69);
            label4.TabIndex = 5;
            // 
            // GanasteGif
            // 
            GanasteGif.Image = (Image)resources.GetObject("GanasteGif.Image");
            GanasteGif.Location = new Point(144, 112);
            GanasteGif.Name = "GanasteGif";
            GanasteGif.Size = new Size(100, 69);
            GanasteGif.SizeMode = PictureBoxSizeMode.Zoom;
            GanasteGif.TabIndex = 6;
            GanasteGif.TabStop = false;
            // 
            // PerdisteGIf
            // 
            PerdisteGIf.BorderStyle = BorderStyle.FixedSingle;
            PerdisteGIf.Image = (Image)resources.GetObject("PerdisteGIf.Image");
            PerdisteGIf.Location = new Point(144, 112);
            PerdisteGIf.Name = "PerdisteGIf";
            PerdisteGIf.Size = new Size(100, 69);
            PerdisteGIf.SizeMode = PictureBoxSizeMode.Zoom;
            PerdisteGIf.TabIndex = 7;
            PerdisteGIf.TabStop = false;
            // 
            // AdivinaElNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 329);
            Controls.Add(PerdisteGIf);
            Controls.Add(GanasteGif);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnVerificar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdivinaElNumero";
            Text = "AdivinaElNumero";
            Load += AdivinaElNumero_Load;
            ((System.ComponentModel.ISupportInitialize)GanasteGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)PerdisteGIf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnVerificar;
        private Label label3;
        private Label label4;
        private PictureBox GanasteGif;
        private PictureBox PerdisteGIf;
    }
}