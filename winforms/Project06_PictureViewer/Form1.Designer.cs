#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project06_PictureViewer
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private PictureBox pic; private Button btnOpen;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      pic=new PictureBox(){Dock=DockStyle.Fill,SizeMode=PictureBoxSizeMode.Zoom};btnOpen=new Button(){Dock=DockStyle.Top,Text="Open"}; Controls.Add(pic); Controls.Add(btnOpen);Text="PictureViewer"; Width=640; Height=480;
    }
  }
}
