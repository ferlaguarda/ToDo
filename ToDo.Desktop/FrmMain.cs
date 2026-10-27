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
            Tarea.FrmAltaCuenta frmAlta = new Tarea.FrmAltaCuenta();
            //frmAlta.MdiParent = this;
            DialogResult resultALta = frmAlta.ShowDialog();
            if(resultALta == DialogResult.OK)
            {
                if (MiCuenta.Tareas is null)
                    MiCuenta.Tareas = [];

                if (frmAlta.NuevaTarea is not null)
                    MiCuenta.Tareas.Add(frmAlta.NuevaTarea);
            }
            if (MiCuenta.Tareas is not null)
                MessageBox.Show($"Tareas: {MiCuenta.Tareas.Count}");
        }

        private void Tsmi_Ver_Tareas_Click(object sender, EventArgs e)
        {
            if (MiCuenta.Tareas is null)
            {
                MessageBox.Show($"No hay tareas registradas para visualizar.");
                return;
            }
            FrmListaTareas frmTareas = new FrmListaTareas(MiCuenta.Tareas);
            frmTareas.MdiParent = this;
            frmTareas.Show();
        }
    }
}
