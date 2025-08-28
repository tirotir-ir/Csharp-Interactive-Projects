#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project11_ProgressDemo
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private ProgressBar bar; private Button btnStart; private System.Windows.Forms.Timer t;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      bar=new ProgressBar(){Left=20,Top=20,Width=300}; btnStart=new Button(){Left=20,Top=60,Text="Start"}; t=new System.Windows.Forms.Timer(this.components){Interval=100};Controls.Add(bar); Controls.Add(btnStart); Text="Progress"; ClientSize=new Size(360,110);
    }
  }
}
