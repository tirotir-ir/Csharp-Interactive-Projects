#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project20_ShowTime
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private Button btn;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      btn=new Button(){Dock=DockStyle.Fill,Text="Show Time"}; Controls.Add(btn); Text="ShowTime"; Width=240; Height=120;
    }
  }
}
