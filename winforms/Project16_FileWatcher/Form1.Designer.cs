#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project16_FileWatcher
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private FileSystemWatcher w; private ListBox list;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      w=new FileSystemWatcher(); list=new ListBox(){Dock=DockStyle.Fill}; Controls.Add(list); Text="FileWatcher"; Width=400; Height=300;
    }
  }
}
