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
            dgvListaTareas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaTareas
            // 
            dgvListaTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTareas.Location = new Point(41, 21);
            dgvListaTareas.Name = "dgvListaTareas";
            dgvListaTareas.RowHeadersWidth = 51;
            dgvListaTareas.Size = new Size(785, 366);
            dgvListaTareas.TabIndex = 0;
            // 
            // FrmListaTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 430);
            Controls.Add(dgvListaTareas);
            Name = "FrmListaTareas";
            Text = "Lista de tareas registradas";
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaTareas;
    }
}