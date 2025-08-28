using System;
using System.Windows.Forms;

namespace Project05_StopwatchTimer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      int sec=0; t.Tick += (s,e)=>{ sec++; lbl.Text=$"{sec}s"; }; btnStart.Click += (s,e)=>{ sec=0; lbl.Text="0s"; t.Start(); }; btnStop.Click += (s,e)=> t.Stop();
    }

    
  }
}
