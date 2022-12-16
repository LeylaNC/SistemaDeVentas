namespace CapaVisual
{
    partial class LoginBackoffice
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
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(330, 178);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(123, 31);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(289, 60);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "Email";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(289, 95);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(353, 59);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(138, 20);
            this.TxtBoxEmail.TabIndex = 3;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(353, 88);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(138, 20);
            this.TxtBoxPassword.TabIndex = 4;
            // 
            // LoginBackoffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Name = "LoginBackoffice";
            this.Text = "LoginBackoffice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPassword;
    }
}