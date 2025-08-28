#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project17_KeyTester
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private ListBox list;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      list=new ListBox(){Dock=DockStyle.Fill}; Controls.Add(list); Text="KeyTester"; Width=300; Height=200;
    }
  }
}
