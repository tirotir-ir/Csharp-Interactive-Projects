using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project13_ThemeToggle
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnToggle.Click += (s,e)=>{ dark=!dark; BackColor=dark?System.Drawing.Color.Black:System.Drawing.Color.White; ForeColor=dark?System.Drawing.Color.White:System.Drawing.Color.Black; };
    }

    
  }
}
