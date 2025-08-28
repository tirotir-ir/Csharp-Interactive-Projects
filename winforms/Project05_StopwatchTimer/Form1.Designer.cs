#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project05_StopwatchTimer
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private Label lbl; private Button btnStart, btnStop; private System.Windows.Forms.Timer t;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      lbl=new Label(){Left=20,Top=20,Width=200,Text="0s"}; btnStart=new Button(){Left=20,Top=60,Text="Start"};btnStop=new Button(){Left=100,Top=60,Text="Stop"}; t=new System.Windows.Forms.Timer(this.components){Interval=1000};Controls.AddRange(new Control[]{lbl,btnStart,btnStop}); Text="Stopwatch"; ClientSize=new Size(220,110);
    }
  }
}
