namespace ToDo.Desktop
{
    partial class FrmLogin
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
            btnSalir = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            linkRegistrarme = new LinkLabel();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.Location = new Point(104, 170);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 37);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(71, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(71, 95);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(332, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Segoe UI", 10F);
            btnAcceder.Location = new Point(279, 170);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(129, 37);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "&Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += BtnAcceder_Click;
            // 
            // linkRegistrarme
            // 
            linkRegistrarme.AutoSize = true;
            linkRegistrarme.Location = new Point(382, 230);
            linkRegistrarme.Name = "linkRegistrarme";
            linkRegistrarme.Size = new Size(89, 20);
            linkRegistrarme.TabIndex = 4;
            linkRegistrarme.TabStop = true;
            linkRegistrarme.Text = "Registrarme";
            linkRegistrarme.LinkClicked += LinkRegistrarme_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 275);
            Controls.Add(linkRegistrarme);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnSalir);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnAcceder;
        private LinkLabel linkRegistrarme;
    }
}