using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project15_NotifyIconDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      ni.ShowBalloonTip(2000); this.FormClosed += (s,e)=>ni.Dispose();
    }

    
  }
}
