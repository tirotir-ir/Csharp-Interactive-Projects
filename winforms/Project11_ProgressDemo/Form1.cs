using System;
using System.Windows.Forms;

namespace Project11_ProgressDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      int v=0; t.Tick+=(s,e)=>{ v=Math.Min(v+2,100); bar.Value=v; if(v==100) t.Stop(); }; btnStart.Click+=(s,e)=>{ v=0; bar.Value=0; t.Start(); };
    }

    
  }
}
