#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project01_LoginForm
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txtUser; private TextBox txtPass; private Button btnLogin;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(41, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(41, 41);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(50, 70);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(194, 123);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
