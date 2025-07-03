namespace GestorDeFormularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistropersonas frm = new FrmRegistropersonas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
