namespace ToDo.Desktop.Tarea
{
    partial class FrmAltaCuenta
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
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            lblFechaLimite = new Label();
            lblDuracion = new Label();
            nudDuracion = new NumericUpDown();
            dtpFechaLimite = new DateTimePicker();
            lblPrioridad = new Label();
            lblResponsable = new Label();
            CboPrioridad = new ComboBox();
            CboResponsable = new ComboBox();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre de la tarea:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(44, 97);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(181, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción/Instrucciones:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 59);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(499, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 120);
            txtDescripcion.MaxLength = 500;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(499, 168);
            txtDescripcion.TabIndex = 3;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Location = new Point(290, 308);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(92, 20);
            lblFechaLimite.TabIndex = 4;
            lblFechaLimite.Text = "Fecha limite:";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(44, 308);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(111, 20);
            lblDuracion.TabIndex = 5;
            lblDuracion.Text = "Duración (Hrs.):";
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(100, 346);
            nudDuracion.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(95, 27);
            nudDuracion.TabIndex = 6;
            nudDuracion.TextAlign = HorizontalAlignment.Right;
            nudDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(349, 343);
            dtpFechaLimite.MinDate = new DateTime(2026, 10, 6, 21, 9, 32, 53);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(250, 27);
            dtpFechaLimite.TabIndex = 7;
            dtpFechaLimite.Value = new DateTime(2026, 10, 6, 21, 9, 32, 53);
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(44, 407);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(73, 20);
            lblPrioridad.TabIndex = 9;
            lblPrioridad.Text = "Prioridad:";
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(290, 407);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(96, 20);
            lblResponsable.TabIndex = 8;
            lblResponsable.Text = "Responsable:";
            // 
            // CboPrioridad
            // 
            CboPrioridad.FormattingEnabled = true;
            CboPrioridad.Location = new Point(100, 430);
            CboPrioridad.Name = "CboPrioridad";
            CboPrioridad.Size = new Size(176, 28);
            CboPrioridad.TabIndex = 10;
            CboPrioridad.SelectedIndexChanged += CboPrioridad_SelectedIndexChanged;
            // 
            // CboResponsable
            // 
            CboResponsable.FormattingEnabled = true;
            CboResponsable.Location = new Point(349, 430);
            CboResponsable.Name = "CboResponsable";
            CboResponsable.Size = new Size(250, 28);
            CboResponsable.TabIndex = 11;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(143, 494);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(133, 29);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(349, 494);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(133, 29);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FrmAltaCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 551);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            Controls.Add(CboResponsable);
            Controls.Add(CboPrioridad);
            Controls.Add(lblPrioridad);
            Controls.Add(lblResponsable);
            Controls.Add(dtpFechaLimite);
            Controls.Add(nudDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(lblFechaLimite);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "FrmAltaCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de tarea";
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblFechaLimite;
        private Label lblDuracion;
        private NumericUpDown nudDuracion;
        private DateTimePicker dtpFechaLimite;
        private Label lblPrioridad;
        private Label lblResponsable;
        private ComboBox CboPrioridad;
        private ComboBox CboResponsable;
        private Button BtnCancelar;
        private Button BtnGuardar;
    }
}