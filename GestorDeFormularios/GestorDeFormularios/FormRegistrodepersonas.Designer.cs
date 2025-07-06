namespace GestorDeFormularios
{
    partial class FrmRegistropersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistropersonas));
            txtNombre = new TextBox();
            label1 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cmbSexo = new ComboBox();
            btnAgregar = new Button();
            dgvPersonas = new DataGridView();
            btnLimpiar = new Button();
            cmbEstadoCivil = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtNacionalidad = new TextBox();
            label7 = new Label();
            txtOcupación = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label9 = new Label();
            txtTeléfono = new TextBox();
            label10 = new Label();
            txtDirección = new TextBox();
            label11 = new Label();
            txtNivelEducativo = new TextBox();
            label12 = new Label();
            txtCédula = new TextBox();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNombre.Location = new Point(313, 279);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 33);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(208, 279);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI Symbol", 9.75F);
            dtpFechaNacimiento.Location = new Point(221, 584);
            dtpFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(323, 33);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(643, 584);
            cmbSexo.Margin = new Padding(4, 5, 4, 5);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(171, 36);
            cmbSexo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(1241, 321);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 47);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(11, 692);
            dgvPersonas.Margin = new Padding(4, 5, 4, 5);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(1691, 307);
            dgvPersonas.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MidnightBlue;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(1241, 389);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 47);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado" });
            cmbEstadoCivil.Location = new Point(951, 584);
            cmbEstadoCivil.Margin = new Padding(4, 5, 4, 5);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(171, 36);
            cmbEstadoCivil.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label2.Location = new Point(643, 554);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 9;
            label2.Text = " Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label3.Location = new Point(951, 554);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 26);
            label3.TabIndex = 10;
            label3.Text = "Estado Civil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label4.Location = new Point(221, 537);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 26);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(523, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 26);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Symbol", 9.75F);
            txtApellido.Location = new Point(611, 279);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(188, 33);
            txtApellido.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(523, 426);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 26);
            label6.TabIndex = 17;
            label6.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNacionalidad.Location = new Point(658, 417);
            txtNacionalidad.Margin = new Padding(4, 5, 4, 5);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(141, 33);
            txtNacionalidad.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(208, 422);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 26);
            label7.TabIndex = 15;
            label7.Text = "Ocupación";
            // 
            // txtOcupación
            // 
            txtOcupación.Font = new Font("Segoe UI Symbol", 9.75F);
            txtOcupación.Location = new Point(330, 417);
            txtOcupación.Margin = new Padding(4, 5, 4, 5);
            txtOcupación.Name = "txtOcupación";
            txtOcupación.Size = new Size(141, 33);
            txtOcupación.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(523, 351);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 26);
            label8.TabIndex = 21;
            label8.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCorreo.Location = new Point(611, 347);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(188, 33);
            txtCorreo.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(208, 347);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 26);
            label9.TabIndex = 19;
            label9.Text = "Teléfono";
            // 
            // txtTeléfono
            // 
            txtTeléfono.Font = new Font("Segoe UI Symbol", 9.75F);
            txtTeléfono.Location = new Point(313, 347);
            txtTeléfono.Margin = new Padding(4, 5, 4, 5);
            txtTeléfono.Name = "txtTeléfono";
            txtTeléfono.Size = new Size(158, 33);
            txtTeléfono.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(840, 359);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 26);
            label10.TabIndex = 27;
            label10.Text = "Dirección";
            // 
            // txtDirección
            // 
            txtDirección.Font = new Font("Segoe UI Symbol", 9.75F);
            txtDirección.Location = new Point(951, 354);
            txtDirección.Margin = new Padding(4, 5, 4, 5);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(197, 33);
            txtDirección.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(850, 434);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(166, 26);
            label11.TabIndex = 25;
            label11.Text = "Nivel Educativo";
            // 
            // txtNivelEducativo
            // 
            txtNivelEducativo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNivelEducativo.Location = new Point(1007, 429);
            txtNivelEducativo.Margin = new Padding(4, 5, 4, 5);
            txtNivelEducativo.Name = "txtNivelEducativo";
            txtNivelEducativo.Size = new Size(141, 33);
            txtNivelEducativo.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(840, 291);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(80, 26);
            label12.TabIndex = 23;
            label12.Text = "Cédula";
            // 
            // txtCédula
            // 
            txtCédula.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCédula.Location = new Point(933, 286);
            txtCédula.Margin = new Padding(4, 5, 4, 5);
            txtCédula.Name = "txtCédula";
            txtCédula.Size = new Size(215, 33);
            txtCédula.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MidnightBlue;
            label13.Location = new Point(208, 86);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(668, 45);
            label13.TabIndex = 28;
            label13.Text = "Ingrese Todos Los Datos Requeridos.";
            label13.Click += label13_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.registrado;
            pictureBox1.Location = new Point(901, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(192, 159);
            label14.Name = "label14";
            label14.Size = new Size(703, 24);
            label14.TabIndex = 30;
            label14.Text = "_______________________________________________________________";
            // 
            // FrmRegistropersonas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1726, 1050);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(txtDirección);
            Controls.Add(label11);
            Controls.Add(txtNivelEducativo);
            Controls.Add(label12);
            Controls.Add(txtCédula);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(txtTeléfono);
            Controls.Add(label6);
            Controls.Add(txtNacionalidad);
            Controls.Add(label7);
            Controls.Add(txtOcupación);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPersonas);
            Controls.Add(btnAgregar);
            Controls.Add(cmbSexo);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            ForeColor = Color.MidnightBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmRegistropersonas";
            Text = "Registro de personas";
            Load += FrmRegistropersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbSexo;
        private Button btnAgregar;
        private DataGridView dgvPersonas;
        private Button btnLimpiar;
        private ComboBox cmbEstadoCivil;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private Label label6;
        private TextBox txtNacionalidad;
        private Label label7;
        private TextBox txtOcupación;
        private Label label8;
        private TextBox txtCorreo;
        private Label label9;
        private TextBox txtTeléfono;
        private Label label10;
        private TextBox txtDirección;
        private Label label11;
        private TextBox txtNivelEducativo;
        private Label label12;
        private TextBox txtCédula;
        private Label label13;
        private PictureBox pictureBox1;
        private Label label14;
    }
}