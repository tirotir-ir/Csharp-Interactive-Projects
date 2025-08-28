using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project07_ColorPickerTracks
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      r.Scroll += (s,e)=>UpdateColor(); g.Scroll += (s,e)=>UpdateColor(); b.Scroll += (s,e)=>UpdateColor(); UpdateColor();
    }

    private void UpdateColor(){ preview.BackColor = System.Drawing.Color.FromArgb(r.Value, g.Value, b.Value); }
  }
}
