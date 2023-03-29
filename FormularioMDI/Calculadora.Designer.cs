namespace FormularioMDI
{
    partial class Calculadora
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label1 = new Label();
            tabPage3 = new TabPage();
            button2 = new Button();
            label2 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(369, 187);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(361, 159);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculadora";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 61);
            button1.Name = "button1";
            button1.Size = new Size(241, 42);
            button1.TabIndex = 1;
            button1.Text = "Abrir calculadora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Programa que ejecuta una calculadora basica";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(361, 159);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Contador de cadenas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 88);
            button2.Name = "button2";
            button2.Size = new Size(282, 49);
            button2.TabIndex = 1;
            button2.Text = "Contador de cadenas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(282, 53);
            label2.TabIndex = 0;
            label2.Text = "Programa que recibe una cadena de texto y permite contabilizar los caracteres, letras y numeros se agregan funcionalidades de formato";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(361, 159);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Formulario Seguidor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(15, 85);
            button3.Name = "button3";
            button3.Size = new Size(248, 39);
            button3.TabIndex = 1;
            button3.Text = "Abrir Seguidor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Location = new Point(15, 17);
            label3.Name = "label3";
            label3.Size = new Size(248, 37);
            label3.TabIndex = 0;
            label3.Text = "Programa que permite visualizar el tamaño y posicion de un arreglo";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 211);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Calculadora";
            Text = "Form2";
            Load += Calculadora_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage3;
        private Button button1;
        private Button button2;
        private Label label2;
        private TabPage tabPage2;
        private Button button3;
        private Label label3;
    }
}