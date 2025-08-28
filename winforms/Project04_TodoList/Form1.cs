using System;
using System.Windows.Forms;

namespace Project04_TodoList
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnAdd.Click += (s,e)=>{ if(!string.IsNullOrWhiteSpace(txt.Text)) list.Items.Add(txt.Text); txt.Clear(); };btnDel.Click += (s,e)=>{ if(list.SelectedIndex>=0) list.Items.RemoveAt(list.SelectedIndex); };
    }

    
  }
}
