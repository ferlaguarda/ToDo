using ToDo.Dominio;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmListaTareas : Form
    {
        public FrmListaTareas(Guid cuentaId)
        {
            InitializeComponent();
            GestorTarea gestorTarea = new GestorTarea();
            dgvListaTareas.DataSource = gestorTarea.ObtenerTareasPorCuenta(cuentaId);
            //checkedListBox1.DataSource = tareas;
        }
    }
}
