namespace FormularioMDI
{
    partial class Semaforo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semaforo));
            pictureBox1 = new PictureBox();
            botonCircular1 = new BotonCircular();
            botonCircular2 = new BotonCircular();
            botonCircular3 = new BotonCircular();
            ControlTiempoRojo = new NumericUpDown();
            groupBox1 = new GroupBox();
            lblVerde = new Label();
            lblAmarillo = new Label();
            ControlTiempoVerde = new NumericUpDown();
            ControlTiempoAmarillo = new NumericUpDown();
            lblRojo = new Label();
            btnIniciar = new Button();
            tiempoRojo = new System.Windows.Forms.Timer(components);
            tiempoAmarillo = new System.Windows.Forms.Timer(components);
            tiempoVerde = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ControlTiempoRojo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ControlTiempoVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ControlTiempoAmarillo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 368);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // botonCircular1
            // 
            botonCircular1.BackColor = Color.White;
            botonCircular1.BackgroundImageLayout = ImageLayout.None;
            botonCircular1.FlatAppearance.BorderColor = Color.Gray;
            botonCircular1.FlatAppearance.MouseDownBackColor = Color.Gray;
            botonCircular1.FlatAppearance.MouseOverBackColor = Color.Gray;
            botonCircular1.ForeColor = Color.White;
            botonCircular1.Location = new Point(110, 127);
            botonCircular1.Name = "botonCircular1";
            botonCircular1.Size = new Size(65, 64);
            botonCircular1.TabIndex = 2;
            botonCircular1.UseVisualStyleBackColor = false;
            botonCircular1.Click += botonCircular1_Click;
            // 
            // botonCircular2
            // 
            botonCircular2.BackColor = Color.White;
            botonCircular2.BackgroundImageLayout = ImageLayout.None;
            botonCircular2.FlatAppearance.BorderColor = Color.Gray;
            botonCircular2.FlatAppearance.MouseDownBackColor = Color.Gray;
            botonCircular2.FlatAppearance.MouseOverBackColor = Color.Gray;
            botonCircular2.ForeColor = Color.Gray;
            botonCircular2.Location = new Point(110, 197);
            botonCircular2.Name = "botonCircular2";
            botonCircular2.Size = new Size(65, 64);
            botonCircular2.TabIndex = 3;
            botonCircular2.UseVisualStyleBackColor = false;
            // 
            // botonCircular3
            // 
            botonCircular3.BackColor = Color.White;
            botonCircular3.BackgroundImageLayout = ImageLayout.None;
            botonCircular3.FlatAppearance.BorderColor = Color.Gray;
            botonCircular3.FlatAppearance.MouseDownBackColor = Color.Gray;
            botonCircular3.FlatAppearance.MouseOverBackColor = Color.Gray;
            botonCircular3.ForeColor = Color.Gray;
            botonCircular3.Location = new Point(110, 267);
            botonCircular3.Name = "botonCircular3";
            botonCircular3.Size = new Size(65, 64);
            botonCircular3.TabIndex = 4;
            botonCircular3.UseVisualStyleBackColor = false;
            // 
            // ControlTiempoRojo
            // 
            ControlTiempoRojo.Location = new Point(129, 41);
            ControlTiempoRojo.Name = "ControlTiempoRojo";
            ControlTiempoRojo.Size = new Size(120, 23);
            ControlTiempoRojo.TabIndex = 5;
            ControlTiempoRojo.ValueChanged += ControlTiempoRojo_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblVerde);
            groupBox1.Controls.Add(lblAmarillo);
            groupBox1.Controls.Add(ControlTiempoVerde);
            groupBox1.Controls.Add(ControlTiempoAmarillo);
            groupBox1.Controls.Add(lblRojo);
            groupBox1.Controls.Add(ControlTiempoRojo);
            groupBox1.Location = new Point(297, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 179);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controles del tiempo";
            // 
            // lblVerde
            // 
            lblVerde.BackColor = Color.Lime;
            lblVerde.ForeColor = Color.Black;
            lblVerde.Location = new Point(6, 129);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(100, 23);
            lblVerde.TabIndex = 11;
            // 
            // lblAmarillo
            // 
            lblAmarillo.BackColor = Color.Yellow;
            lblAmarillo.ForeColor = Color.Black;
            lblAmarillo.Location = new Point(6, 85);
            lblAmarillo.Name = "lblAmarillo";
            lblAmarillo.Size = new Size(100, 23);
            lblAmarillo.TabIndex = 10;
            // 
            // ControlTiempoVerde
            // 
            ControlTiempoVerde.Location = new Point(129, 127);
            ControlTiempoVerde.Name = "ControlTiempoVerde";
            ControlTiempoVerde.Size = new Size(120, 23);
            ControlTiempoVerde.TabIndex = 9;
            // 
            // ControlTiempoAmarillo
            // 
            ControlTiempoAmarillo.Location = new Point(129, 85);
            ControlTiempoAmarillo.Name = "ControlTiempoAmarillo";
            ControlTiempoAmarillo.Size = new Size(120, 23);
            ControlTiempoAmarillo.TabIndex = 8;
            // 
            // lblRojo
            // 
            lblRojo.BackColor = Color.Red;
            lblRojo.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRojo.ForeColor = Color.Black;
            lblRojo.Location = new Point(6, 43);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(100, 23);
            lblRojo.TabIndex = 7;
            lblRojo.Click += lblRojo_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.ForeColor = Color.Black;
            btnIniciar.Location = new Point(303, 197);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(251, 44);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button1_Click_1;
            // 
            // tiempoRojo
            // 
            tiempoRojo.Interval = 1000;
            tiempoRojo.Tick += tiempoRojo_Tick;
            // 
            // tiempoAmarillo
            // 
            tiempoAmarillo.Interval = 1000;
            tiempoAmarillo.Tick += tiempoAmarillo_Tick;
            // 
            // tiempoVerde
            // 
            tiempoVerde.Interval = 1000;
            tiempoVerde.Tick += tiempoVerde_Tick;
            // 
            // Semaforo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 386);
            Controls.Add(groupBox1);
            Controls.Add(botonCircular3);
            Controls.Add(botonCircular2);
            Controls.Add(botonCircular1);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciar);
            ForeColor = Color.Gray;
            Name = "Semaforo";
            Text = "Semaforo";
            Load += Semaforo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ControlTiempoRojo).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ControlTiempoVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)ControlTiempoAmarillo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private BotonCircular botonCircular1;
        private BotonCircular botonCircular2;
        private BotonCircular botonCircular3;
        private NumericUpDown ControlTiempoRojo;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer tiempoRojo;
        private Button btnIniciar;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAmarillo;
        private NumericUpDown ControlTiempoVerde;
        private NumericUpDown ControlTiempoAmarillo;
        private System.Windows.Forms.Timer tiempoAmarillo;
        private System.Windows.Forms.Timer tiempoVerde;
    }
}