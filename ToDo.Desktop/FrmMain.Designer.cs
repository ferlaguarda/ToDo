namespace ToDo.Desktop
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            equiposToolStripMenuItem = new ToolStripMenuItem();
            miCuentaToolStripMenuItem = new ToolStripMenuItem();
            Tsmi_MisDatos = new ToolStripMenuItem();
            Tsmi_Logout = new ToolStripMenuItem();
            Tsmi_Cerrar = new ToolStripMenuItem();
            Tsmi_Nueva_Tarea = new ToolStripMenuItem();
            Tsmi_Ver_Tareas = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tareasToolStripMenuItem, equiposToolStripMenuItem, miCuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1166, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tsmi_Nueva_Tarea, Tsmi_Ver_Tareas });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(64, 24);
            tareasToolStripMenuItem.Text = "&Tareas";
            // 
            // equiposToolStripMenuItem
            // 
            equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            equiposToolStripMenuItem.Size = new Size(76, 24);
            equiposToolStripMenuItem.Text = "&Equipos";
            // 
            // miCuentaToolStripMenuItem
            // 
            miCuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tsmi_MisDatos, Tsmi_Logout, Tsmi_Cerrar });
            miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            miCuentaToolStripMenuItem.Size = new Size(90, 24);
            miCuentaToolStripMenuItem.Text = "Mi &Cuenta";
            // 
            // Tsmi_MisDatos
            // 
            Tsmi_MisDatos.Name = "Tsmi_MisDatos";
            Tsmi_MisDatos.Size = new Size(224, 26);
            Tsmi_MisDatos.Text = "Mis datos";
            Tsmi_MisDatos.Click += Tsmi_MisDatos_Click;
            // 
            // Tsmi_Logout
            // 
            Tsmi_Logout.Name = "Tsmi_Logout";
            Tsmi_Logout.Size = new Size(224, 26);
            Tsmi_Logout.Text = "Logout";
            Tsmi_Logout.Click += Tsmi_Logout_Click;
            // 
            // Tsmi_Cerrar
            // 
            Tsmi_Cerrar.Name = "Tsmi_Cerrar";
            Tsmi_Cerrar.Size = new Size(224, 26);
            Tsmi_Cerrar.Text = "Cerrar";
            Tsmi_Cerrar.Click += Tsmi_Cerrar_Click;
            // 
            // Tsmi_Nueva_Tarea
            // 
            Tsmi_Nueva_Tarea.Name = "Tsmi_Nueva_Tarea";
            Tsmi_Nueva_Tarea.Size = new Size(224, 26);
            Tsmi_Nueva_Tarea.Text = "Nueva";
            Tsmi_Nueva_Tarea.Click += Tsmi_Nueva_Tarea_Click;
            // 
            // Tsmi_Ver_Tareas
            // 
            Tsmi_Ver_Tareas.Name = "Tsmi_Ver_Tareas";
            Tsmi_Ver_Tareas.Size = new Size(224, 26);
            Tsmi_Ver_Tareas.Text = "Ver todas";
            Tsmi_Ver_Tareas.Click += Tsmi_Ver_Tareas_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 661);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDO";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem equiposToolStripMenuItem;
        private ToolStripMenuItem miCuentaToolStripMenuItem;
        private ToolStripMenuItem Tsmi_MisDatos;
        private ToolStripMenuItem Tsmi_Logout;
        private ToolStripMenuItem Tsmi_Cerrar;
        private ToolStripMenuItem Tsmi_Nueva_Tarea;
        private ToolStripMenuItem Tsmi_Ver_Tareas;
    }
}