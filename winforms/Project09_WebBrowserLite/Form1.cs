using System;
using System.Windows.Forms;

namespace Project09_WebBrowserLite
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnGo.Click += (s,e)=>{ try{ web.Navigate(txt.Text); } catch{} };
    }

    
  }
}
