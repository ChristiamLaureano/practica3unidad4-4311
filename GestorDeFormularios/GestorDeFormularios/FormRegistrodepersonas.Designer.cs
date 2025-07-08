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
            btnEliminar = new Button();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNombre.Location = new Point(290, 167);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 25);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(217, 167);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI Symbol", 9.75F);
            dtpFechaNacimiento.Location = new Point(226, 350);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(227, 25);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(521, 350);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 25);
            cmbSexo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(228, 423);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 35);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(12, 492);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(1184, 184);
            dgvPersonas.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MidnightBlue;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(387, 423);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(141, 35);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado" });
            cmbEstadoCivil.Location = new Point(737, 350);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 25);
            cmbEstadoCivil.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label2.Location = new Point(521, 332);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 9;
            label2.Text = " Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label3.Location = new Point(737, 332);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 10;
            label3.Text = "Estado Civil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label4.Location = new Point(226, 322);
            label4.Name = "label4";
            label4.Size = new Size(147, 17);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(437, 169);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Symbol", 9.75F);
            txtApellido.Location = new Point(499, 167);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 25);
            txtApellido.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(437, 256);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 17;
            label6.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNacionalidad.Location = new Point(541, 253);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(100, 25);
            txtNacionalidad.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(217, 253);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 15;
            label7.Text = "Ocupación";
            // 
            // txtOcupación
            // 
            txtOcupación.Font = new Font("Segoe UI Symbol", 9.75F);
            txtOcupación.Location = new Point(302, 250);
            txtOcupación.Name = "txtOcupación";
            txtOcupación.Size = new Size(100, 25);
            txtOcupación.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(437, 211);
            label8.Name = "label8";
            label8.Size = new Size(52, 17);
            label8.TabIndex = 21;
            label8.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCorreo.Location = new Point(499, 208);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 25);
            txtCorreo.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(217, 208);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 19;
            label9.Text = "Teléfono";
            // 
            // txtTeléfono
            // 
            txtTeléfono.Font = new Font("Segoe UI Symbol", 9.75F);
            txtTeléfono.Location = new Point(290, 208);
            txtTeléfono.Name = "txtTeléfono";
            txtTeléfono.Size = new Size(112, 25);
            txtTeléfono.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(659, 215);
            label10.Name = "label10";
            label10.Size = new Size(70, 17);
            label10.TabIndex = 27;
            label10.Text = "Dirección";
            // 
            // txtDirección
            // 
            txtDirección.Font = new Font("Segoe UI Symbol", 9.75F);
            txtDirección.Location = new Point(737, 212);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(139, 25);
            txtDirección.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(667, 256);
            label11.Name = "label11";
            label11.Size = new Size(110, 17);
            label11.TabIndex = 25;
            label11.Text = "Nivel Educativo";
            // 
            // txtNivelEducativo
            // 
            txtNivelEducativo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNivelEducativo.Location = new Point(789, 256);
            txtNivelEducativo.Name = "txtNivelEducativo";
            txtNivelEducativo.Size = new Size(100, 25);
            txtNivelEducativo.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(659, 175);
            label12.Name = "label12";
            label12.Size = new Size(53, 17);
            label12.TabIndex = 23;
            label12.Text = "Cédula";
            // 
            // txtCédula
            // 
            txtCédula.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCédula.Location = new Point(724, 172);
            txtCédula.Name = "txtCédula";
            txtCédula.Size = new Size(152, 25);
            txtCédula.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MidnightBlue;
            label13.Location = new Point(192, 79);
            label13.Name = "label13";
            label13.Size = new Size(463, 31);
            label13.TabIndex = 28;
            label13.Text = "Ingrese Todos Los Datos Requeridos.";
            label13.Click += label13_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.registrado;
            pictureBox1.Location = new Point(789, 65);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Broadway", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(192, 106);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(575, 17);
            label14.TabIndex = 30;
            label14.Text = "_______________________________________________________________";
            label14.Click += label14_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(717, 423);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 35);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.DarkOrange;
            btnOrdenar.BackgroundImageLayout = ImageLayout.Center;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = SystemColors.ControlLightLight;
            btnOrdenar.Location = new Point(551, 423);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(141, 35);
            btnOrdenar.TabIndex = 32;
            btnOrdenar.Text = "Oredenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // FrmRegistropersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1208, 705);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
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
        private Button btnEliminar;
        private Button btnOrdenar;
    }
}