using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project06_PictureViewer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnOpen.Click += (s,e)=>{ using var ofd=new OpenFileDialog(); ofd.Filter="Images|*.png;*.jpg;*.jpeg;*.bmp"; if(ofd.ShowDialog()==DialogResult.OK) pic.Image=Image.FromFile(ofd.FileName); };
    }

    
  }
}
