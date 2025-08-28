#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project12_TwoFormsComm
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txt; private Button btnOpen;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      txt=new TextBox(){Left=20,Top=20,Width=200}; btnOpen=new Button(){Left=230,Top=18,Text="Open"};Controls.Add(txt); Controls.Add(btnOpen); Text="TwoForms"; ClientSize=new Size(300,80);
    }
  }
}
