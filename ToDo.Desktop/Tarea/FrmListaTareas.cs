using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDo.Entities;

namespace ToDo.Desktop.Tarea
{
    public partial class FrmListaTareas : Form
    {
        public FrmListaTareas(List<Entities.Tarea> tareas)
        {
            InitializeComponent();
            dgvListaTareas.DataSource = tareas;
            checkedListBox1.DataSource = tareas;
        }
    }
}
