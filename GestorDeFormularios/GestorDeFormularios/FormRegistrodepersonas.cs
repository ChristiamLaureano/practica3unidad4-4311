using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeFormularios
{
    public partial class FrmRegistropersonas : Form
    {
        public FrmRegistropersonas()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add(
                txtNombre.Text, txtApellido.Text,
                txtCédula.Text, dtpFechaNacimiento.Value.ToShortDateString(),
                txtCorreo.Text, txtTeléfono.Text, txtDirección.Text, txtNivelEducativo.Text,
                txtOcupación.Text, cmbEstadoCivil.SelectedItem, cmbSexo.SelectedItem,
                txtNacionalidad.Text
                );
            LimpiarCampos();

        }

        //metodo para limpiar los campos de texto y combobox
        private void LimpiarCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }

        private void FrmRegistropersonas_Load(object sender, EventArgs e)
        {
            // Asegúrate de que el DataGridView tenga 12 columnas
            dgvPersonas.ColumnCount = 12;

            // Configura los encabezados de las columnas
            dgvPersonas.Columns[0].Name = "Nombre";
            dgvPersonas.Columns[1].Name = "Apellido";
            dgvPersonas.Columns[2].Name = "Cédula";
            dgvPersonas.Columns[3].Name = "Fecha de Nacimiento";
            dgvPersonas.Columns[4].Name = "Correo Electrónico";
            dgvPersonas.Columns[5].Name = "Teléfono";
            dgvPersonas.Columns[6].Name = "Dirección";
            dgvPersonas.Columns[7].Name = "Nivel Educativo";
            dgvPersonas.Columns[8].Name = "Ocupación";
            dgvPersonas.Columns[9].Name = "Estado Civil";
            dgvPersonas.Columns[10].Name = "Sexo";
            dgvPersonas.Columns[11].Name = "Nacionalidad";



        }
    }
}
