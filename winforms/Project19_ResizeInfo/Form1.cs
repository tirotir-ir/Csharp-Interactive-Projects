using System;
using System.Windows.Forms;

namespace Project19_ResizeInfo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Resize += (s,e)=> lbl.Text=$"W:{Width} H:{Height}";
    }

    
  }
}
