namespace FormularioMDI
{
    partial class Seguidor
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
            checkBoxSeguidor = new CheckBox();
            lblX = new Label();
            lblY = new Label();
            SuspendLayout();
            // 
            // checkBoxSeguidor
            // 
            checkBoxSeguidor.AutoSize = true;
            checkBoxSeguidor.Location = new Point(12, 12);
            checkBoxSeguidor.Name = "checkBoxSeguidor";
            checkBoxSeguidor.Size = new Size(117, 19);
            checkBoxSeguidor.TabIndex = 0;
            checkBoxSeguidor.Text = "Mostrar Seguidor";
            checkBoxSeguidor.UseVisualStyleBackColor = true;
            checkBoxSeguidor.CheckedChanged += checkBoxSeguidor_CheckedChanged;
            // 
            // lblX
            // 
            lblX.Location = new Point(16, 46);
            lblX.Name = "lblX";
            lblX.Size = new Size(100, 23);
            lblX.TabIndex = 1;
            lblX.Click += lblX_Click;
            // 
            // lblY
            // 
            lblY.Location = new Point(18, 93);
            lblY.Name = "lblY";
            lblY.Size = new Size(100, 23);
            lblY.TabIndex = 2;
            // 
            // Seguidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 127);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(checkBoxSeguidor);
            Name = "Seguidor";
            Text = "Seguidor";
            Load += Seguidor_Load;
            LocationChanged += checkBoxSeguidor_CheckedChanged;
            SizeChanged += checkBoxSeguidor_CheckedChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxSeguidor;
        private Label lblX;
        private Label lblY;
    }
}