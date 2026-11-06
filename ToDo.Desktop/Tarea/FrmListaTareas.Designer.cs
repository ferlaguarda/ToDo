namespace ToDo.Desktop.Tarea
{
    partial class FrmListaTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvListaTareas = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaLimiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoTareaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prioridadTareaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tareaBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            gbTaskActions = new GroupBox();
            btnRemove = new Button();
            btnAsign = new Button();
            btnComment = new Button();
            btnEdit = new Button();
            btnInfo = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tareaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbTaskActions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListaTareas
            // 
            dgvListaTareas.AllowUserToAddRows = false;
            dgvListaTareas.AllowUserToDeleteRows = false;
            dgvListaTareas.AllowUserToResizeColumns = false;
            dgvListaTareas.AutoGenerateColumns = false;
            dgvListaTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTareas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, fechaLimiteDataGridViewTextBoxColumn, estadoTareaDataGridViewTextBoxColumn, prioridadTareaDataGridViewTextBoxColumn, responsableDataGridViewTextBoxColumn });
            dgvListaTareas.DataSource = tareaBindingSource;
            dgvListaTareas.Dock = DockStyle.Fill;
            dgvListaTareas.Location = new Point(0, 0);
            dgvListaTareas.Name = "dgvListaTareas";
            dgvListaTareas.ReadOnly = true;
            dgvListaTareas.RowHeadersWidth = 51;
            dgvListaTareas.Size = new Size(1220, 507);
            dgvListaTareas.TabIndex = 0;
            dgvListaTareas.SelectionChanged += DgvListaTareas_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 25F;
            idDataGridViewTextBoxColumn.HeaderText = "Nr.";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.FillWeight = 150F;
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaLimiteDataGridViewTextBoxColumn
            // 
            fechaLimiteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaLimiteDataGridViewTextBoxColumn.DataPropertyName = "FechaLimite";
            fechaLimiteDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            fechaLimiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaLimiteDataGridViewTextBoxColumn.Name = "fechaLimiteDataGridViewTextBoxColumn";
            fechaLimiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoTareaDataGridViewTextBoxColumn
            // 
            estadoTareaDataGridViewTextBoxColumn.DataPropertyName = "EstadoTarea";
            estadoTareaDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoTareaDataGridViewTextBoxColumn.MinimumWidth = 6;
            estadoTareaDataGridViewTextBoxColumn.Name = "estadoTareaDataGridViewTextBoxColumn";
            estadoTareaDataGridViewTextBoxColumn.ReadOnly = true;
            estadoTareaDataGridViewTextBoxColumn.Width = 125;
            // 
            // prioridadTareaDataGridViewTextBoxColumn
            // 
            prioridadTareaDataGridViewTextBoxColumn.DataPropertyName = "PrioridadTarea";
            prioridadTareaDataGridViewTextBoxColumn.HeaderText = "Prioridad";
            prioridadTareaDataGridViewTextBoxColumn.MinimumWidth = 6;
            prioridadTareaDataGridViewTextBoxColumn.Name = "prioridadTareaDataGridViewTextBoxColumn";
            prioridadTareaDataGridViewTextBoxColumn.ReadOnly = true;
            prioridadTareaDataGridViewTextBoxColumn.Width = 125;
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            responsableDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            responsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable";
            responsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            responsableDataGridViewTextBoxColumn.MinimumWidth = 6;
            responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            responsableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareaBindingSource
            // 
            tareaBindingSource.DataSource = typeof(Entities.Tarea);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbTaskActions);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvListaTareas);
            splitContainer1.Size = new Size(1220, 594);
            splitContainer1.SplitterDistance = 83;
            splitContainer1.TabIndex = 1;
            // 
            // gbTaskActions
            // 
            gbTaskActions.Controls.Add(btnRemove);
            gbTaskActions.Controls.Add(btnAsign);
            gbTaskActions.Controls.Add(btnComment);
            gbTaskActions.Controls.Add(btnEdit);
            gbTaskActions.Controls.Add(btnInfo);
            gbTaskActions.Enabled = false;
            gbTaskActions.Location = new Point(835, 3);
            gbTaskActions.Name = "gbTaskActions";
            gbTaskActions.Size = new Size(382, 77);
            gbTaskActions.TabIndex = 3;
            gbTaskActions.TabStop = false;
            gbTaskActions.Text = "Acciones sobre tareas";
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = Properties.Resources.Block_1__Streamline_Plump;
            btnRemove.Location = new Point(302, 22);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(68, 49);
            btnRemove.TabIndex = 4;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnAsign
            // 
            btnAsign.FlatStyle = FlatStyle.Flat;
            btnAsign.Image = Properties.Resources.User_Switch_Account__Streamline_Plump;
            btnAsign.Location = new Point(228, 22);
            btnAsign.Name = "btnAsign";
            btnAsign.Size = new Size(68, 49);
            btnAsign.TabIndex = 4;
            btnAsign.UseVisualStyleBackColor = true;
            btnAsign.Click += BtnAsign_Click;
            // 
            // btnComment
            // 
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.Image = Properties.Resources.Video_Subtitles__Streamline_Plump;
            btnComment.Location = new Point(154, 22);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(68, 49);
            btnComment.TabIndex = 1;
            btnComment.UseVisualStyleBackColor = true;
            btnComment.Click += BtnComment_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.Pen_Tool__Streamline_Plump;
            btnEdit.Location = new Point(80, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(68, 49);
            btnEdit.TabIndex = 1;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Image = Properties.Resources.Information_Circle__Streamline_Plump;
            btnInfo.Location = new Point(6, 22);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(68, 49);
            btnInfo.TabIndex = 0;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += BtnInfo_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.Binoculars__Streamline_Plump;
            btnSearch.Location = new Point(727, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(68, 49);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.Application_Add__Streamline_Plump;
            btnAdd.Location = new Point(653, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 49);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // FrmListaTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 594);
            Controls.Add(splitContainer1);
            Name = "FrmListaTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mis tareas";
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tareaBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbTaskActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaTareas;
        private BindingSource tareaBindingSource;
        private SplitContainer splitContainer1;
        private Button btnInfo;
        private Button btnAdd;
        private Button btnSearch;
        private GroupBox gbTaskActions;
        private Button btnAsign;
        private Button btnComment;
        private Button btnEdit;
        private Button btnRemove;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaLimiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoTareaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prioridadTareaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
    }
}