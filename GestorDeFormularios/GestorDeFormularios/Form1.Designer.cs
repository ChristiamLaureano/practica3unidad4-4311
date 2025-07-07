namespace GestorDeFormularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            registroDePersonaToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            cálculoDeImpuestosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroDePersonaToolStripMenuItem, conversorDeDivisasToolStripMenuItem, cálculoDeImpuestosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // registroDePersonaToolStripMenuItem
            // 
            registroDePersonaToolStripMenuItem.Name = "registroDePersonaToolStripMenuItem";
            registroDePersonaToolStripMenuItem.Size = new Size(187, 29);
            registroDePersonaToolStripMenuItem.Text = "Registro de persona";
            registroDePersonaToolStripMenuItem.Click += registroDePersonaToolStripMenuItem_Click;
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(194, 29);
            conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            conversorDeDivisasToolStripMenuItem.Click += conversorDeDivisasToolStripMenuItem_Click;
            // 
            // cálculoDeImpuestosToolStripMenuItem
            // 
            cálculoDeImpuestosToolStripMenuItem.Name = "cálculoDeImpuestosToolStripMenuItem";
            cálculoDeImpuestosToolStripMenuItem.Size = new Size(199, 29);
            cálculoDeImpuestosToolStripMenuItem.Text = "Cálculo de Impuestos";
            cálculoDeImpuestosToolStripMenuItem.Click += cálculoDeImpuestosToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            Text = "Gestor De Formularios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registroDePersonaToolStripMenuItem;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private ToolStripMenuItem cálculoDeImpuestosToolStripMenuItem;
    }
}
