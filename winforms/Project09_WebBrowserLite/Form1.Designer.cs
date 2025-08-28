#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project09_WebBrowserLite
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txt; private Button btnGo; private WebBrowser web;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            txt = new TextBox();
            btnGo = new Button();
            web = new WebBrowser();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(0, 0);
            txt.Name = "txt";
            txt.Size = new Size(100, 23);
            txt.TabIndex = 2;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(0, 0);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 1;
            // 
            // web
            // 
            web.Location = new Point(0, 0);
            web.Name = "web";
            web.Size = new Size(250, 250);
            web.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(784, 561);
            Controls.Add(web);
            Controls.Add(btnGo);
            Controls.Add(txt);
            Name = "Form1";
            Text = "WebBrowser";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
