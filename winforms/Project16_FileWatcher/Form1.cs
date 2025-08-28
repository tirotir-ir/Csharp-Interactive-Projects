using System;
using System.Windows.Forms;

namespace Project16_FileWatcher
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      w.Path=Environment.GetFolderPath(Environment.SpecialFolder.Desktop); w.Created+=(s,e)=>list.Items.Add("Created: "+e.Name); w.EnableRaisingEvents=true;
    }

    
  }
}
