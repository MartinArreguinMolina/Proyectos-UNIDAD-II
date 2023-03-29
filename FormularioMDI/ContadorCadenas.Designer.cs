namespace FormularioMDI
{
    partial class ContadorCadenas
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
            txtContraseña = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnFormato = new Button();
            btnDerecha = new Button();
            btnCentro = new Button();
            btnIzquierda = new Button();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            checkBoxCaracteres = new CheckBox();
            checkBoxLetras = new CheckBox();
            checkBoxNumeros = new CheckBox();
            lblCaracteres = new Label();
            lblLetras = new Label();
            lblNumeros = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(356, 22);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(161, 23);
            txtContraseña.TabIndex = 0;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su password para habilitar la interfaz";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFormato);
            groupBox1.Controls.Add(btnDerecha);
            groupBox1.Controls.Add(btnCentro);
            groupBox1.Controls.Add(btnIzquierda);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(21, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnFormato
            // 
            btnFormato.Location = new Point(287, 175);
            btnFormato.Name = "btnFormato";
            btnFormato.Size = new Size(203, 43);
            btnFormato.TabIndex = 4;
            btnFormato.Text = "Formato de texto";
            btnFormato.UseVisualStyleBackColor = true;
            btnFormato.Click += btnFormato_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(287, 126);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(203, 43);
            btnDerecha.TabIndex = 3;
            btnDerecha.Text = "Alinear a la derecha";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // btnCentro
            // 
            btnCentro.Location = new Point(287, 77);
            btnCentro.Name = "btnCentro";
            btnCentro.Size = new Size(203, 43);
            btnCentro.TabIndex = 2;
            btnCentro.Text = "Alinear al centro";
            btnCentro.UseVisualStyleBackColor = true;
            btnCentro.Click += btnCentro_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(287, 28);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(203, 43);
            btnIzquierda.TabIndex = 1;
            btnIzquierda.Text = "Alinear a la izquierda";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(10, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(252, 204);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // checkBoxCaracteres
            // 
            checkBoxCaracteres.AutoSize = true;
            checkBoxCaracteres.Location = new Point(21, 335);
            checkBoxCaracteres.Name = "checkBoxCaracteres";
            checkBoxCaracteres.Size = new Size(120, 19);
            checkBoxCaracteres.TabIndex = 3;
            checkBoxCaracteres.Text = "Contar Caracteres";
            checkBoxCaracteres.UseVisualStyleBackColor = true;
            checkBoxCaracteres.CheckedChanged += checkBoxCaracteres_CheckedChanged;
            // 
            // checkBoxLetras
            // 
            checkBoxLetras.AutoSize = true;
            checkBoxLetras.Location = new Point(21, 375);
            checkBoxLetras.Name = "checkBoxLetras";
            checkBoxLetras.Size = new Size(96, 19);
            checkBoxLetras.TabIndex = 4;
            checkBoxLetras.Text = "Contar Letras";
            checkBoxLetras.UseVisualStyleBackColor = true;
            checkBoxLetras.CheckedChanged += checkBoxLetras_CheckedChanged;
            // 
            // checkBoxNumeros
            // 
            checkBoxNumeros.AutoSize = true;
            checkBoxNumeros.Location = new Point(21, 410);
            checkBoxNumeros.Name = "checkBoxNumeros";
            checkBoxNumeros.Size = new Size(114, 19);
            checkBoxNumeros.TabIndex = 5;
            checkBoxNumeros.Text = "Contar Numeros";
            checkBoxNumeros.UseVisualStyleBackColor = true;
            checkBoxNumeros.CheckedChanged += checkBoxNumeros_CheckedChanged;
            // 
            // lblCaracteres
            // 
            lblCaracteres.Location = new Point(401, 331);
            lblCaracteres.Name = "lblCaracteres";
            lblCaracteres.Size = new Size(100, 23);
            lblCaracteres.TabIndex = 6;
            // 
            // lblLetras
            // 
            lblLetras.Location = new Point(401, 371);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(100, 23);
            lblLetras.TabIndex = 7;
            // 
            // lblNumeros
            // 
            lblNumeros.Location = new Point(401, 406);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(100, 23);
            lblNumeros.TabIndex = 8;
            // 
            // ContadorCadenas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 441);
            Controls.Add(lblNumeros);
            Controls.Add(lblLetras);
            Controls.Add(lblCaracteres);
            Controls.Add(checkBoxNumeros);
            Controls.Add(checkBoxLetras);
            Controls.Add(checkBoxCaracteres);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Name = "ContadorCadenas";
            Text = "Form2";
            Load += ContadorCadenas_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContraseña;
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button btnFormato;
        private Button btnDerecha;
        private Button btnCentro;
        private Button btnIzquierda;
        private FontDialog fontDialog1;
        private CheckBox checkBoxCaracteres;
        private CheckBox checkBoxLetras;
        private CheckBox checkBoxNumeros;
        private Label lblCaracteres;
        private Label lblLetras;
        private Label lblNumeros;
    }
}