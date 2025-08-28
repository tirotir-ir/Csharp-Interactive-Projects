using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project10_DrawPad
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.DoubleBuffered=true; System.Drawing.Point last=new System.Drawing.Point(); bool drawing=false; this.MouseDown += (s,e)=>{ drawing=true; last=e.Location; }; this.MouseMove += (s,e)=>{ if(drawing){ using var g=CreateGraphics(); g.DrawLine(System.Drawing.Pens.Black,last,e.Location); last=e.Location; } }; this.MouseUp += (s,e)=>{ drawing=false; };
    }

    
  }
}
