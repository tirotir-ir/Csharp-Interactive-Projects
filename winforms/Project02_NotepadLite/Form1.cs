using System;
using System.Windows.Forms;

namespace Project02_NotepadLite
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      open.Click += openToolStripMenuItem_Click; save.Click += saveToolStripMenuItem_Click;
    }

    private void openToolStripMenuItem_Click(object? s, EventArgs e){ using var ofd=new OpenFileDialog(); if(ofd.ShowDialog()==DialogResult.OK) txt.Text=System.IO.File.ReadAllText(ofd.FileName); }
private void saveToolStripMenuItem_Click(object? s, EventArgs e){ using var sfd=new SaveFileDialog(); if(sfd.ShowDialog()==DialogResult.OK) System.IO.File.WriteAllText(sfd.FileName, txt.Text); }
  }
}
