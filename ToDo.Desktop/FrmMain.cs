using ToDo.Desktop.Tarea;
using ToDo.Entities;
using ToDo.Entities.Constantes;

namespace ToDo.Desktop
{
    public partial class FrmMain : Form
    {
        public Cuenta MiCuenta;

        public FrmMain(Cuenta cuenta)
        {
            InitializeComponent();
            MiCuenta = cuenta;
        }

        public FrmMain(Dictionary<string, string> datosCuenta)
        {
            InitializeComponent();
            MiCuenta = new Cuenta
            {
                Id = new Guid(datosCuenta[ConstantesDeSesion.ID_CUENTA]),
                Owner = new Administrador
                {
                    Id = Convert.ToInt32(datosCuenta[ConstantesDeSesion.ID_USUARIO]),
                    Nombre = datosCuenta[ConstantesDeSesion.NOMBRE_USUARIO],
                    Email = datosCuenta[ConstantesDeSesion.CORREO_USUARIO],
                    Password = ""
                }
            };
        }
        private void Tsmi_MisDatos_Click(object sender, EventArgs e)
        {

        }

        private void Tsmi_Logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Tsmi_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Tsmi_Nueva_Tarea_Click(object sender, EventArgs e)
        {
            Tarea.FrmAltaCuenta frmAlta = new Tarea.FrmAltaCuenta(MiCuenta.Id);
            //frmAlta.MdiParent = this;
            DialogResult resultALta = frmAlta.ShowDialog();
            if(resultALta == DialogResult.OK)
            {
                MessageBox.Show($"La tarea fue agregada satisfactoriamente.");
            }
        }

        private void Tsmi_Ver_Tareas_Click(object sender, EventArgs e)
        {
            FrmListaTareas frmTareas = new FrmListaTareas(MiCuenta.Id);
            frmTareas.MdiParent = this;
            frmTareas.Show();
        }
    }
}
