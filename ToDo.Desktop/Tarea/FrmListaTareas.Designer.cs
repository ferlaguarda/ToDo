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
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaTareas
            // 
            dgvListaTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTareas.Location = new Point(41, 21);
            dgvListaTareas.Name = "dgvListaTareas";
            dgvListaTareas.RowHeadersWidth = 51;
            dgvListaTareas.Size = new Size(649, 226);
            dgvListaTareas.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(140, 280);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(165, 114);
            checkedListBox1.TabIndex = 1;
            // 
            // FrmListaTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 430);
            Controls.Add(checkedListBox1);
            Controls.Add(dgvListaTareas);
            Name = "FrmListaTareas";
            Text = "Lista de tareas registradas";
            ((System.ComponentModel.ISupportInitialize)dgvListaTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaTareas;
        private CheckedListBox checkedListBox1;
    }
}