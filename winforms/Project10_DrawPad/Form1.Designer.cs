#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project10_DrawPad
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      Text="DrawPad"; ClientSize=new Size(600,400);
    }
  }
}
