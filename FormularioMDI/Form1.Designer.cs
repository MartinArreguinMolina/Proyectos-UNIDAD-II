namespace FormularioMDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            proyectosToolStripMenuItem = new ToolStripMenuItem();
            convertidorToolStripMenuItem = new ToolStripMenuItem();
            semaforoToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            analizadorToolStripMenuItem = new ToolStripMenuItem();
            seguidorToolStripMenuItem = new ToolStripMenuItem();
            numeroNToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, proyectosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem1 });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(60, 20);
            salirToolStripMenuItem.Text = "Archivo";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(96, 22);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // proyectosToolStripMenuItem
            // 
            proyectosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertidorToolStripMenuItem, semaforoToolStripMenuItem, calculadoraToolStripMenuItem, analizadorToolStripMenuItem, seguidorToolStripMenuItem, numeroNToolStripMenuItem });
            proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            proyectosToolStripMenuItem.Size = new Size(71, 20);
            proyectosToolStripMenuItem.Text = "Proyectos";
            proyectosToolStripMenuItem.Click += proyectosToolStripMenuItem_Click;
            // 
            // convertidorToolStripMenuItem
            // 
            convertidorToolStripMenuItem.Name = "convertidorToolStripMenuItem";
            convertidorToolStripMenuItem.Size = new Size(180, 22);
            convertidorToolStripMenuItem.Text = "Convertidor";
            convertidorToolStripMenuItem.Click += convertidorToolStripMenuItem_Click;
            // 
            // semaforoToolStripMenuItem
            // 
            semaforoToolStripMenuItem.Name = "semaforoToolStripMenuItem";
            semaforoToolStripMenuItem.Size = new Size(180, 22);
            semaforoToolStripMenuItem.Text = "Semaforo";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(180, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // analizadorToolStripMenuItem
            // 
            analizadorToolStripMenuItem.Name = "analizadorToolStripMenuItem";
            analizadorToolStripMenuItem.Size = new Size(180, 22);
            analizadorToolStripMenuItem.Text = "Analizador";
            // 
            // seguidorToolStripMenuItem
            // 
            seguidorToolStripMenuItem.Name = "seguidorToolStripMenuItem";
            seguidorToolStripMenuItem.Size = new Size(180, 22);
            seguidorToolStripMenuItem.Text = "Seguidor";
            // 
            // numeroNToolStripMenuItem
            // 
            numeroNToolStripMenuItem.Name = "numeroNToolStripMenuItem";
            numeroNToolStripMenuItem.Size = new Size(180, 22);
            numeroNToolStripMenuItem.Text = "Numero N";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem proyectosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem convertidorToolStripMenuItem;
        private ToolStripMenuItem semaforoToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem analizadorToolStripMenuItem;
        private ToolStripMenuItem seguidorToolStripMenuItem;
        private ToolStripMenuItem numeroNToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}