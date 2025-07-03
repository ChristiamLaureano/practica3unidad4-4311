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
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNombre.Location = new Point(252, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(112, 25);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label1.Location = new Point(179, 113);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI Symbol", 9.75F);
            dtpFechaNacimiento.Location = new Point(179, 296);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(227, 25);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbSexo.Location = new Point(478, 296);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 25);
            cmbSexo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(873, 145);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 28);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(12, 368);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(1066, 184);
            dgvPersonas.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DodgerBlue;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(873, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 28);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.Font = new Font("Segoe UI Symbol", 9.75F);
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltero", "Casado" });
            cmbEstadoCivil.Location = new Point(690, 296);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 25);
            cmbEstadoCivil.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label2.Location = new Point(478, 278);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = " Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label3.Location = new Point(690, 278);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 10;
            label3.Text = "Estado Civil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label4.Location = new Point(179, 268);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label5.Location = new Point(399, 115);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI Symbol", 9.75F);
            txtApellido.Location = new Point(461, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 25);
            txtApellido.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label6.Location = new Point(399, 201);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 17;
            label6.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNacionalidad.Location = new Point(494, 196);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(100, 25);
            txtNacionalidad.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label7.Location = new Point(179, 199);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 15;
            label7.Text = "Ocupación";
            // 
            // txtOcupación
            // 
            txtOcupación.Font = new Font("Segoe UI Symbol", 9.75F);
            txtOcupación.Location = new Point(264, 196);
            txtOcupación.Name = "txtOcupación";
            txtOcupación.Size = new Size(100, 25);
            txtOcupación.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label8.Location = new Point(399, 156);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 21;
            label8.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCorreo.Location = new Point(461, 154);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(133, 25);
            txtCorreo.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label9.Location = new Point(179, 154);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 19;
            label9.Text = "Teléfono";
            // 
            // txtTeléfono
            // 
            txtTeléfono.Font = new Font("Segoe UI Symbol", 9.75F);
            txtTeléfono.Location = new Point(252, 154);
            txtTeléfono.Name = "txtTeléfono";
            txtTeléfono.Size = new Size(112, 25);
            txtTeléfono.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label10.Location = new Point(621, 161);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 27;
            label10.Text = "Dirección";
            // 
            // txtDirección
            // 
            txtDirección.Font = new Font("Segoe UI Symbol", 9.75F);
            txtDirección.Location = new Point(699, 158);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(139, 25);
            txtDirección.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label11.Location = new Point(628, 206);
            label11.Name = "label11";
            label11.Size = new Size(104, 15);
            label11.TabIndex = 25;
            label11.Text = "Nivel Educativo";
            // 
            // txtNivelEducativo
            // 
            txtNivelEducativo.Font = new Font("Segoe UI Symbol", 9.75F);
            txtNivelEducativo.Location = new Point(738, 203);
            txtNivelEducativo.Name = "txtNivelEducativo";
            txtNivelEducativo.Size = new Size(100, 25);
            txtNivelEducativo.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label12.Location = new Point(621, 120);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 23;
            label12.Text = "Cédula";
            // 
            // txtCédula
            // 
            txtCédula.Font = new Font("Segoe UI Symbol", 9.75F);
            txtCédula.Location = new Point(686, 117);
            txtCédula.Name = "txtCédula";
            txtCédula.Size = new Size(152, 25);
            txtCédula.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(179, 45);
            label13.Name = "label13";
            label13.Size = new Size(288, 20);
            label13.TabIndex = 28;
            label13.Text = "Ingrese Todos Los Datos Requeridos.";
            // 
            // FrmRegistropersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1090, 578);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistropersonas";
            Text = "Registro de personas";
            Load += FrmRegistropersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
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
    }
}