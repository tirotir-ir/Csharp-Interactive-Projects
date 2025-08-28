#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project15_NotifyIconDemo
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private NotifyIcon ni;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      ni=new NotifyIcon(){Icon=System.Drawing.SystemIcons.Information, Visible=true, BalloonTipTitle="Hello", BalloonTipText="Tirotir AI"}; Text="NotifyIcon"; Width=300; Height=120;
    }
  }
}
