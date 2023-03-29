namespace FormularioMDI
{
    partial class Coordenadas
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
            lblAncho = new Label();
            lblAlto = new Label();
            lblArriba = new Label();
            lblIzquierda = new Label();
            SuspendLayout();
            // 
            // lblAncho
            // 
            lblAncho.Location = new Point(12, 9);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(100, 23);
            lblAncho.TabIndex = 0;
            lblAncho.Click += lblAncho_Click;
            // 
            // lblAlto
            // 
            lblAlto.Location = new Point(13, 47);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(100, 23);
            lblAlto.TabIndex = 1;
            // 
            // lblArriba
            // 
            lblArriba.Location = new Point(158, 9);
            lblArriba.Name = "lblArriba";
            lblArriba.Size = new Size(100, 23);
            lblArriba.TabIndex = 2;
            lblArriba.Click += lblArriba_Click;
            // 
            // lblIzquierda
            // 
            lblIzquierda.Location = new Point(158, 54);
            lblIzquierda.Name = "lblIzquierda";
            lblIzquierda.Size = new Size(100, 23);
            lblIzquierda.TabIndex = 3;
            // 
            // Coordenadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 86);
            ControlBox = false;
            Controls.Add(lblIzquierda);
            Controls.Add(lblArriba);
            Controls.Add(lblAlto);
            Controls.Add(lblAncho);
            Name = "Coordenadas";
            Load += Coordenadas_Load;
            LocationChanged += Coordenadas_Load;
            SizeChanged += Coordenadas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblAncho;
        private Label lblAlto;
        private Label lblArriba;
        private Label lblIzquierda;
    }
}