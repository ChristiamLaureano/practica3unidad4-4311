namespace GestorDeFormularios
{
    partial class Conversordivisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversordivisas));
            txtmonto = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResultado = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtmonto
            // 
            txtmonto.Font = new Font("Microsoft YaHei UI", 9F);
            txtmonto.Location = new Point(138, 196);
            txtmonto.Margin = new Padding(4, 5, 4, 5);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(225, 30);
            txtmonto.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            cmbOrigen.Font = new Font("Microsoft YaHei UI", 9F);
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "CNY", "DOP" });
            cmbOrigen.Location = new Point(134, 373);
            cmbOrigen.Margin = new Padding(4, 5, 4, 5);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(255, 32);
            cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            cmbDestino.Font = new Font("Microsoft YaHei UI", 9F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "CNY", "DOP" });
            cmbDestino.Location = new Point(547, 373);
            cmbDestino.Margin = new Padding(4, 5, 4, 5);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(255, 32);
            cmbDestino.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.DarkGreen;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.ForeColor = SystemColors.ButtonHighlight;
            btnConvertir.Location = new Point(373, 469);
            btnConvertir.Margin = new Padding(4, 5, 4, 5);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(191, 55);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(138, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 45);
            label1.TabIndex = 4;
            label1.Text = "Conversor de Divisas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(134, 611);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 31);
            label2.TabIndex = 5;
            label2.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial Black", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.DarkGreen;
            lblResultado.Location = new Point(301, 611);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 31);
            lblResultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(135, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 31);
            label4.TabIndex = 7;
            label4.Text = "Monto a convertir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(134, 337);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 31);
            label5.TabIndex = 8;
            label5.Text = "Moneda origen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(547, 337);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 31);
            label6.TabIndex = 9;
            label6.Text = "Moneda destino";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cambio_de_divisas;
            pictureBox1.Location = new Point(609, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(99, 77);
            label3.Name = "label3";
            label3.Size = new Size(703, 24);
            label3.TabIndex = 11;
            label3.Text = "_______________________________________________________________";
            // 
            // Conversordivisas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtmonto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Conversordivisas";
            Text = "conversordivisas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmonto;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label label1;
        private Label label2;
        private Label lblResultado;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label3;
    }
}