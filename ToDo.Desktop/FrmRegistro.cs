using System.ComponentModel;
using ToDo.Dominio;
using ToDo.Entities;
using ToDo.Entities.Enumerados;

namespace ToDo.Desktop
{
    public partial class FrmRegistro : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Cuenta NuevaCuenta { get; set; }

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            GestorAutenticacion gestor = new GestorAutenticacion();
            try
            {
                NuevaCuenta = gestor.CrearCuenta(
                        txtNombre.Text,
                        txtEmail.Text,
                        txtPassword.Text
                        );
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
    }
}
