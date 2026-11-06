using ToDo.Dominio;
using ToDo.Entities;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmListaTareas : Form
    {
        private GestorTarea _gestorTarea = new GestorTarea();
        private Guid _cuentaId;

        public FrmListaTareas(Guid cuentaId)
        {
            InitializeComponent();
            _cuentaId = cuentaId;
            CargarTareas();
        }

        private void DgvListaTareas_SelectionChanged(object sender, EventArgs e)
        {
            CheckTaskSelection(dgvListaTareas.SelectedRows.Count);
            if (dgvListaTareas.SelectedRows.Count > 0)
            {
                // Obtener datos de la fila seleccionada
                var tarea = dgvListaTareas.SelectedRows[0].DataBoundItem as ToDo.Entities.Tarea;
            }
        }

        private void CheckTaskSelection(int selectedTaskNumber)
        {
            gbTaskActions.Enabled = (selectedTaskNumber > 0);
            if (selectedTaskNumber > 1)
            {
                btnEdit.Enabled = false;
                btnInfo.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnInfo.Enabled = true;
            }
        }

        private void CargarTareas()
        {
            dgvListaTareas.DataSource = null;
            dgvListaTareas.DataSource = _gestorTarea.ObtenerTareasPorCuenta(_cuentaId); 
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tarea.FrmAltaCuenta frmAlta = new Tarea.FrmAltaCuenta(_cuentaId);
            DialogResult resultALta = frmAlta.ShowDialog();
            if (resultALta == DialogResult.OK)
            {
                MessageBox.Show($"La tarea fue agregada satisfactoriamente.");
                CargarTareas();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnComment_Click(object sender, EventArgs e)
        {

        }

        private void BtnAsign_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
