namespace GestorDeFormularios
{
    partial class Cálculo_de_Impuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cálculo_de_Impuestos));
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbImpuesto = new ComboBox();
            btnCalcular = new Button();
            lblTotal = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(180, 212);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(379, 31);
            txtMonto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(180, 159);
            label1.Name = "label1";
            label1.Size = new Size(379, 31);
            label1.TabIndex = 1;
            label1.Text = "Monto a calcular sin impuesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(180, 276);
            label2.Name = "label2";
            label2.Size = new Size(223, 31);
            label2.TabIndex = 2;
            label2.Text = "Tipo de impuesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(152, 487);
            label3.Name = "label3";
            label3.Size = new Size(254, 31);
            label3.TabIndex = 3;
            label3.Text = "Total con impuesto:";
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(180, 325);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(379, 33);
            cmbImpuesto.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Teal;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(266, 393);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(207, 56);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Teal;
            lblTotal.Location = new Point(427, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 28);
            lblTotal.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(152, 36);
            label4.Name = "label4";
            label4.Size = new Size(381, 45);
            label4.TabIndex = 7;
            label4.Text = "Calculo De Impuesto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.impuesto_sobre_la_renta;
            pictureBox1.Location = new Point(652, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Broadway", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(152, 81);
            label5.Name = "label5";
            label5.Size = new Size(674, 32);
            label5.TabIndex = 9;
            label5.Text = "____________________________________________";
            // 
            // Cálculo_de_Impuestos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 595);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(btnCalcular);
            Controls.Add(cmbImpuesto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cálculo_de_Impuestos";
            Text = "Cálculo_de_Impuestos";
            Load += Cálculo_de_Impuestos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbImpuesto;
        private Button btnCalcular;
        private Label lblTotal;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}