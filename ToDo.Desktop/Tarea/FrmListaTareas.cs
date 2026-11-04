using ToDo.Dominio;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmListaTareas : Form
    {
        private GestorTarea _gestorTarea;
        public FrmListaTareas(Guid cuentaId)
        {
            InitializeComponent();
            _gestorTarea = new GestorTarea();
            Configure_GridView();
            dgvListaTareas.DataSource = _gestorTarea.ObtenerTareasPorCuenta(cuentaId);
        }

        private void Configure_GridView()
        {
            dgvListaTareas.AutoGenerateColumns = false;
            AgregarColumnaEnGrilla("Id", "Nr.");
            AgregarColumnaEnGrilla("Nombre", "Nombre");
            AgregarColumnaEnGrilla("FechaLimite", "Vencimiento");
            AgregarColumnaEnGrilla("EstadoTarea", "Estado");
            AgregarColumnaEnGrilla("PrioridadTarea", "Prioridad");
            AgregarBtnEnGrilla("Modificar");
            AgregarBtnEnGrilla("Detalle");
            AgregarBtnEnGrilla("Eliminar");

            dgvListaTareas.CellContentClick += DgvCellContentClick;
        }

        private void AgregarColumnaEnGrilla(string propiedad, string cabezal)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = propiedad,
                HeaderText = cabezal,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvListaTareas.Columns.Add(columna);
        }

        private void AgregarBtnEnGrilla(string texto)
        {
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn()
            {
                Name = $"btn{texto}",
                Text = texto,
                HeaderText = string.Empty,
                UseColumnTextForButtonValue = true,
            };
            dgvListaTareas.Columns.Add(colBtn);

        }
    
        private void DgvCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string nombreColumna = dgvListaTareas.Columns[e.ColumnIndex].Name;
            var tarea = dgvListaTareas.Rows[e.RowIndex].DataBoundItem as ToDo.Entities.Tarea;
            var tarea2 = (ToDo.Entities.Tarea)dgvListaTareas.Rows[e.RowIndex].DataBoundItem;
            switch (nombreColumna)
            {
                case "btnModificar":
                    MessageBox.Show("Modificando");
                    break;
                case "btnDetalle":
                    MessageBox.Show("Mostrando detalle");
                    break;
                case "btnEliminar":
                    var dialogResult = MessageBox.Show("¿Está seguro de eliminar la tarea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            if (_gestorTarea.EliminarTarea(tarea.Id))
                            {
                                MessageBox.Show("Tarea eliminada correctamente");
                                dgvListaTareas.DataSource = _gestorTarea.ObtenerTareasPorCuenta(tarea.IdCuenta);
                            }
                            else
                                MessageBox.Show("No se pudo eliminar la tarea");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
                        }
                    }
                    break;
            }
        }


    }
}
