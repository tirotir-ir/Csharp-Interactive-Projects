using System;
using System.Windows.Forms;

namespace Project20_ShowTime
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btn.Click += (s,e)=> MessageBox.Show(DateTime.Now.ToString());
    }

    
  }
}
