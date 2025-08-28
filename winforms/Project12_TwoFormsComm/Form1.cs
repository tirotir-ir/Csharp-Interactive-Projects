using System;
using System.Windows.Forms;

namespace Project12_TwoFormsComm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnOpen.Click += (s,e)=>{ using var f=new Form{ Text="Child", Width=300, Height=200}; f.Controls.Add(new Label{Text=txt.Text, Dock=DockStyle.Fill, TextAlign=System.Drawing.ContentAlignment.MiddleCenter}); f.ShowDialog(); };
    }

    
  }
}
