using ToDo.Entities;

namespace ToDo.Desktop
{
    public partial class FrmLogin : Form
    {
        private List<Cuenta> _cuentas;
        public FrmLogin()
        {
            InitializeComponent();
            _cuentas = [];
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                MessageBox.Show("El correo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("La contraseña es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            bool existecuenta = false;
            foreach (var cuenta in _cuentas)
            {
                if (cuenta.Owner.Email == txtEmail.Text)
                {
                    if (cuenta.Owner.Password == txtPassword.Text)
                    {
                        existecuenta = true;
                        FrmMain main = new FrmMain(cuenta);
                        this.Hide();
                        DialogResult result = main.ShowDialog();
                        if (result == DialogResult.Cancel)
                        {
                            LimpiarControles();
                            this.Show();
                        }
                        else if (result == DialogResult.Abort)
                            this.Close();

                    }
                }
            }
            if(!existecuenta)
                MessageBox.Show("Las credenciales no son correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LinkRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            var result = registro.ShowDialog();

            if (result == DialogResult.OK)
            {
                _cuentas.Add(registro.NuevaCuenta);
                txtEmail.Text = registro.NuevaCuenta.Owner.Email;
            }
        }

        private void LimpiarControles()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
