using System.ComponentModel;
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
            NuevaCuenta = new Cuenta()
            {
                Owner = new Administrador()
                {
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                },
                TipoDeCuenta = TipoCuenta.Personal                
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
