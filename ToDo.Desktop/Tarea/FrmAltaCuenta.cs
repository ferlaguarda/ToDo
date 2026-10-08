using ToDo.Entities.Enumerados;
using ToDo.Entities;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmAltaCuenta : Form
    {
        public Entities.Tarea? NuevaTarea { get; private set; }

        private List<Prioridad> _prioridades = new List<Prioridad>
        {
            Prioridad.Baja,
            Prioridad.Media,
            Prioridad.Alta,
            Prioridad.Critica
        };

        public FrmAltaCuenta()
        {
            InitializeComponent();
            CboPrioridad.DataSource = _prioridades;
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
            NuevaTarea = new Entities.Tarea()
            {
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
