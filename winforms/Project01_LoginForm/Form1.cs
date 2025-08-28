using System;
using System.Windows.Forms;

namespace Project01_LoginForm
{
  public partial class Form1 : Form
  {
        //public Form1()
        //{
        //  InitializeComponent();
        //  btnLogin.Click += btnLogin_Click;
        //}


        public Form1()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;

            // مقداردهی‌ها بعد از InitializeComponent
            txtUser.PlaceholderText = "Username";
            txtPass.PlaceholderText = "Password";
            txtPass.UseSystemPasswordChar = true;

            // نمایش Placeholderها در شروع:
            this.Shown += (s, e) => this.ActiveControl = btnLogin; // یا هر کنترل غیرمتنی
        }




        private void btnLogin_Click(object? s, EventArgs e){ MessageBox.Show((txtUser.Text=="admin" && txtPass.Text=="1234")?"Welcome":"Invalid"); }
  }
}
