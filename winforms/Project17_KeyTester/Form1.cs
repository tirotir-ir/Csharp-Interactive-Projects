using System;
using System.Windows.Forms;

namespace Project17_KeyTester
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.KeyPreview=true; this.KeyDown += (s,e)=> list.Items.Add(e.KeyCode.ToString());
    }

    
  }
}
