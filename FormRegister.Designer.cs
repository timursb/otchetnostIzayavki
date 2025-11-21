using System.Windows.Forms;

namespace dnevnikApp
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblFirst;
        private Label lblLast;
        private Label lblLogin;
        private Label lblPassword;
        private Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(110, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(110, 80);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblFirst
            // 
            this.lblFirst.Location = new System.Drawing.Point(30, 20);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(74, 23);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Имя:";
            // 
            // lblLast
            // 
            this.lblLast.Location = new System.Drawing.Point(30, 50);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(74, 23);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Фамилия:";
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(30, 80);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(74, 23);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(30, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(80, 150);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormRegister
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}