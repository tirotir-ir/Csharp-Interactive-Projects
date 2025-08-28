#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project19_ResizeInfo
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private Label lbl;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      lbl=new Label(){Dock=DockStyle.Fill, TextAlign=System.Drawing.ContentAlignment.MiddleCenter, Text="Resize me"}; Controls.Add(lbl); Text="ResizeInfo"; Width=300; Height=200;
    }
  }
}
