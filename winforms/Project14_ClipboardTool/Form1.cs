using System;
using System.Windows.Forms;

namespace Project14_ClipboardTool
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnCopy.Click+=(s,e)=>Clipboard.SetText(txt.Text); btnPaste.Click+=(s,e)=>{ if(Clipboard.ContainsText()) txt.Text=Clipboard.GetText(); };
    }

    
  }
}
