#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project13_ThemeToggle
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private Button btnToggle; private bool dark;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      btnToggle=new Button(){Left=20,Top=20,Text="Toggle"}; Controls.Add(btnToggle); Text="Theme"; ClientSize=new Size(200,80);
    }
  }
}
