namespace ToDo.Desktop
{
    partial class FrmRegistro
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
            btnConfirmar = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnSalir = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 10F);
            btnConfirmar.Location = new Point(276, 224);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(129, 37);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(332, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "admin1234";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 27);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "juan_p@gmail.com";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(68, 149);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(68, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.Location = new Point(101, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 37);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(332, 27);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Juan Perez";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(68, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 20);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Su nombre:";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 348);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnSalir);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro en ToDO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnSalir;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}