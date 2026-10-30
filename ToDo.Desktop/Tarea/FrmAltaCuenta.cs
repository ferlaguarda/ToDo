using ToDo.Entities.Enumerados;
using ToDo.Entities;
using ToDo.Dominio;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmAltaCuenta : Form
    {
        private List<Prioridad> _prioridades = new List<Prioridad>
        {
            Prioridad.Baja,
            Prioridad.Media,
            Prioridad.Alta,
            Prioridad.Critica
        };

        private Guid _idCuenta;

        public FrmAltaCuenta(Guid idCuenta)
        {
            InitializeComponent();
            CboPrioridad.DataSource = _prioridades;
            _idCuenta = idCuenta;
        }

        private void CboPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var selectedItem = comboBox.SelectedItem;
            Prioridad prio = (Prioridad)selectedItem;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var tarea = new Entities.Tarea()
            {
                IdCuenta = _idCuenta,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaCreacion = DateTime.UtcNow,
                DuracionEstimada = (int)nudDuracion.Value,
                PrioridadTarea = CboPrioridad.SelectedItem != null 
                    ? (Prioridad)CboPrioridad.SelectedItem
                    : Prioridad.Media,
                EstadoTarea = Estado.Pendiente,
                FechaLimite = dtpFechaLimite.Checked ? dtpFechaLimite.Value : null,
                Responsable = CboResponsable.SelectedItem != null
                    ? (Usuario)CboResponsable.SelectedItem
                    : null
            };

            try
            {
                GestorTarea gestor = new GestorTarea();
                int tareaId = gestor.CrearTarea(tarea);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
